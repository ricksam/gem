using System;
using Microsoft.AspNetCore.Mvc;
using GEM.Repository;
using GEM.Helpers;

namespace GEM.Controllers
{
    public class InstrumentoController : Controller
    {
        // GET: Instrumento
        public ActionResult Index()
        {
            return View();
        }
        
        public ActionResult List()
        {
            return View(Instrumento.List());
        }

        [HttpGet]
        public ActionResult Edit(Instrumento item)
        {
            return View(item);
        }

        [HttpPost]
        public ActionResult Save(Instrumento model)
        {
            try{
                if(!UserSession.Get(Request.HttpContext).Admin()){
                    throw new Exception("Função liberada apenas para Admin");
                }
                model.Save();
                return Json("ok");
            }
            catch (Exception ex){
                return Json(ex.Message);
            }   
            
        }
    
        public ActionResult Delete(int id = 0)
        {
            try{
                if(!UserSession.Get(Request.HttpContext).Admin()){
                    throw new Exception("Função liberada apenas para Admin");
                }
                Instrumento.Delete(id);
                return Json("ok");
            }
            catch (Exception ex){
                return Json(ex.Message);
            }
        }
    }
}
