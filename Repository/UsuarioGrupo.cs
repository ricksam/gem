using Dapper;
using System;
using System.Linq;
using System.Collections.Generic;

namespace GEM.Repository
{
    public class UsuarioGrupo : BaseEntity<UsuarioGrupo>
    {

        public UsuarioGrupo() { }
        public UsuarioGrupo(int Cod_Usuario, int Cod_Grupo) {
            this.Cod_Usuario = Cod_Usuario;
            this.Cod_Grupo = Cod_Grupo;
        }

        public int Id { get; set; }
        public int Cod_Usuario { get; set; }
        public int Cod_Grupo { get; set; }

        /*public static UsuarioGrupo Find(int Id, Context cx = null)
        {
            if (cx == null)
            { cx = new Context(); }

            return cx.Query<UsuarioGrupo>(
                    @"select 
                        Id
                       ,Cod_Usuario
                       ,Cod_Grupo
                    from UsuarioGrupo where Id = @Id", new { Id = Id }).FirstOrDefault();
        }*/

        public static List<UsuarioGrupo> ListByUusario(int Cod_Usuario, Context cx = null)
        {
            if (cx == null)
            { cx = new Context(); }

            return cx.Query<UsuarioGrupo>(
                    @"select
                        Id
                       ,Cod_Usuario 
                       ,Cod_Grupo 
                    from UsuarioGrupo
                    where Cod_Usuario = @Cod_Usuario", new { Cod_Usuario }).ToList();
        }

        public static List<UsuarioGrupo> ListByUusarios(int[] Cod_Usuarios, Context cx = null)
        {
            if (cx == null)
            { cx = new Context(); }

            return cx.Query<UsuarioGrupo>(
                string.Format(
                    @"select
                        Id
                       ,Cod_Usuario 
                       ,Cod_Grupo 
                    from UsuarioGrupo
                    where Cod_Usuario in ({0})", string.Join(',', Cod_Usuarios))).ToList();
        }

        private int Insert(Context cx = null)
        {
            if (cx == null)
            { cx = new Context(); }

            return cx.Query<int>(
                cx.PrepareInsert(
                    @"insert into UsuarioGrupo (
                        Cod_Usuario,
                        Cod_Grupo
                    ) {0} values (
                        @Cod_Usuario,
                        @Cod_Grupo
                    ) {1}", "Id"), this).Single();
        }

        private void Update(Context cx = null)
        {
            if (cx == null)
            { cx = new Context(); }

            cx.Execute(
                    @"update UsuarioGrupo set 
                        Cod_Usuario=@Cod_Usuario, 
                        Cod_Grupo=@Cod_Grupo 
                    where Id = @Id", this);
        }

        public void Save(Context cx = null)
        {
            if (this.Id == 0)
                this.Id = Insert(cx);
            else
                Update(cx);
        }

        public static void Delete(int Id, Context cx = null)
        {
            if (cx == null)
            { cx = new Context(); }

            cx.Execute(@"delete from UsuarioGrupo where Id = @Id", new { Id = Id });
        }

        public static void DeleteByUsuario(int Cod_Usuario, Context cx = null)
        {
            if (cx == null)
            { cx = new Context(); }

            cx.Execute(@"delete from UsuarioGrupo where Cod_Usuario = @Cod_Usuario", new { Cod_Usuario });
        }

        public static void UpdateGrupos(int Cod_Usuario, int[] Cod_Grupos, Context cx = null) {
            if (cx == null)
            { cx = new Context(); }

            try {
                cx.BeginTransaction();
                DeleteByUsuario(Cod_Usuario, cx);
                foreach (var Cod_Grupo in Cod_Grupos)
                {
                    (new UsuarioGrupo(Cod_Usuario, Cod_Grupo)).Save(cx);
                }
                cx.Commit();
            } catch {
                cx.Rollback();
            }
            
        }
    }
}
