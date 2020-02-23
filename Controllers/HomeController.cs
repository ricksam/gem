using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using GEM.Models;
using GEM.Repository;
using GEM.Helpers;

namespace GEM.Controllers
{
    public class HomeController : Controller
    {
        public HomeController(IMemoryCache cache)
        {
            MemoryContext.Cache = cache;
        }

        public IActionResult Index()
        {
            return View();
        }

        [GEM.Helpers.AllowAnonymous]
        public ActionResult Login()
        {
            return View();
        }

        [GEM.Helpers.AllowAnonymous]
        public ActionResult Clear() {
            return View();
        }

        public ActionResult Logout()
        {
            UserSession.Set(Request.HttpContext, null);
            return RedirectToAction("Login", "Home");
        }

        [HttpPost]
        [GEM.Helpers.AllowAnonymous]
        public ActionResult Login(string Email, string Senha)
        {
            try
            {
                GEM.Repository.Usuario usuario = GEM.Repository.Usuario.FindByEmail(Email);
                if(usuario != null){
                    if(Encryption.md5(Senha) != usuario.Senha ){
                        throw new Exception("Senha incorreta");
                    }

                    if(!usuario.Ativo){
                        throw new Exception("Usuário com acesso bloqueado.<br /> Clique em solicitar novo acesso!");
                    }

                    usuario.Senha="";
                    usuario.Token = Guid.NewGuid().ToString();
                    usuario.UpdateToken();
                    UserSession.SetUsuario(Request.HttpContext, usuario);
                    return RedirectToAction("Index", "Home");
                }
                else{
                    throw new Exception("Email não cadastrado");
                }
            }
            catch (Exception ex)
            {
                ViewBag.error = ex.Message;
                return View();
            }
        }

        [HttpPost]
        [GEM.Helpers.AllowAnonymous]
        public ActionResult UpdateSession(string Token)
        {
            try{
                if(!string.IsNullOrEmpty(Token)){
                    GEM.Repository.Usuario usuario = GEM.Repository.Usuario.FirstOrDefault(new { Token });
                    if(usuario == null ){
                        return Json("Informe email e senha no login");    
                    }

                    if(!usuario.Ativo){
                        throw new Exception("Usuário com acesso bloqueado.<br /> Clique em solicitar novo acesso!");
                    }

                    usuario.Comum = Comum.Find(usuario.Cod_Comum).Nome;

                    UserSession.SetUsuario(Request.HttpContext, usuario);
                    return Json("ok");
                }else{
                    return Json("Informe email e senha no login");
                }
            }catch(Exception ex){
                return Json(ex.Message);
            }
        }

        [GEM.Helpers.AllowAnonymous]
        public ActionResult LembrarSenha() {
            return View();
        }

