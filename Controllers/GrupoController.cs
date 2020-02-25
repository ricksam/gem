using System;
using Microsoft.AspNetCore.Mvc;
using GEM.Repository;
using GEM.Helpers;

namespace GEM.Controllers
{
    public class GrupoController : Controller
    {
        // GET: Grupo
        public ActionResult Index()
        {
            return View();
        }
        
        public ActionResult List(int Cod_Comum = 0)
        {
            var usuario = UserSession.Get(Request.HttpContext).Usuario;
            if(Cod_Comum == 0 || !usuario.Admin){
                Cod_Comum = usuario.Cod_Comum;
            }
            return View(Grupo.List(Cod_Comum));
        }

        [HttpGet]
        public ActionResult Edit(Grupo item)
        {
            return View(item);
        }

        [HttpPost]
        public ActionResult Save(Grupo model)
        {
            try{
                var usuario = UserSession.Get(Request.HttpContext).Usuario;
                if(model.Cod_Comum == 0 || !usuario.Admin){
                    model.Cod_Comum = usuario.Cod_Comum;
                }

                if(usuario.Instrutor){
                    char oper = model.Cod_Grupo == 0 ? 'C' : 'U';
                    model.Save();
                    Monitor.Add<Grupo>(HttpContext, oper, model.Nome);
                }
                    
                return Json("ok");
            }
            catch (Exception ex){
                return Json(ex.Message);
            }   
            
        }
    
        public ActionResult Delete(int id = 0, int Cod_Comum = 0)
        {
            try{
                var usuario = UserSession.Get(Request.HttpContext).Usuario;
                if(Cod_Comum == 0 || !usuario.Admin){
                    Cod_Comum = usuario.Cod_Comum;
                }
                string nome = Grupo.Find(id, Cod_Comum).Nome;
                Grupo.Delete(id, Cod_Comum);
                Monitor.Add<Grupo>(HttpContext, 'D', nome);
                return Json("ok");
            }
            catch (Exception ex){
                return Json(ex.Message);
            }
        }
    }
}
