using System;
using Microsoft.AspNetCore.Mvc;
using GEM.Repository;

namespace GEM.Controllers
{
    public class PresencaController : Controller
    {
        // GET: Presenca
        public ActionResult Index()
        {
            return View();
        }
        
        public ActionResult List(int Cod_Comum, DateTime Data, string q)
        {
            return View(UsuarioPresenca.List(Cod_Comum, Data, q));
        }

        [HttpGet]
        public ActionResult Edit(Presenca item)
        {
            return View(item);
        }

        [HttpPost]
        public ActionResult Save(Presenca model)
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
                Presenca.Delete(id);
                return Json("ok");
            }
            catch (Exception ex){
                return Json(ex.Message);
            }
        }
    }
}
