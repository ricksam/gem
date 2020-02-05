using System;
using Microsoft.AspNetCore.Mvc;
using GEM.Repository;

namespace GEM.Controllers
{
    public class TipoEstudoController : Controller
    {
        // GET: TipoEstudo
        public ActionResult Index()
        {
            return View();
        }
        
        public ActionResult List()
        {
            return View(TipoEstudo.List());
        }

        [HttpGet]
        public ActionResult Edit(TipoEstudo item)
        {
            return View(item);
        }

        [HttpPost]
        public ActionResult Save(TipoEstudo model)
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
                TipoEstudo.Delete(id);
                return Json("ok");
            }
            catch (Exception ex){
                return Json(ex.Message);
            }
        }
    }
}
