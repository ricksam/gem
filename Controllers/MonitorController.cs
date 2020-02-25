using System;
using Microsoft.AspNetCore.Mvc;
using GEM.Repository;
using GEM.Helpers;

namespace GEM.Controllers
{
    public class MonitorController : Controller
    {
        // GET: Monitor
        public ActionResult Index()
        {
            return View();
        }
        
        public ActionResult List(int Cod_Comum = 0)
        {
            var usuario = UserSession.Get(Request.HttpContext).Usuario;
            if(Cod_Comum == 0 || !usuario.Admin){
                Cod_Comum = usuario.Cod_Comum;
            }

            ViewBag.tabelas = Monitor.ListTabelas(Cod_Comum);
            return View(Monitor.List(Cod_Comum));
        }
    }
}
