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
        
        public ActionResult List(int Cod_Comum, DateTime Data)
        {
            return View(UsuarioPresenca.List(Cod_Comum, Data));
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

            FaltaJustificada falta = FaltaJustificada.FirstOrDefault(new{Cod_Usuario, Data});
            if(falta!=null){
                FaltaJustificada.Delete(falta.Cod_Justificativa);
            }

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

        [HttpPost]
        public ActionResult Aula(int Cod_Presenca, string Aluno, string Instrumento){
            ViewBag.Cod_Presenca = Cod_Presenca;
            ViewBag.Aluno = Aluno;
            ViewBag.Instrumento = Instrumento;
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

        [HttpPost]
        public ActionResult Controle(int Cod_Tipo){
            TipoEstudo tipo = GEM.Repository.TipoEstudo.Find(Cod_Tipo);
            if(tipo!=null){
                return Json(tipo.Controle);
            }else{
                return Json("Número");
            }
        }

        

        [HttpPost]
        public ActionResult Historico(int Cod_Usuario, string Nome, string Instrumento, bool Aluno){
            ViewBag.Cod_Usuario = Cod_Usuario;
            ViewBag.Nome = Nome;
            ViewBag.Instrumento = Instrumento;
            ViewBag.Aluno = Aluno;
            if(Aluno){
                return View(Estudo.ListHistoricoAluno(Cod_Usuario));
            }else{
                return View(Estudo.ListHistoricoInstrutor(Cod_Usuario));
            }
        }

        [HttpPost]
        public ActionResult Justificativa(DateTime Data, int Cod_Usuario, string Nome, string Instrumento){
            //ViewBag.Cod_Usuario = Cod_Usuario;
            ViewBag.Nome = Nome;
            ViewBag.Instrumento = Instrumento;
            FaltaJustificada falta = FaltaJustificada.FirstOrDefault(new {Cod_Usuario, Data=Data.ToString("yyyy-MM-dd")});
            if(falta==null){
                falta = new FaltaJustificada();
                falta.Data =Data;
                falta.Cod_Usuario = Cod_Usuario;
            }
            return View(falta);
        }

        [HttpPost]
        public ActionResult Justificar(FaltaJustificada falta){
            try{
                falta.Instrutor = GEM.Helpers.UserSession.Get(Request.HttpContext).Usuario.Cod_Usuario;
                falta.Save();
                return Json("ok");
            }
            catch(Exception ex){
                return Json(ex.Message);
            }
            
        }
    }
}
