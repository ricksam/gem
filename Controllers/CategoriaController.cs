using System;
using Microsoft.AspNetCore.Mvc;
using GEM.Repository;
using GEM.Helpers;

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
                if(!UserSession.Get(Request.HttpContext).Admin){
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
                if(!UserSession.Get(Request.HttpContext).Admin){
                    throw new Exception("Função liberada apenas para Admin");
                }
                Categoria.Delete(id);
                return Json("ok");
            }
            catch (Exception ex){
                return Json(ex.Message);
            }
        }
    }
}
