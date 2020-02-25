using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using GEM.Repository;
using GEM.Models;

namespace GEM.Helpers
{
    public class UserSession{
        public UserSession(){
            Presencas = new List<int>();
        }
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

        public static void SetUsuario(HttpContext context, DadosSessao usuario){
            UserSession session = Get(context);
            session.Usuario = usuario;

            session.AvisoMax = GEM.Repository.Aviso.Max(
                                        session.Usuario.Cod_Comum,
                                        session.Usuario.Admin,
                                        session.Usuario.Instrutor,
                                        session.Usuario.Oficializado,
                                        session.Usuario.RJM,
                                        session.Usuario.Aluno);
            
            Set(context, session);
        }

        public static void SetUsuario(HttpContext context, Usuario usuario){
            DadosSessao dadosSessao = new DadosSessao();
            dadosSessao.Nome = Util.ShortName(usuario.Nome);
            dadosSessao.Comum = usuario.Comum;
            dadosSessao.Cod_Usuario = usuario.Cod_Usuario;
            dadosSessao.Cod_Comum = usuario.Cod_Comum;
            dadosSessao.Admin = usuario.Admin;
            dadosSessao.Dev = usuario.Dev;
            dadosSessao.Instrutor = usuario.Instrutor;
            dadosSessao.Oficializado = usuario.Oficializado;
            dadosSessao.RJM = usuario.RJM;
            dadosSessao.Aluno = usuario.Aluno;
            dadosSessao.AvisoLido = usuario.AvisoLido;
            dadosSessao.Token = usuario.Token;

            SetUsuario(context, dadosSessao);
        }

        public DadosSessao Usuario { get; set; }
        public bool UserLogged(){
            return Usuario != null;
        }

        public int Cod_Usuario() {
            return UserLogged() ? Usuario.Cod_Usuario : 0;
        }

        public int Cod_Comum() {
            return UserLogged() ? Usuario.Cod_Comum : 0;
        }

        public bool Admin() {
            return UserLogged() && Usuario.Admin;
        }

        public bool Dev() {
            return UserLogged() && Usuario.Dev;
        }

        public bool Instrutor() {
            return UserLogged() && Usuario.Instrutor;
        }

        public bool Aluno() {
            return UserLogged() && Usuario.Aluno;
        }

        public string Json(){
            return JSON.Serialize(this);
        }

        public List<int> Presencas { get; set; }

        public string style { get; set; }

        public int AvisoMax{ get; set; }
    }
}