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
            ViewBag.q = q;
            return View(UsuarioPresenca.List(Cod_Comum, Data, q));
        }

        [HttpPost]
        public ActionResult RegistraPresenca(int Cod_Usuario, DateTime Data){
            Presenca presenca = Presenca.FirstOrDefault(new{Cod_Usuario, Data});
            if(presenca == null){
                presenca = new Presenca();
                presenca.Cod_Usuario = Cod_Usuario;
                presenca.Data = Data;
            }
            presenca.Instrutor = GEM.Helpers.UserSession.Get(Request.HttpContext).Usuario.Cod_Usuario;
            presenca.Save();
            return Json("ok");
        }

        [HttpPost]
        public ActionResult RegistraAusencia(int Cod_Usuario, DateTime Data){
            Presenca presenca = Presenca.FirstOrDefault(new{Cod_Usuario, Data});
            if(presenca != null){
                Presenca.Delete(presenca.Cod_Presenca);
            }
            return Json("ok");
        }

        public ActionResult Aula(int Cod_Presenca){
            ViewBag.Cod_Presenca = Cod_Presenca;
            return View(Estudo.ListByPresenca(Cod_Presenca));
        }

        [HttpPost]
        public ActionResult AdicionaAula(Estudo estudo){
            estudo.Instrutor = GEM.Helpers.UserSession.Get(Request.HttpContext).Usuario.Cod_Usuario;
            estudo.Save();
            return Json("ok");
        }

        [HttpPost]
        public ActionResult RemoveAula(int Cod_Estudo){
            Estudo.Delete(Cod_Estudo);
            return Json("ok");
        }
    }
}
