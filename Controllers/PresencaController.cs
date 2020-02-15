using System;
using Microsoft.AspNetCore.Mvc;
using GEM.Repository;
using GEM.Helpers;

namespace GEM.Controllers
{
    public class PresencaController : Controller
    {
        // GET: Presenca
        public ActionResult Index()
        {
            return View();
        }
        
        public ActionResult List(int Cod_Comum, int Cod_Grupo, DateTime Data)
        {
            if(!Helpers.UserSession.Get(Request.HttpContext).Usuario.Admin){
                Cod_Comum = Helpers.UserSession.Get(Request.HttpContext).Usuario.Cod_Comum;
            }
            
            return View(UsuarioPresenca.List(Cod_Comum, Cod_Grupo, Data));
        }

        [HttpPost]
        public ActionResult RegistraPresenca(int Cod_Usuario, DateTime Data, int Cod_Comum){
            var instrutor = UserSession.Get(Request.HttpContext).Usuario;
            if(Cod_Comum==0 || !instrutor.Admin){
                Cod_Comum = instrutor.Cod_Comum;
            }

            if(instrutor.Instrutor){
                Usuario usuario = Usuario.FirstOrDefault(new{Cod_Usuario, Cod_Comum});
                Presenca presenca = Presenca.FirstOrDefault(new{usuario.Cod_Usuario, Data});
                if(presenca == null){
                    presenca = new Presenca();
                    presenca.Cod_Usuario = usuario.Cod_Usuario;
                    presenca.Data = Data;
                }
                presenca.Instrutor = UserSession.Get(Request.HttpContext).Usuario.Cod_Usuario;
                presenca.Save();

                FaltaJustificada falta = FaltaJustificada.FirstOrDefault(new{Cod_Usuario, Data});
                if(falta!=null){
                    FaltaJustificada.Delete(falta.Cod_Justificativa);
                }
            }
            
            return Json("ok");
        }

        [HttpPost]
        public ActionResult RegistraAusencia(int Cod_Usuario, DateTime Data, int Cod_Comum){
            var instrutor = UserSession.Get(Request.HttpContext).Usuario;
            if(Cod_Comum==0 || !instrutor.Admin){
                Cod_Comum = instrutor.Cod_Comum;
            }

            if(instrutor.Instrutor){
                Usuario usuario = Usuario.FirstOrDefault(new{Cod_Usuario, Cod_Comum});
                Presenca presenca = Presenca.FirstOrDefault(new{usuario.Cod_Usuario, Data});
                if(presenca != null){
                    Presenca.Delete(presenca.Cod_Presenca);
                }
            }
            
            return Json("ok");
        }

        [HttpPost]
        public ActionResult Aula(int Cod_Presenca, int Cod_Usuario){
            Usuario usuario  = Usuario.Find(Cod_Usuario);
            Presenca presenca = Presenca.FirstOrDefault(new{Cod_Presenca, Cod_Usuario});
            ViewBag.Cod_Presenca = presenca.Cod_Presenca;
            ViewBag.Aluno = usuario.Nome;
            ViewBag.Instrumento = usuario.Instrumento;
            ViewBag.Cod_Usuario = Cod_Usuario;
            return View(Estudo.ListByPresenca(presenca.Cod_Presenca));
        }

        [HttpPost]
        public ActionResult AdicionaAula(Estudo estudo, int Cod_Usuario){
            Presenca presenca = Presenca.FirstOrDefault(new{estudo.Cod_Presenca, Cod_Usuario});
            estudo.Instrutor = UserSession.Get(Request.HttpContext).Usuario.Cod_Usuario;
            estudo.Save();
            return Json("ok");
        }

        [HttpPost]
        public ActionResult RemoveAula(int Cod_Estudo, int Cod_Presenca, int Cod_Usuario){
            Presenca presenca = Presenca.FirstOrDefault(new{ Cod_Presenca, Cod_Usuario });
            Estudo.Delete(Cod_Estudo, presenca.Cod_Presenca);
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
        public ActionResult Historico(int Cod_Usuario, string Nome, string Instrumento, bool Aluno, int Cod_Comum){
            if(Cod_Comum==0 || !UserSession.Get(Request.HttpContext).Admin){
                Cod_Comum = UserSession.Get(Request.HttpContext).Usuario.Cod_Comum;
            }
            Usuario usuario = Usuario.FirstOrDefault(new{ Cod_Usuario, Cod_Comum });
            ViewBag.Cod_Usuario = usuario.Cod_Usuario;
            ViewBag.Nome = usuario.Nome;
            ViewBag.Instrumento = Instrumento;
            ViewBag.Aluno = Aluno;
            if(Aluno){
                return View(Estudo.ListHistoricoAluno(usuario.Cod_Usuario));
            }else{
                return View(Estudo.ListHistoricoInstrutor(usuario.Cod_Usuario));
            }
        }

        [HttpPost]
        public ActionResult Justificativa(DateTime Data, int Cod_Usuario, string Nome, string Instrumento, int Cod_Comum){
            //ViewBag.Cod_Usuario = Cod_Usuario;
            ViewBag.Nome = Nome;
            ViewBag.Instrumento = Instrumento;
            ViewBag.Cod_Comum = Cod_Comum;
            Usuario usuario = Usuario.FirstOrDefault(new{Cod_Usuario, Cod_Comum});
            FaltaJustificada falta = FaltaJustificada.FirstOrDefault(new {usuario.Cod_Usuario, Data=Data.ToString("yyyy-MM-dd")});
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
                var instrutor = UserSession.Get(Request.HttpContext).Usuario;
                if(falta.Cod_Comum==0 || !instrutor.Admin){
                    falta.Cod_Comum = instrutor.Cod_Comum;
                }

                if(instrutor.Instrutor){
                    Usuario usuario = Usuario.FirstOrDefault(new{falta.Cod_Usuario, falta.Cod_Comum});
                    if(usuario!=null){
                        falta.Instrutor = UserSession.Get(Request.HttpContext).Usuario.Cod_Usuario;
                        falta.Save();
                    }
                }
                
                return Json("ok");
            }
            catch(Exception ex){
                return Json(ex.Message);
            }
            
        }
    }
}
