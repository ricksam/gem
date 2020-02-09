using Microsoft.AspNetCore.Mvc;
using GEM.Repository;
using System.Linq;
using System.Collections.Generic;

namespace GEM.Controllers{
    public class GraficosController : Controller{
        public ActionResult Index(int Cod_Comum){
            
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

            List<object> instrumentos = new List<object>();
            foreach (var item in ItemGrafico.Instrumentos(Cod_Comum))
            {
                instrumentos.Add(new object[]{
                    item.Descricao, item.Qtde
                });
            }

            ViewBag.categorias = categorias;
            ViewBag.vozes = vozes;
            ViewBag.vozesCordas = vozesCordas;
            ViewBag.vozesMadeiras = vozesMadeiras;
            ViewBag.vozesMetais = vozesMetais;
            ViewBag.instrumentos = instrumentos;
            
            return View();
        }
    }
}