using Dapper;
using System;
using System.Linq;
using System.Collections.Generic;
using GEM.Models;
using GEM.Helpers;

namespace GEM.Repository
{
    public class UsuarioPermissao : BaseEntity<Usuario> 
    {
        public int Cod_Usuario { get; set; }
        public bool Aluno { get; set; }
        public bool Instrutor { get; set; }
        public bool Oficializado { get; set; }
        public bool Admin { get; set; }
        public bool Ativo { get; set; }
        public bool RJM{ get; set; }
        //public int? Cod_Grupo { get; set; }
        

        // Não Gravaveis
        public bool Dev{ get; set; }
        public int Cod_Comum { get; set; }
        
        public static UsuarioPermissao Find(int Cod_Usuario, Context cx = null)
        {
            if (cx == null)
            { cx = new Context(); }
            
            return cx.Query<UsuarioPermissao>(
                    @"select 
                        u.Cod_Usuario
                       ,u.Aluno
                       ,u.Instrutor
                       ,u.Oficializado
                       ,u.Admin
                       ,u.Dev
                       ,u.RJM
                       ,u.Ativo
                       --,u.Cod_Grupo
                       ,u.Cod_Comum
                    from Usuario u
                    where u.Cod_Usuario = @Cod_Usuario", new { Cod_Usuario }).FirstOrDefault();
        }

        public void Update(Context cx = null)
        {
            if (cx == null)
            { cx = new Context(); }
            
            cx.Execute(
                    @"update Usuario set 
                        Aluno=@Aluno, 
                        Instrutor=@Instrutor, 
                        Oficializado=@Oficializado,
                        Admin=@Admin, 
                        RJM=@RJM,
                        Ativo=@Ativo--, 
                        --Cod_Grupo=@Cod_Grupo
                    where Cod_Usuario = @Cod_Usuario", this);
        }        
    }
}
