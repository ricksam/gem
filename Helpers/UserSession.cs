using Microsoft.AspNetCore.Http;
using GEM.Repository;

namespace GEM.Helpers
{
    public class UserSession{
        public static UserSession Get(HttpContext context){
            try{
                string json = context.Session.GetString("GEM.Helpers.UserSession");
                if(string.IsNullOrEmpty(json)){
                    return new UserSession();
                }
                return JSON.Deserialize<UserSession>(json);
            }catch{
                return new UserSession();
            }
            
        }
        public static void Set(HttpContext context, UserSession value){
            if(value == null){
                context.Session.SetString("GEM.Helpers.UserSession", "");
            }
            else{
                context.Session.SetString("GEM.Helpers.UserSession", JSON.Serialize(value));
            }
        }

        public static void SetUsuario(HttpContext context, Usuario usuario){
            MemoryContext.Session = null;
            UserSession session = Get(context);
            session.Usuario = usuario;

            session.AvisoMax = GEM.Repository.Aviso.Max(
                                        usuario.Cod_Comum,
                                        usuario.Admin,
                                        usuario.Instrutor,
                                        usuario.Oficializado,
                                        usuario.RJM,
                                        usuario.Aluno);
            Set(context, session);
        }

        public Usuario Usuario{ get; set; }
        public bool UserLogged{
            get{
                return Usuario != null;
            }
        }

        public bool Admin {
            get { return UserLogged && Usuario.Admin; }
        }

        public bool Dev {
            get { return UserLogged && Usuario.Dev; }
        }

        public bool Instrutor {
            get { return UserLogged && Usuario.Instrutor; }
        }

        public bool Aluno {
            get { return UserLogged && Usuario.Aluno; }
        }

        public string Json(){
            return JSON.Serialize(this);
        }

        public string style { get; set; }

        public int AvisoMax{ get; set; }
    }
}