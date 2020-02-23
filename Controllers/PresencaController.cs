using System;
using Microsoft.AspNetCore.Mvc;
using GEM.Repository;
using GEM.Helpers;
using System.Collections.Generic;
using System.Linq;

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
                Cod_Comum = Helpers.UserSession.Get(Request.HttpContext).Cod_Comum();
            }
            
            return View(UsuarioPresenca.List(Cod_Comum, Cod_Grupo, Data));
        }

        private int[] GetCodPresenca(int[] Cod_Usuarios, DateTime Data, int Cod_Comum){
            List<int> result = new List<int>();
            Context cx = new Context();
            try{
                cx.BeginTransaction();
                //List<UsuarioComum> usuario = UsuarioComum.List();
                List<Presenca> presencas = Presenca.ListInCod_Usuario(Cod_Usuarios, Data, cx);
                List<FaltaJustificada> faltas = FaltaJustificada.ListInCod_Usuario(Cod_Usuarios, Data, cx);

                foreach (var Cod_Usuario in Cod_Usuarios)
                {
                    if(Cod_Usuario != 0){
                        UsuarioComum usuario = UsuarioComum.Find(Cod_Usuario, Cod_Comum, cx);
                        Presenca presenca = presencas.FirstOrDefault(e => e.Cod_Usuario == Cod_Usuario);
                        
                        if(presenca == null && usuario != null){
                            presenca = new Presenca();
                            presenca.Cod_Usuario = usuario.Cod_Usuario;
                            presenca.Data = Data;
                            presenca.Instrutor = UserSession.Get(Request.HttpContext).Cod_Usuario();
                            presenca.Save(cx);
                            result.Add(presenca.Cod_Presenca);
                        }

                        FaltaJustificada falta = faltas.FirstOrDefault(e => e.Cod_Usuario == Cod_Usuario);  
                        if(falta != null){
                            FaltaJustificada.Delete(falta.Cod_Justificativa, cx);
                        }
                    }
                }
                
                cx.Commit();

                return result.ToArray();
            }catch{
                cx.Rollback();
            }

            return new int[]{ };
        }

        [HttpPost]
        public ActionResult RegistraPresenca(int Cod_Usuario, string Nome, int Cod_Instrumento, bool Aluno, DateTime Data, int Cod_Comum){
            var instrutor = UserSession.Get(Request.HttpContext).Usuario;
            if(Cod_Comum==0 || !instrutor.Admin){
                Cod_Comum = instrutor.Cod_Comum;
            }

            int Cod_Presenca = 0;
            if(instrutor.Instrutor){
                Cod_Presenca = GetCodPresenca(new int[]{ Cod_Usuario }, Data, Cod_Comum)[0];                
            }
            
            return View("Situacao", new UsuarioPresenca(){
                Cod_Presenca = Cod_Presenca,
                Cod_Justificativa = 0,
                Cod_Usuario = Cod_Usuario,
                Nome = Nome,
                Instrumento = Cod_Instrumento == 0 ? "" : Instrumento.Find(Cod_Instrumento).Nome,
                Aluno = Aluno
            });
        }

        [HttpPost]
        public ActionResult RegistraAusencia(int Cod_Usuario, string Nome, int Cod_Instrumento, bool Aluno, DateTime Data, int Cod_Comum){
            var instrutor = UserSession.Get(Request.HttpContext).Usuario;
            if(Cod_Comum==0 || !instrutor.Admin){
                Cod_Comum = instrutor.Cod_Comum;
            }

            if(instrutor.Instrutor){
                Context cx = new Context();
                try
                {
                    cx.BeginTransaction();
                    UsuarioComum usuario = UsuarioComum.Find(Cod_Usuario, Cod_Comum);
                    Presenca presenca = Presenca.FirstOrDefault(new{usuario.Cod_Usuario, Data});
                    if(presenca != null){
                        Presenca.Delete(presenca.Cod_Presenca);
                    }

                    cx.Commit();
                }
                catch{
                    cx.Rollback();
                }
            }
            
            return View("Situacao", new UsuarioPresenca(){
                Cod_Presenca = 0,
                Cod_Justificativa = 0,
                Cod_Usuario = Cod_Usuario,
                Nome = Nome,
                Instrumento = Cod_Instrumento == 0 ? "" : Instrumento.Find(Cod_Instrumento).Nome,
                Aluno = Aluno
            }); 
        }

        [HttpPost]
        public ActionResult Aula(int Cod_Presenca, int Cod_Usuario, DateTime Data){
            Usuario usuario  = Usuario.Find(Cod_Usuario);
            Presenca presenca = Presenca.FirstOrDefault(new{Cod_Presenca, Cod_Usuario});
            ViewBag.Cod_Presenca = presenca.Cod_Presenca;
            ViewBag.Aluno = usuario.Nome;
            ViewBag.Instrumento = usuario.Instrumento;
            ViewBag.Cod_Usuario = Cod_Usuario;
            ViewBag.Data = Data;
            
            // Registra Presença Instrutor
            GetCodPresenca(new int[]{UserSession.Get(Request.HttpContext).Cod_Usuario()}, Data, usuario.Cod_Comum);

            return View(Estudo.ListByPresenca(presenca.Cod_Presenca));
        }

        [HttpPost]
        public ActionResult AdicionaAula(Estudo estudo, int Cod_Usuario){
            Presenca presenca = Presenca.FirstOrDefault(new{estudo.Cod_Presenca, Cod_Usuario});
            estudo.Instrutor = UserSession.Get(Request.HttpContext).Cod_Usuario();
            if(estudo.Cod_Tipo != 0){
                estudo.Save();
                return Json("ok");
            }
            else{
                return Json("informe o tipo");
            }
            
        }

        [HttpPost]
        public ActionResult RemoveAula(int Cod_Estudo, int Cod_Presenca, int Cod_Usuario){
            Presenca presenca = Presenca.FirstOrDefault(new{ Cod_Presenca, Cod_Usuario });
            Estudo.Delete(Cod_Estudo, presenca.Cod_Presenca);
            return Json("ok");
        }

        [HttpPost]
        public ActionResult AulaGrupo(int Cod_Comum, int Cod_Grupo, string Grupo, DateTime Data){
            ViewBag.Cod_Comum = Cod_Comum;
            ViewBag.Cod_Grupo = Cod_Grupo;
            ViewBag.Grupo = Grupo;
            ViewBag.Data = Data;
            ViewBag.AlunosCount = UsuarioPresenca.Count(Cod_Comum, Cod_Grupo, Data, "Presente", "Alunos");

            // Registra Presença Instrutor
            GetCodPresenca(new int[]{UserSession.Get(Request.HttpContext).Cod_Usuario()}, Data, Cod_Comum);

            return View("AulaGrupo", new List<GEM.Repository.Estudo>());
        }

        [HttpPost]
        public ActionResult PresencaGrupo(int Cod_Comum, int Cod_Grupo, string Grupo, DateTime Data){
            ViewBag.Cod_Comum = Cod_Comum;
            ViewBag.Cod_Grupo = Cod_Grupo;
            ViewBag.Grupo = Grupo;
            ViewBag.Data = Data;
            return View("PresencaGrupo", UsuarioPresenca.List(Cod_Comum, Cod_Grupo, Data, "Ausente", "Alunos"));
        }

        /*public ActionResult ListaAulaGrupo(){
            return View("ListaAulaGrupo", new List<GEM.Repository.Estudo>());
        }*/

        [HttpPost]
        public ActionResult AdicionaAulaGrupo(List<Estudo> lista, Estudo estudo){
            if(lista == null){
                lista = new List<Estudo>();
            }

            var instrutor = UserSession.Get(Request.HttpContext).Usuario;
            estudo.Instrutor = instrutor.Cod_Usuario;
            estudo.Nome_Instrutor = instrutor.Nome;

            TipoEstudo tipo = GEM.Repository.TipoEstudo.Find(estudo.Cod_Tipo);
            estudo.Tipo = tipo.Nome;
            estudo.Controle = tipo.Controle;

            lista.Add(estudo);
            return View("ListaAulaGrupo", lista);
        }

        [HttpPost]
        public ActionResult RemoveAulaGrupo(string id, List<Estudo> lista){
            if(lista == null){
                lista = new List<Estudo>();
            }

            for (int i = 0; i < lista.Count; i++)
            {
                if(lista[i].Id == id){
                    lista.RemoveAt(i);
                    break;
                }
            }

            return View("ListaAulaGrupo", lista);
        }

        [HttpPost]
        public ActionResult GravarAulaGrupo(int Cod_Comum, int Cod_Grupo, DateTime Data, List<Estudo> lista){
            
            foreach (var estudo in lista)
            {
                List<UsuarioPresenca> usuarios = UsuarioPresenca.List(Cod_Comum, Cod_Grupo, Data, "Presente", "Alunos");

                foreach (var usuario in usuarios)
                {
                    estudo.Cod_Estudo = 0;
                    estudo.Cod_Presenca = usuario.Cod_Presenca;
                    estudo.Instrutor = UserSession.Get(Request.HttpContext).Cod_Usuario();
                    estudo.Save();    
                }
            }
            return Json("ok");
        }

        [HttpPost]
        public ActionResult GravarPresencaGrupo(int Cod_Comum, int Cod_Grupo, DateTime Data, List<int> Cod_Usuarios){
            var instrutor = UserSession.Get(Request.HttpContext).Usuario;

            Cod_Usuarios.Add(instrutor.Cod_Usuario);
            GetCodPresenca(Cod_Usuarios.ToArray(), Data, Cod_Comum);

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
            if(Cod_Comum==0 || !UserSession.Get(Request.HttpContext).Admin()){
                Cod_Comum = UserSession.Get(Request.HttpContext).Cod_Comum();
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

                if(falta.Cod_Comum==0 || !UserSession.Get(Request.HttpContext).Admin()){
                    falta.Cod_Comum = UserSession.Get(Request.HttpContext).Cod_Comum();
                }

                if(UserSession.Get(Request.HttpContext).Instrutor()){
                    Usuario usuario = Usuario.FirstOrDefault(new{falta.Cod_Usuario, falta.Cod_Comum});
                    if(usuario!=null){
                        falta.Instrutor = UserSession.Get(Request.HttpContext).Cod_Usuario();
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
