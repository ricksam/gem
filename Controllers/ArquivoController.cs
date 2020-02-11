using System;
using Microsoft.AspNetCore.Mvc;
using GEM.Repository;
using GEM.Helpers;

namespace GEM.Controllers
{
    public class ArquivoController : Controller
    {
        // GET: Arquivo
        public ActionResult Index()
        {
            return View();
        }
        
        public ActionResult List(int Cod_Comum = 0)
        {
            if(Cod_Comum == 0 || !UserSession.Get(Request.HttpContext).Usuario.Admin){
                Cod_Comum = UserSession.Get(Request.HttpContext).Usuario.Cod_Comum;
            }

            return View(Arquivo.List(Cod_Comum));
        }

        [HttpGet]
        public ActionResult Edit(Arquivo item)
        {
            return View(item);
        }

        [HttpPost]
        public ActionResult Save(Arquivo model)
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
                Arquivo.Delete(id, Cod_Comum);
                return Json("ok");
            }
            catch (Exception ex){
                return Json(ex.Message);
            }
        }
    }
}
