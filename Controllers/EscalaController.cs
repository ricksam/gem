using System;
using Microsoft.AspNetCore.Mvc;
using GEM.Repository;

namespace GEM.Controllers
{
    public class EscalaController : Controller
    {
        // GET: Escala
        public ActionResult Index()
        {
            return View();
        }
        
        public ActionResult List()
        {
            return View(Escala.List());
        }

        [HttpGet]
        public ActionResult Edit(Escala item)
        {
            return View(item);
        }

        [HttpPost]
        public ActionResult Save(Escala model)
        {
            try{
                model.Save();
                return Json("ok");
            }
            catch (Exception ex){
                return Json(ex.Message);
            }   
            
        }
    
        [HttpPost]
        public ActionResult Delete(int id = 0)
        {
            try{
                Escala.Delete(id);
                return Json("ok");
            }
            catch (Exception ex){
                return Json(ex.Message);
            }
        }
    }
}
