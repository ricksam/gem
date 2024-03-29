using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using GEM.Repository;
using GEM.Helpers;

namespace GEM.Controllers
{
    public class AvisoController : Controller
    {
        // GET: Aviso
        public ActionResult Index()
        {
            return View();
        }
        
        public ActionResult List(int Cod_Comum = 0)
        {
            var session = UserSession.Get(Request.HttpContext);
            var usuario = session.Usuario;
            if(Cod_Comum == 0 || !usuario.Admin){
                Cod_Comum = usuario.Cod_Comum;
            }

            var lista = Aviso.List(Cod_Comum, usuario.Admin, usuario.Instrutor, usuario.Oficializado, usuario.RJM, usuario.Aluno);
            int maxDbAviso = lista.Count != 0 ? lista.Max(e => e.Cod_Aviso) : 0;

            if(maxDbAviso > session.AvisoMax  || maxDbAviso > session.Usuario.AvisoLido){
                session.AvisoMax = maxDbAviso;
                session.Usuario.AvisoLido = maxDbAviso;
                
                Usuario usuarioDb = Usuario.Find(session.Cod_Usuario());
                usuarioDb.AvisoLido = maxDbAviso;
                usuarioDb.UpdateAvisoLido();

                UserSession.Set(Request.HttpContext, session);
            }

            return View(lista);
        }

        [HttpGet]
        public ActionResult Edit(Aviso item)
        {
            return View(item);
        }

        [HttpPost]
        public ActionResult Save(Aviso model)
        {
            try{
                var usuario = UserSession.Get(Request.HttpContext).Usuario;
                if(model.Cod_Comum == 0 || !usuario.Admin){
                    model.Cod_Comum = usuario.Cod_Comum;
                }

                if(usuario.Instrutor){
                    model.Instrutor = true;
                    model.Cod_Usuario = UserSession.Get(Request.HttpContext).Cod_Usuario();

                    char oper = model.Cod_Aviso == 0 ? 'C' : 'U';
                    model.Save();
                    Monitor.Add<Aviso>(HttpContext, oper, model.Nome);
                }
                
                return Json("ok");
            }
            catch (Exception ex){
                return Json(ex.Message);
            }   
            
        }
    
        [HttpPost]
        public ActionResult Delete(int id = 0, int Cod_Comum = 0)
        {
            try{
                if(Cod_Comum==0 || !UserSession.Get(Request.HttpContext).Admin()){
                    Cod_Comum = UserSession.Get(Request.HttpContext).Cod_Comum();
                }
                string nome = Aviso.Find(id).Nome;
                Aviso.Delete(id, Cod_Comum);
                Monitor.Add<Aviso>(HttpContext, 'D', nome);
                return Json("ok");
            }
            catch (Exception ex){
                return Json(ex.Message);
            }
        }
    }
}
