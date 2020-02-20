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

                if(usuario.Instrutor){
                    model.Cod_Usuario = usuario.Cod_Usuario;
                    model.Save();
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
                if(Cod_Comum==0 || !UserSession.Get(Request.HttpContext).Admin){
                    Cod_Comum = UserSession.Get(Request.HttpContext).Usuario.Cod_Comum;
                }
                Escala.Delete(id, Cod_Comum);
                return Json("ok");
            }
            catch (Exception ex){
                return Json(ex.Message);
            }
        }

        public ActionResult Visualizar(int id){
            var usuario = UserSession.Get(Request.HttpContext).Usuario;
            
            Escala escala = Escala.Find(id);
            if(!usuario.Admin && escala.Cod_Comum!=usuario.Cod_Comum){
                throw new Exception("Escala não encontrada");
            }
            return View(Gerar(escala));
        }

        public string[] GetNomes(Escala model){
            List<string> Nomes = model.GetUsuarios().ToList();
            List<string> SimpleNames = new List<string>();
            foreach (var item in Nomes)
            {
                string[] split = item.Split(" ");
                string name = "";
                
                if(split.Length > 0){
                    name += split[0];
                }

                if(split.Length > 1){
                    for (int i = 1; i < split.Length-1; i++)
                    {
                        if(split[i].Length>3){
                            name += " "+split[i];
                            break;
                        }
                    }
                }
                SimpleNames.Add(name);
            }

            return SimpleNames.ToArray();
        }

        public EscalaBuilder Gerar(Escala model){
            EscalaBuilder escala = new EscalaBuilder();

            escala.Titulo = model.Nome;
            //DateTime dtRef = model.Inicio;

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
            //escala.AddConjunto(dia, conjuntoPar[idxPar]);

            return escala;
        }

        /*public EscalaBuilder GerarOld(Escala model)
        {
            string[] Nomes = GetNomes(model);
            // Gera lista datas
            EscalaBuilder escala = new EscalaBuilder();
            escala.Titulo = model.Nome;
            DateTime dtRef = model.Inicio;
            while (dtRef <= model.Fim)
            {
                if (model.ListDayOfWeek().Contains(dtRef.DayOfWeek))
                {
                    escala.AddDay(new DiaEscala() { Data = dtRef });
                }
                dtRef = dtRef.AddDays(1);
            }

            // Gera lista/conjunto das irmas com par e a individual ( calcula o total necessario )
            List<Conjunto> conjuntoPar = new List<Conjunto>();
            List<Conjunto> conjuntoMeioPar = new List<Conjunto>();
            List<Conjunto> conjuntoImpar = new List<Conjunto>();
            List<Conjunto> conjuntoMeioImpar = new List<Conjunto>();

            if (model.Dupla && (Nomes.Length - 1) > model.ListDayOfWeek().Count * 2)
            {
                for (int i = 0; i < Nomes.Length / 2; i++)
                {
                    conjuntoPar.Add(new Conjunto() { MeiaHora = Nomes[i * 2], Culto = Nomes[i * 2 + 1] });
                }

                // se é impar
                if (Nomes.Length % 2 == 1)
                {
                    string NomeImpar = Nomes[Nomes.Length - 1];
                    List<string> NomesParReverse = new List<string>();
                    NomesParReverse.AddRange(Nomes);
                    NomesParReverse.RemoveAt(Nomes.Length - 1);
                    NomesParReverse.Reverse();

                    foreach (var item in NomesParReverse)
                    {
                        conjuntoImpar.Add(new Conjunto() { MeiaHora = NomeImpar, Culto = item });
                    }
                }
            }
            else
            {
                for (int i = 0; i < Nomes.Length; i++)
                {
                    conjuntoPar.Add(new Conjunto() { MeiaHora = Nomes[i], Culto = Nomes[i] });
                }
            }

            // Adiciona o grupo por dia da semana (se mes inicial é junho então começa pelo conjunto impar)
            int idxPar = 0;
            int idxImpar = 0;
            //string FirstName = "";
            if (model.Inicio.Month >= 6)
            {
                idxPar = conjuntoPar.Count;
            }

            escala.dayOfWeeks = model.ListDayOfWeek();


            if (model.DiaSequencial)
            {
                IOrderedEnumerable<DateTime> query = escala.ListaDatas().OrderBy(o => o.Date);

                query.ToList().ForEach(dia =>
                {
                    if (idxPar >= conjuntoPar.Count && conjuntoImpar.Count != 0)
                    {
                        escala.AddConjunto(dia, conjuntoImpar[idxImpar]);

                        idxImpar++;
                        if (idxImpar >= conjuntoImpar.Count)
                        {
                            idxImpar = 0;
                        }
                        idxPar = 0;
                    }
                    else {
                        if (idxPar >= conjuntoPar.Count)
                        {
                            idxPar = 0;
                        }

                        escala.AddConjunto(dia, conjuntoPar[idxPar]);
                        idxPar++;
                    }
                });
            }
            else
            {
                
                escala.Tentativas = 0;
                int positionPar = 0;
                int positionImpar = 0;
                
                do
                {
                    if (escala.Tentativas > 200)
                    {
                        break;
                    }

                    //bool odesc = false;

                    foreach (var item in model.ListDayOfWeek())
                    {
                        if (escala.Tentativas > 0)
                        {
                            System.Threading.Thread.Sleep(4);
                            int cngParCount = (conjuntoPar.Count - 1) / 2;
                            positionPar = cngParCount;
                            if (conjuntoImpar.Count != 0)
                            {
                                int cngImparCount = (conjuntoImpar.Count - 1) / 2;
                                positionImpar = cngImparCount;
                            }

                            conjuntoMeioPar.Clear();
                            for (int i = positionPar; i < conjuntoPar.Count; i++)
                            {
                                conjuntoMeioPar.Add(conjuntoPar[i]);
                            }
                            for (int i = 0; i < positionPar; i++)
                            {
                                conjuntoMeioPar.Add(conjuntoPar[i]);
                            }

                            conjuntoMeioImpar.Clear();
                            for (int i = positionImpar; i < conjuntoImpar.Count; i++)
                            {
                                conjuntoMeioImpar.Add(conjuntoImpar[i]);
                            }
                            for (int i = 0; i < positionImpar; i++)
                            {
                                conjuntoMeioImpar.Add(conjuntoImpar[i]);
                            }
                        }

                        IOrderedEnumerable<DateTime> query = escala.ListaDatas().Where(q => q.DayOfWeek == item).OrderBy(o => o.Date);

                        //odesc = !odesc;

                        query.ToList().ForEach(dia =>
                        {
                            if (idxPar >= conjuntoPar.Count && conjuntoImpar.Count != 0)
                            {
                                if (escala.Tentativas != 0)
                                {
                                    escala.AddConjunto(dia, conjuntoMeioImpar[idxImpar]);
                                }
                                else
                                {
                                    escala.AddConjunto(dia, conjuntoImpar[idxImpar]);
                                }

                                idxImpar++;
                                if (idxImpar >= conjuntoImpar.Count)
                                {
                                    idxImpar = 0;
                                }
                                idxPar = 0;

                            }
                            else
                            {
                                if (idxPar >= conjuntoPar.Count)
                                {
                                    idxPar = 0;
                                }

                                if (escala.Tentativas != 0)
                                {
                                    escala.AddConjunto(dia, conjuntoMeioPar[idxPar]);
                                }
                                else
                                {
                                    escala.AddConjunto(dia, conjuntoPar[idxPar]);
                                }

                                idxPar++;
                            }
                        });
                    }

                    escala.Tentativas++;

                } while (escala.DatasProximas(conjuntoPar.Count, escala.Tentativas));

                // Ordena por os conjuntos por datas invertendo as posições pares
                foreach (var itemPar in conjuntoPar)
                {
                    int idx = 0;
                    escala.ListaEscala().Where(q => q.Conjunto.MeiaHora == itemPar.MeiaHora).ToList().ForEach(f =>
                    {
                        if (idx % 2 == 1)
                        {
                            escala.Inverter(f.Data);
                        }
                        idx++;
                    });
                }

                foreach (var itemImpar in conjuntoImpar)
                {
                    int idx = 0;
                    escala.ListaEscala().Where(q => q.Conjunto.MeiaHora == itemImpar.MeiaHora).ToList().ForEach(f =>
                    {
                        if (idx % 2 == 1)
                        {
                            escala.Inverter(f.Data);
                        }
                        idx++;
                    });
                    break;
                }
            }


            return escala;
        }*/
    }
}
