using Dapper;
using System;
using System.Linq;
using System.Collections.Generic;

namespace GEM.Repository
{
    public class UsuarioPresenca : Usuario 
    {
        public DateTime Data { get; set; }
        //public string Instrutor { get; set; }

        public static List<UsuarioPresenca> List(int Cod_Comum, DateTime Data, string filtro, Context cx = null)
        {
            if(Cod_Comum==0||Data==null||Data==DateTime.MinValue){
                return new List<UsuarioPresenca>();
            }

            if (cx == null)
            { cx = new Context(); }

            string filtro_presente = "";
            string filtro_ausente = "";

            return cx.Query<UsuarioPresenca>(
                string.Format(@"select
                        u.Cod_Usuario
                       ,u.Nome 
                       ,u.Email 
                       ,u.Telefone 
                       ,u.Endereco 
                       ,u.Aluno 
                       ,u.Instrutor 
                       ,u.Oficializado 
                       ,u.Admin
                       ,u.Cod_Instrumento 
                       ,u.Cod_Comum 
                       ,u.Observacao 
                       ,i.Nome as Instrumento
                    from Usuario u
                    left outer join Instrumento i on i.Cod_Instrumento = u.Cod_Instrumento 
                        where Cod_Comum = @Cod_Comum {0} {1} {2}", filtro_presente, filtro_ausente)
                    , new {  Cod_Comum }).ToList();
        }
    }
}