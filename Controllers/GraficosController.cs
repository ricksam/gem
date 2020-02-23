using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Collections.Generic;
using GEM.Repository;
using GEM.Helpers;
using GEM.Models;

namespace GEM.Controllers{
    public class GraficosController : Controller{
        
        public ActionResult Index(int Cod_Comum){
            
            Dash dash = MemoryContext.GetCache<Dash>(Cod_Comum);

            if(UserSession.Get(Request.HttpContext).Dev() && Request.Host.Host == "localhost"){
                return View(dash);
            }

            if(dash == null || dash.Cod_Comum == 0){
                
                if(Cod_Comum==0 || !UserSession.Get(Request.HttpContext).Admin()){
                    Cod_Comum = UserSession.Get(Request.HttpContext).Cod_Comum();
                }

                List<object> categorias = new List<object>();
                foreach (var item in ItemGrafico.Categorias(Cod_Comum))
                {
                    categorias.Add(new object[]{
                        item.Descricao, item.Qtde
                    });
                }

                List<object> vozes = new List<object>();
                foreach (var item in ItemGrafico.Vozes(Cod_Comum))
                {
                    vozes.Add(new object[]{
                        item.Descricao, item.Qtde
                    });
                }

                List<Categoria> ListaCategorias = Categoria.List();
                Categoria Cordas = ListaCategorias.FirstOrDefault(e => { return e.Nome == "Cordas"; });
                Categoria Madeiras = ListaCategorias.FirstOrDefault(e => { return e.Nome == "Madeiras";});
                Categoria Metais = ListaCategorias.FirstOrDefault(e=>{ return e.Nome == "Metais";});

                List<object> vozesCordas = new List<object>();
                if(Cordas != null){
                    foreach (var item in ItemGrafico.VozesCategoria(Cod_Comum, Cordas.Cod_Categoria))
                    {
                        vozesCordas.Add(new object[]{
                            item.Descricao, item.Qtde
                        });
                    }
                }

                List<object> vozesMadeiras = new List<object>();
                if(Madeiras != null){
                    foreach (var item in ItemGrafico.VozesCategoria(Cod_Comum, Madeiras.Cod_Categoria))
                    {
                        vozesMadeiras.Add(new object[]{
                            item.Descricao, item.Qtde
                        });
                    }
                }
                
                List<object> vozesMetais = new List<object>();
                if(Metais != null){
                    foreach (var item in ItemGrafico.VozesCategoria(Cod_Comum, Metais.Cod_Categoria))
                    {
                        vozesMetais.Add(new object[]{
                            item.Descricao, item.Qtde
                        });
                    }
                }

                string[] colors = new string[] { "#63bf60", "#bf6060", "#6076bf", "#bf60b3" };
                List<object> instrumentos = new List<object>();
                instrumentos.Add(new object[]{
                        "Element", "Qtde", new { role = "style" }
                    });
                foreach (var item in ItemGrafico.Instrumentos(Cod_Comum))
                {

                    instrumentos.Add(new object[]{
                        item.Descricao, item.Qtde, colors[item.Cod_Categoria - 1]
                    });
                }

                dash = new Dash();
                dash.Cod_Comum = Cod_Comum;
                dash.Categorias = categorias;
                dash.Vozes = vozes;
                dash.VozesCordas = vozesCordas;
                dash.VozesMadeiras = vozesMadeiras;
                dash.VozesMetais = vozesMetais;
                dash.Instrumentos = instrumentos;
                dash.Totais = Usuario.Totais(Cod_Comum);    
                MemoryContext.SetCache<Dash>(dash, Cod_Comum);
            }
            
            
            return View(dash);
        }
    }
}