using System;
using Microsoft.AspNetCore.Mvc;
using GEM.Repository;

namespace GEM.Controllers
{
    public class ComumController : Controller
    {
        // GET: Comum
        public ActionResult Index()
        {
            return View();
        }
        
        public ActionResult List()
        {
            return View(Comum.List());
        }

        [HttpGet]
        public ActionResult Edit(Comum item)
        {
            return View(item);
        }

        [HttpPost]
        public ActionResult Save(Comum model)
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
                Comum.Delete(id);
                return Json("ok");
            }
            catch (Exception ex){
                return Json(ex.Message);
            }
        }
    }
}
