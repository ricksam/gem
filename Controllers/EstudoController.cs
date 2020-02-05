using System;
using Microsoft.AspNetCore.Mvc;
using GEM.Repository;

namespace GEM.Controllers
{
    public class EstudoController : Controller
    {
        // GET: Estudo
        public ActionResult Index()
        {
            return View();
        }
        
        public ActionResult List()
        {
            return View(Estudo.List());
        }

        [HttpGet]
        public ActionResult Edit(Estudo item)
        {
            return View(item);
        }

        [HttpPost]
        public ActionResult Save(Estudo model)
        {
            try{
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
                Estudo.Delete(id);
                return Json("ok");
            }
            catch (Exception ex){
                return Json(ex.Message);
            }
        }
    }
}
