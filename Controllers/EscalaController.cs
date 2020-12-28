using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using GEM.Repository;
using GEM.Helpers;
using GEM.Models;

namespace GEM.Controllers
{
    public class EscalaController : Controller
    {
        // GET: Escala
        public ActionResult Index()
        {
            return View();
        }

        [AllowAnonymous]
        public ActionResult Teste()
        {
            Escala escala = new Escala();
            
            escala.Cod_Escala = 0;
            escala.Cod_Usuario = 0;
            escala.Cod_Comum = 0;

            escala.Nome = "Escala de Organistas";
            escala.Usuarios = JSON.Serialize(new string[] { "Ana1", "Ana2", "Hilary", "Etyene", "Jaqueline", "Elaine", "Teste"});
            escala.Inicio = Convert.ToDateTime("01/12/2020");
            escala.Fim = Convert.ToDateTime("31/12/2021"); ;
            escala.Dias = JSON.Serialize(new Semana() { Dom=true});
            escala.Dupla = true;
            escala.DiaSequencial = true;
            return View("Visualizar", Gerar(escala));
        }

        public ActionResult List(int Cod_Comum = 0)
        {
            var usuario = UserSession.Get(Request.HttpContext).Usuario;
            if(Cod_Comum == 0 || !usuario.Admin){
                Cod_Comum = usuario.Cod_Comum;
            }
            return View(Escala.List(Cod_Comum));
        }

        [HttpGet]
        public ActionResult Edit(Escala item)
        {
            if(item.Inicio==DateTime.MinValue){
                item.Inicio = Util.BrazilianDatetimeNow();
            }

            if(item.Fim==DateTime.MinValue){
                item.Fim  = Util.BrazilianDatetimeNow();
            }

            if(item.Cod_Escala==0){
                item.DiaSequencial = true;
            }

            return View(item);
        }

        [HttpPost]
        public ActionResult Dias(int Cod_Comum, string Tipo){
            var usuario = UserSession.Get(Request.HttpContext).Usuario;
            if(Cod_Comum == 0 || !usuario.Admin){
                Cod_Comum = usuario.Cod_Comum;
            }

            Comum comum =  Comum.Find(Cod_Comum);
            if(Tipo=="Organistas_Oficializadas")
            {
                return View(comum.GetDiasCulto());
            }
            else
            {
                return View(comum.GetDiasRJM());
            }
        }

        [HttpPost]
        public ActionResult Usuarios(int Cod_Comum, string Tipo){
            var usuario = UserSession.Get(Request.HttpContext).Usuario;
            if(Cod_Comum == 0 || !usuario.Admin){
                Cod_Comum = usuario.Cod_Comum;
            }

            List<Categoria> categorias = Categoria.List();
                        
            Categoria cordas = categorias.FirstOrDefault(e=>e.Nome == "Cordas");
            Categoria madeiras = categorias.FirstOrDefault(e=>e.Nome == "Madeiras");
            Categoria metais = categorias.FirstOrDefault(e=>e.Nome == "Metais");
            Categoria tecla = categorias.FirstOrDefault(e=>e.Nome == "Tecla");

            List<Usuario> usuarios = new List<Usuario>(); 

            if(Tipo=="Organistas_Oficializadas")
            {
                usuarios = Usuario.ListByComum(Cod_Comum, 0, "Oficializados", "Ativo", new int[] { tecla.Cod_Categoria });
            }
            

            if(Tipo=="Organistas_RJM")
            {
                usuarios = Usuario.ListByComum(Cod_Comum, 0, "RJM", "Ativo", new int[] { tecla.Cod_Categoria });
            }
            if(Tipo=="Instrutores")
            {
                usuarios = Usuario.ListByComum(Cod_Comum, 0, "Instrutores", "Ativo", new int[] { cordas.Cod_Categoria, madeiras.Cod_Categoria, metais.Cod_Categoria});
            }
            
            return View(usuarios);
        }

        [HttpPost]
        public ActionResult Save(Escala model, Semana DiasSemana, string[] UsersSelected)
        {
            try{
                if(model.Cod_Escala == 0 && (UsersSelected==null || UsersSelected.Length==0) ){
                    throw new Exception("Nenhum usuário selecionado!");
                }

                if(DiasSemana != null){
                    model.SetDiasSemana(DiasSemana);
                }

                if(UsersSelected != null && UsersSelected.Length != 0){
                    model.SetUsuarios(UsersSelected);
                }
                
                var usuario = UserSession.Get(Request.HttpContext).Usuario;
                if(model.Cod_Comum == 0 || !usuario.Admin){
                    model.Cod_Comum = usuario.Cod_Comum;
                }

                if(UserSession.Get(Request.HttpContext).Instrutor()){
                    model.Cod_Usuario = usuario.Cod_Usuario;

                    char oper = model.Cod_Escala == 0 ? 'C' : 'U';
                    model.Save();
                    Monitor.Add<Escala>(HttpContext, oper, model.Nome);
                }
                
                return Json("ok");
            }
            catch (Exception ex){
                return Json(ex.Message);
            }   
            
        }
    
        [HttpPost]
        public ActionResult Delete(int id = 0, int Cod_Comum = 0)
        {
            try{
                if(Cod_Comum==0 || !UserSession.Get(Request.HttpContext).Admin()){
                    Cod_Comum = UserSession.Get(Request.HttpContext).Cod_Comum();
                }
                string nome = Escala.Find(id).Nome;
                Escala.Delete(id, Cod_Comum);
                Monitor.Add<Escala>(HttpContext, 'D', nome);
                return Json("ok");
            }
            catch (Exception ex){
                return Json(ex.Message);
            }
        }

        public ActionResult Visualizar(int id){
            if(UserSession.Get(Request.HttpContext).UserLogged()){
                
                Escala escala = Escala.Find(id);
                if(!UserSession.Get(Request.HttpContext).Admin() && escala.Cod_Comum!=UserSession.Get(Request.HttpContext).Cod_Comum()){
                    ViewBag.error = "Escala não encontrada";
                }
                return View(Gerar(escala));
            }
            
            return View(new EscalaBuilder());
        }

        public string[] GetNomes(Escala model){
            List<string> Nomes = model.GetUsuarios().ToList();
            List<string> SimpleNames = new List<string>();
            foreach (var item in Nomes)
            {
                SimpleNames.Add(Util.ShortName(item));
            }

            return SimpleNames.ToArray();
        }

        public EscalaBuilder Gerar(Escala model){
            EscalaBuilder escala = new EscalaBuilder();

            escala.Titulo = model.Nome;

            escala.Nomes = GetNomes(model);
            escala.StartDate = model.Inicio;
            escala.EndDate = model.Fim;
            escala.dayOfWeeks = model.ListDayOfWeek();
            escala.Dupla = model.Dupla;
            escala.Initialize();

            DateTime first = escala.GetFirstDate();
            escala.AddConjunto(first);
            
            if(model.DiaSequencial){
                DateTime dia = first;
                while(dia <= escala.EndDate){
                    dia = escala.GetNextDate(dia);
                    escala.AddConjunto(dia);
                }
            }else{
                List<DayOfWeek> weeks = escala.GetLoopOrder(first);
                foreach (var week in weeks)
                {
                    DateTime dia = first;
                    while(dia <= escala.EndDate){
                        dia = escala.GetNextDateByWeek(dia, week);
                        escala.AddConjunto(dia);
                    }
                } 
            }

            return escala;
        }
    }
}
