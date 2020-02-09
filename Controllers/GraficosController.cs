using Microsoft.AspNetCore.Mvc;
using GEM.Repository;
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

            List<object> instrumentos = new List<object>();
            foreach (var item in ItemGrafico.Instrumentos(Cod_Comum))
            {
                instrumentos.Add(new object[]{
                    item.Descricao, item.Qtde
                });
            }

            ViewBag.categorias = categorias;
            ViewBag.vozes = vozes;
            ViewBag.instrumentos = instrumentos;
            /*ViewBag.categorias = new object[]{
                new object[]{
                    "Cordas", 50
                },
                new object[]{
                    "Madeiras", 50
                },
                new object[]{
                    "Metais", 50
                }
            };

            ViewBag.vozes = new object[]{
                new object[]{
                    "Soprano", 50
                },
                new object[]{
                    "Contralto", 50
                },
                new object[]{
                    "Tenor", 50
                },
                new object[]{
                    "Baixo", 50
                }
            };

            
            [
          ['Soprano', 50],
          ['Contralto', 25],
          ['Tenor', 25],
		  ['Baixo', 45]
        ]
            */
            return View();
        }
    }
}