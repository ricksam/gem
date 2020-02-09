using Dapper;
using System;
using System.Linq;
using System.Collections.Generic;

namespace GEM.Repository
{
    public class ItemGrafico : BaseEntity<ItemGrafico> 
    {
        public string Descricao{get;set;}
        public int Qtde{get;set;}

        public static List<ItemGrafico> Categorias(int Cod_Comum, Context cx = null){
            if (cx == null)
            { cx = new Context(); }

            return cx.Query<ItemGrafico>(
                @"select c.Nome as Descricao, count(u.Cod_Usuario) as Qtde from Usuario u
                inner join Instrumento i on i.Cod_Instrumento = u.Cod_Instrumento
                inner join Categoria c on c.Cod_Categoria = i.Cod_Categoria
                where u.Cod_Comum = @Cod_Comum and c.Nome <> 'Tecla'
                group by c.Nome", new{ Cod_Comum }).ToList(); 
        }

        public static List<ItemGrafico> Vozes(int Cod_Comum, Context cx = null){
            if (cx == null)
            { cx = new Context(); }

            return cx.Query<ItemGrafico>(
                @"select i.Principal as Descricao, count(u.Cod_Usuario) as Qtde from Usuario u
                inner join Instrumento i on i.Cod_Instrumento = u.Cod_Instrumento
                inner join Categoria c on c.Cod_Categoria = i.Cod_Categoria
                where u.Cod_Comum = @Cod_Comum and c.Nome <> 'Tecla'
                group by i.Principal", new{ Cod_Comum }).ToList(); 
        }

        public static List<ItemGrafico> Instrumentos(int Cod_Comum, Context cx = null){
            if (cx == null)
            { cx = new Context(); }

            return cx.Query<ItemGrafico>(
                @"select i.Nome as Descricao, count(u.Cod_Usuario) as Qtde from Usuario u
                inner join Instrumento i on i.Cod_Instrumento = u.Cod_Instrumento
                where u.Cod_Comum = @Cod_Comum 
                group by i.Nome", new{ Cod_Comum }).ToList(); 
        }
    }
}