        [HttpPost]
        [GEM.Helpers.AllowAnonymous]
        public ActionResult EnviarSenha(string Email)
        {
            try{
                GEM.Repository.Usuario usuario = GEM.Repository.Usuario.FindByEmail(Email);

                if(usuario==null){
                    throw new Exception("Email não cadastrado");
                }

                usuario.RecuperarSenha = Encryption.md5(usuario.Cod_Usuario.ToString() + usuario.Senha);
                usuario.UpdateRecuperarSenha();
            
                System.Net.ServicePointManager.SecurityProtocol = System.Net.SecurityProtocolType.Tls12 | System.Net.SecurityProtocolType.Tls11 | System.Net.SecurityProtocolType.Tls;
                //http://3.20.179.204/home/RecuperarSenha/XXXXXXXXXXX
                //http://myaccount.google.com/u/2/lesssecureapps?pli=1&pageId=none
                Helpers.Mail mail = new Helpers.Mail("smtp.gmail.com", "gemccbsmtp@gmail.com", "GEM@ccb01", true, true, 587);
                string html = string.Format(@"<html>
                    <body style='font-family: sans-serif;background-color: #f8f9fa;'>
                        <table c width='100%' style='border: solid 1px #189999;'>
                            <tr>
                                <td style='background-color: #189999; color: #fff; padding: 20px 10px;'>Músicos - CCB - Recuperar Senha</td>
                            </tr>
                            <tr>
                                <td style='padding: 10px;'>
                                    <span>Para recuperar senha clique no link abaixo ou copie e cole este link no seu navegador</span>
                                    <br /><br />
                                    <a href='http://www.musicosccb.com.br/home/RecuperarSenha/{0}' style='background-color: #495057; color:#fff;padding: 5px;border-radius: 5px;' hre='#'>http://www.musicosccb.com.br/home/RecuperarSenha/{0}</a> 
                                    <br /><br />
                                </td>
                            </tr>
                        </table>        
                    </body>
                </html>", usuario.RecuperarSenha);

                mail.SendMail(html, true, Email, "Músicos - CCB - Recuperar Senha", null);
                ViewBag.success = "Email enviado com sucesso!";
            
            }catch(Exception ex){
                ViewBag.error = ex.Message;
            }
            return View("LembrarSenha");
        }

        [HttpPost]
        [GEM.Helpers.AllowAnonymous]
        public ActionResult EnviarConvite(string Email)
        {
            try
            {
                GEM.Repository.Usuario usuario = GEM.Repository.Usuario.FindByEmail(Email);

                if (usuario == null)
                {
                    throw new Exception("Email não cadastrado");
                }

                usuario.RecuperarSenha = Encryption.md5(usuario.Cod_Usuario.ToString() + usuario.Senha);
                usuario.UpdateRecuperarSenha();

                System.Net.ServicePointManager.SecurityProtocol = System.Net.SecurityProtocolType.Tls12 | System.Net.SecurityProtocolType.Tls11 | System.Net.SecurityProtocolType.Tls;
                //http://3.20.179.204/home/RecuperarSenha/XXXXXXXXXXX
                //http://myaccount.google.com/u/2/lesssecureapps?pli=1&pageId=none
                Helpers.Mail mail = new Helpers.Mail("smtp.gmail.com", "gemccbsmtp@gmail.com", "GEM@ccb01", true, true, 587);
                string html = string.Format(@"<html>
                    <body style='font-family: sans-serif;background-color: #f8f9fa;'>
                        <table c width='100%' style='border: solid 1px #189999;'>
                            <tr>
                                <td style='background-color: #189999; color: #fff; padding: 20px 10px;'>Músicos - CCB - Convite de acesso ao sistema</td>
                            </tr>
                            <tr>
                                <td style='padding: 10px;'>
                                    <span>Seja muito bem vindo(a) ao sistema criado para os Músicos CCB! <br />Para acessar o sistema Músicos CCB crie uma nova senha clicando no link abaixo ou copie e cole este link no seu navegador</span>
                                    <br /><br />
                                    <a href='http://www.musicosccb.com.br/home/RecuperarSenha/{0}' style='background-color: #495057; color:#fff;padding: 5px;border-radius: 5px;' hre='#'>http://www.musicosccb.com.br/home/RecuperarSenha/{0}</a> 
                                    <br /><br />
                                </td>
                            </tr>
                        </table>        
                    </body>
                </html>", usuario.RecuperarSenha);

                mail.SendMail(html, true, Email, "Músicos - CCB - Convite", null);
                //ViewBag.success = "Email enviado com sucesso!";
                return Json("ok");
            }
            catch (Exception ex)
            {
                //ViewBag.error = ex.Message;
                return Json(ex.Message);
            }
            
        }

        [GEM.Helpers.AllowAnonymous]
        public ActionResult RecuperarSenha(string id) {
            GEM.Repository.Usuario usuario = GEM.Repository.Usuario.FindByRecuperarSenha(id);
            if(usuario == null){
                ViewBag.error = "Código de recuperação inválido!";   
            }
            return View(usuario);
        }

        [HttpPost]
        [GEM.Helpers.AllowAnonymous]
        public ActionResult NovaSenha(string id ,string Senha, string ConfirmarSenha)
        {
            GEM.Repository.Usuario usuario = GEM.Repository.Usuario.FindByRecuperarSenha(id);
            if(usuario == null){
                ViewBag.error = "Código de recuperação inválido!"; 
                return View("RecuperarSenha", usuario);  
            }

            if(Senha==ConfirmarSenha){
                usuario.Senha = Encryption.md5(Senha);
                usuario.UpdateSenha();
                UserSession.SetUsuario(Request.HttpContext, usuario);
                return RedirectToAction("Index", "Home");
            }else{
                ViewBag.error = "A senha e confirmação deverão ser idênticas!";
                return View("RecuperarSenha", usuario);
            }
        }

        [HttpGet]
        [GEM.Helpers.AllowAnonymous]
        public ActionResult SolicitarConvite(){
            return View();
        }

        [HttpPost]
        [GEM.Helpers.AllowAnonymous]
        public ActionResult SolicitarConvite(string Nome, string Email, string Comum, string Cidade, string Estado){
            try{
                Nome = Nome.Trim();
                Email = Email.Trim();
                Comum = Comum.Trim();
                Cidade = Cidade.Trim();
                Estado = Estado.Trim();

                System.Net.ServicePointManager.SecurityProtocol = System.Net.SecurityProtocolType.Tls12 | System.Net.SecurityProtocolType.Tls11 | System.Net.SecurityProtocolType.Tls;
                //http://3.20.179.204/home/RecuperarSenha/XXXXXXXXXXX
                //http://myaccount.google.com/u/2/lesssecureapps?pli=1&pageId=none
                Helpers.Mail mail = new Helpers.Mail("smtp.gmail.com", "gemccbsmtp@gmail.com", "GEM@ccb01", true, true, 587);

                string linkData = string.Format("?Nome={0}&Email={1}&Comum={2}&Cidade={3}&Estado={4}&Token={5}", 
                                Nome, Email, Comum, Cidade, Estado, Encryption.md5(Nome + Email + Comum));

                string links = string.Format("<br /><a href='http://www.musicosccb.com.br/home/Cadastrar{0}'>CRIAR NOVO CADASTRO AUTOMÁTICO</a><br />", linkData);

                List<GEM.Repository.Comum> comums = GEM.Repository.Comum.Where(new { Cidade, Estado }).ToList();
                
                foreach (var item in comums)
                {
                    links += string.Format("<br /><a href='http://www.musicosccb.com.br/home/Cadastrar{0}&Cod_Comum={1}'>CRIAR CADASTRO PARA: {2}</a><br />", linkData, item.Cod_Comum, item.Nome);
                } 

                string html = string.Format(@"
                        <h1>Solicitação de Convite</h1>
                        <p>
                            Nome:{0}<br />
                            Email:{1}<br />
                            Comum:{2}<br />
                            Cidade:{3}<br />
                            Estado:{4}<br />
                            {5}
                        </p>
                        ", Nome, Email, Comum, Cidade, Estado, links);
                mail.SendMail(html, true, "jricksam@gmail.com", "Músicos - CCB - Solicitação de Convite", null);
                ViewBag.success = "Convite enviado com sucesso! <br /> Aguarde a resposta no email : "+ Email;
                
            }catch(Exception ex){
                ViewBag.error = ex.Message;
            }
            
            return View("SolicitarConvite");
        }

        [HttpGet]
        [GEM.Helpers.AllowAnonymous]
        public ActionResult Cadastrar(string Nome = "", string Email = "", int Cod_Comum = 0, string Comum = "", string Cidade = "", string Estado = "", string Token = ""){

            try{
                if(Encryption.md5(Nome + Email + Comum) != Token){
                    throw new Exception("Token inválido!");
                }

                GEM.Repository.Comum comum = GEM.Repository.Comum.FirstOrDefault(new { Nome = Comum, Cidade, Estado });

                if(Cod_Comum == 0){
                    if(comum == null){
                        comum = new GEM.Repository.Comum();
                        comum.Nome = Comum;
                        comum.Cidade = Cidade;
                        comum.Estado = Estado;
                        comum.Save();
                    }
                }else{
                    comum = GEM.Repository.Comum.Find(Cod_Comum);
                }
                
                GEM.Repository.Usuario usuario = GEM.Repository.Usuario.FindByEmail(Email);

                if(usuario == null){
                    usuario = new Usuario();
                    usuario.Nome = Nome;
                    usuario.Email = Email;
                    usuario.Instrutor = true;
                    usuario.Oficializado = true;
                    usuario.Ativo = true;
                    usuario.Cod_Comum = comum.Cod_Comum;
                    usuario.Comum = comum.Nome;
                    usuario.Save();
                }
                
                EnviarConvite(Email);

                GEM.Helpers.UserSession.SetUsuario(Request.HttpContext, usuario);

                return RedirectToAction("Index", "Home");
            }
            catch(Exception ex){
                return Content(ex.Message);
            }
        }

        [HttpGet]
        public ActionResult FaleConosco(){
           return View(); 
        }

        [HttpPost]
        public ActionResult FaleConosco(string Mensagem){
            Usuario usuario = Usuario.Find(UserSession.Get(Request.HttpContext).Cod_Usuario()) ;
            try{
                System.Net.ServicePointManager.SecurityProtocol = System.Net.SecurityProtocolType.Tls12 | System.Net.SecurityProtocolType.Tls11 | System.Net.SecurityProtocolType.Tls;
                //http://3.20.179.204/home/RecuperarSenha/XXXXXXXXXXX
                //http://myaccount.google.com/u/2/lesssecureapps?pli=1&pageId=none
                Helpers.Mail mail = new Helpers.Mail("smtp.gmail.com", "gemccbsmtp@gmail.com", "GEM@ccb01", true, true, 587);

                string html = string.Format(@"
                        <h1>Fale Conosco</h1>
                        <p>
                            Usuário:{0}<br />
                            Email:{1}<br />
                            Mensagem:{2}
                        </p>
                        ", usuario.Nome, usuario.Email, Mensagem);
                mail.SendMail(html, true, "jricksam@gmail.com", "Músicos - CCB - Fale Conosco", null);
                ViewBag.success="Mensagem enviada com sucesso! <br />Breve entraremos em contato pelo email "+usuario.Email;
            }
            catch(Exception ex){
                ViewBag.error = ex.Message;
            }
           return View(); 
        }

        public ActionResult Template(string id = ""){
            var sessao = GEM.Helpers.UserSession.Get(Request.HttpContext);
            sessao.style = id;
            GEM.Helpers.UserSession.Set(Request.HttpContext, sessao);
            return View();
        }

        
        [GEM.Helpers.AllowAnonymous]
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


    }
}
