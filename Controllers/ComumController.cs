using System;
using Microsoft.AspNetCore.Mvc;
using GEM.Models;
using GEM.Repository;
using GEM.Helpers;

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
            if(UserSession.Get(Request.HttpContext).Admin){
                return View(Comum.List());
            }
            else{
                return View(Comum.Where(new {Cod_Comum = UserSession.Get(Request.HttpContext).Usuario.Cod_Comum}));
            }
            
        }

        [HttpGet]
        public ActionResult Edit(Comum item)
        {
            return View(item);
        }

        [HttpPost]
        public ActionResult Save(Comum model, Semana dias_culto, Semana dias_rjm, Semana dias_gem)
        {
            try{
                if(model.Cod_Comum==0 || !UserSession.Get(Request.HttpContext).Admin){
                    model.Cod_Comum = UserSession.Get(Request.HttpContext).Usuario.Cod_Comum;
                }
                model.SetDiasCulto(dias_culto);
                model.SetDiasRJM(dias_rjm);
                model.SetDiasGEM(dias_gem);
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
                if(UserSession.Get(Request.HttpContext).Admin){
                    Comum.Delete(id);
                }
                
                return Json("ok");
            }
            catch (Exception ex){
                return Json(ex.Message);
            }
        }
    }
}
