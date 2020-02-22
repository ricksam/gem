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
                    model.Save();
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
                Grupo.Delete(id, Cod_Comum);
                return Json("ok");
            }
            catch (Exception ex){
                return Json(ex.Message);
            }
        }
    }
}
