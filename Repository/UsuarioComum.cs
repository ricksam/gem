using System.Linq;
using System.Collections.Generic;
using GEM.Helpers;

namespace GEM.Repository
{
    public class UsuarioComum : BaseEntity<UsuarioComum> 
    {
        public int Cod_Usuario { get; set; }
        public int Cod_Comum { get; set; }

        public static UsuarioComum Find( int Cod_Usuario, int Cod_Comum, Context cx = null){
            return List(Cod_Comum, cx).FirstOrDefault(e => Cod_Usuario == e.Cod_Usuario && Cod_Comum == e.Cod_Comum);
        }
        
        public static List<UsuarioComum> List(int Cod_Comum, Context cx = null)
        {
            var list = MemoryContext.GetCache<List<UsuarioComum>>(Cod_Comum);

            if(list.Count == 0){
                if (cx == null)
                { cx = new Context(); }
            
                list = cx.Query<UsuarioComum>(
                    @"select
                        Cod_Usuario
                       ,Cod_Comum 
                    from Usuario
                    where Cod_Comum = @Cod_Comum", new { Cod_Comum }).ToList();
                MemoryContext.SetCache<List<UsuarioComum>>(list, Cod_Comum);
            }
            return list;
        }        
    }
}
