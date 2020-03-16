using Dapper;
using System;
using System.Linq;
using System.Collections.Generic;

namespace GEM.Repository
{
    public class UsuarioPresenca : Usuario 
    {
        public int Cod_Presenca { get; set; }
        public int Cod_Justificativa { get; set; }
        //public DateTime Data { get; set; }
        //public string Instrutor { get; set; }

        private static string PrepareQuery(string FieldsReturn, int Cod_Grupo, string FiltroPresenca = "", string FiltroUsuario = ""){

            string filtro_grupo = (Cod_Grupo != 0 ? string.Format("and u.Cod_Usuario in (select Cod_Usuario from UsuarioGrupo where Cod_Grupo = {0})", Cod_Grupo) : "");
            //string filtro_grupo = (Cod_Grupo != 0 ? "and u.Cod_Grupo = " + Cod_Grupo : "");

            string filtro_presente = FiltroPresenca == "Presente" ? "and p.Cod_Presenca is not null" : "";
            string filtro_ausente = FiltroPresenca == "Ausente" ? "and p.Cod_Presenca is null" : "";

            string filtro_instrutores = (FiltroUsuario == "Instrutores" ? "and u.Instrutor = 1" : "");
            string filtro_alunos = (FiltroUsuario == "Alunos" ? "and u.Aluno = 1" : "");

            return string.Format(@"select
                        {0}
                    from Usuario u
                    left outer join Presenca p on p.Cod_Usuario = u.Cod_Usuario and p.Data = @Data
                    left outer join FaltaJustificada j on j.Cod_Usuario = u.Cod_Usuario and j.Data = @Data 
                    left outer join Instrumento i on i.Cod_Instrumento = u.Cod_Instrumento 
                    left outer join Grupo g on g.Cod_Grupo = u.Cod_Grupo
                        where 
                        u.Ativo = 1 and u.Cod_Comum = @Cod_Comum 
                        and (u.Instrutor = 1 or u.Aluno = 1)
                        {1} {2} {3} {4} {5}",
                        FieldsReturn, 
                        filtro_presente, 
                        filtro_ausente,
                        filtro_instrutores,
                        filtro_alunos,
                        filtro_grupo);
        }

        public static int Count(int Cod_Comum, int Cod_Grupo, DateTime Data, string FiltroPresenca = "", string FiltroUsuario = "", Context cx = null){
            if (cx == null)
            { cx = new Context(); }

            if(Cod_Comum==0||Data==null||Data==DateTime.MinValue){
                return 0;
            }

            string query = PrepareQuery(@"count(u.Cod_Usuario)", Cod_Grupo, FiltroPresenca, FiltroUsuario);

            return cx.Query<int?>(query, new {  Cod_Comum, Data = Data.ToString("yyyy-MM-dd") }).SingleOrDefault() ?? 0;
        }

        public static List<UsuarioPresenca> List(int Cod_Comum, int Cod_Grupo, DateTime Data, string FiltroPresenca = "", string FiltroUsuario = "", Context cx = null)
        {
            if (cx == null)
            { cx = new Context(); }

            if(Cod_Comum==0||Data==null||Data==DateTime.MinValue){
                return new List<UsuarioPresenca>();
            }

            string query = PrepareQuery(
                    @" u.Cod_Usuario
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
                       ,p.Cod_Presenca
                       ,j.Cod_Justificativa
                       ,i.Nome as Instrumento
                       ,g.Nome as Grupo", Cod_Grupo, FiltroPresenca, FiltroUsuario);

            var list = cx.Query<UsuarioPresenca>(query, new {  Cod_Comum, Data = Data.ToString("yyyy-MM-dd") }).ToList();

            List<UsuarioGrupo> grupos = UsuarioGrupo.ListByUusarios(list.Select(e => e.Cod_Usuario).ToArray(), cx);

            foreach (var item in list)
            {
                item.Cod_Grupos = grupos.Where(e => e.Cod_Usuario == item.Cod_Usuario).Select(e => e.Cod_Grupo).ToArray();
                item.Grupos = string.Join(", ", Grupo.ListIn(item.Cod_Grupos, Cod_Comum).Select(e => e.Nome).ToArray());
            }

            return list;
        }
    }
}