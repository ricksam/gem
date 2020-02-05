using System;
using Microsoft.AspNetCore.Mvc;
using GEM.Repository;

namespace GEM.Controllers
{
    public class UsuarioController : Controller
    {
        // GET: Usuario
        public ActionResult Index(string q)
        {
            ViewBag.q = q;
            return View();
        }
        
        public ActionResult List(string q = "", int Cod_Comum = 0)
        {
            ViewBag.q = q; 
            ViewBag.Cod_Comum = Cod_Comum;
            return View(Usuario.ListByComum(Cod_Comum, q));
        }

        [HttpGet]
        public ActionResult Edit(Usuario item)
        {
            return View(item);
        }

        [HttpPost]
        public ActionResult Save(Usuario model)
        {
            try{
                if(model.Cod_Comum==0){
                    model.Cod_Comum = GEM.Helpers.UserSession.Get(Request.HttpContext).Usuario.Cod_Comum;
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
                Usuario.Delete(id);
                return Json("ok");
            }
            catch (Exception ex){
                return Json(ex.Message);
            }
        }
    }
}
