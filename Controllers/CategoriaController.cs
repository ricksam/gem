using System;
using Microsoft.AspNetCore.Mvc;
using GEM.Repository;

namespace GEM.Controllers
{
    public class CategoriaController : Controller
    {
        // GET: Categoria
        public ActionResult Index()
        {
            return View();
        }
        
        public ActionResult List()
        {
            return View(Categoria.List());
        }

        [HttpGet]
        public ActionResult Edit(Categoria item)
        {
            return View(item);
        }

        [HttpPost]
        public ActionResult Save(Categoria model)
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
                Categoria.Delete(id);
                return Json("ok");
            }
            catch (Exception ex){
                return Json(ex.Message);
            }
        }
    }
}
