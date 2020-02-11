using System;
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
            if(Cod_Comum == 0 || !UserSession.Get(Request.HttpContext).Usuario.Admin){
                Cod_Comum = UserSession.Get(Request.HttpContext).Usuario.Cod_Comum;
            }

            return View(Aviso.List(Cod_Comum));
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
                if(model.Cod_Comum == 0 || !UserSession.Get(Request.HttpContext).Usuario.Admin){
                    model.Cod_Comum = UserSession.Get(Request.HttpContext).Usuario.Cod_Comum;
                }
                model.Cod_Usuario = UserSession.Get(Request.HttpContext).Usuario.Cod_Usuario;
                model.Save();
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
                if(Cod_Comum==0 || !UserSession.Get(Request.HttpContext).Admin){
                    Cod_Comum = UserSession.Get(Request.HttpContext).Usuario.Cod_Comum;
                }
                Aviso.Delete(id, Cod_Comum);
                return Json("ok");
            }
            catch (Exception ex){
                return Json(ex.Message);
            }
        }
    }
}
