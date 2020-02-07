using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using GEM.Models;
using GEM.Helpers;

namespace GEM.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [GEM.Helpers.AllowAnonymous]
        public ActionResult Login()
        {
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

                    usuario.Senha="";
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
        public ActionResult UpdateSession(UserSession sessao)
        {
            if(sessao.UserLogged){
                UserSession.Set(Request.HttpContext, sessao);
                return Json("ok");
            }else{
                return Json("Usuário não está logado");
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
                //https://myaccount.google.com/u/2/lesssecureapps?pli=1&pageId=none
                Helpers.Mail mail = new Helpers.Mail("smtp.gmail.com", "gemccbsmtp@gmail.com", "GEM@ccb01", true, true, 587);
                string html = string.Format(@"<html>
                    <body style='font-family: sans-serif;background-color: #f8f9fa;'>
                        <table c width='100%' style='border: solid 1px #189999;'>
                            <tr>
                                <td style='background-color: #189999; color: #fff; padding: 20px 10px;'>GEM - CCB - Recuperar Senha</td>
                            </tr>
                            <tr>
                                <td style='padding: 10px;'>
                                    <span>Para recuperar senha clique no link abaixo ou copie e cole este link no seu navegador</span>
                                    <br /><br />
                                    <a href='http://3.20.179.204/home/RecuperarSenha/{0}' style='background-color: #495057; color:#fff;padding: 5px;border-radius: 5px;' hre='#'>http://3.20.179.204/home/RecuperarSenha/{0}</a> 
                                    <br /><br />
                                </td>
                            </tr>
                        </table>        
                    </body>
                </html>", usuario.RecuperarSenha);

                mail.SendMail(html, true, Email, "GEM - CCB - Recuperar Senha", null);
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
                //https://myaccount.google.com/u/2/lesssecureapps?pli=1&pageId=none
                Helpers.Mail mail = new Helpers.Mail("smtp.gmail.com", "gemccbsmtp@gmail.com", "GEM@ccb01", true, true, 587);
                string html = string.Format(@"<html>
                    <body style='font-family: sans-serif;background-color: #f8f9fa;'>
                        <table c width='100%' style='border: solid 1px #189999;'>
                            <tr>
                                <td style='background-color: #189999; color: #fff; padding: 20px 10px;'>GEM - CCB - Convite de acesso ao sistema</td>
                            </tr>
                            <tr>
                                <td style='padding: 10px;'>
                                    <span>Seja muito bem vindo(a) ao sistema GEM CCB! <br />Para acessar o sistema GEM CCB crie uma nova senha clicando no link abaixo ou copie e cole este link no seu navegador</span>
                                    <br /><br />
                                    <a href='http://3.20.179.204/home/RecuperarSenha/{0}' style='background-color: #495057; color:#fff;padding: 5px;border-radius: 5px;' hre='#'>http://3.20.179.204/home/RecuperarSenha/{0}</a> 
                                    <br /><br />
                                </td>
                            </tr>
                        </table>        
                    </body>
                </html>", usuario.RecuperarSenha);

                mail.SendMail(html, true, Email, "GEM - CCB - Convite", null);
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

        public IActionResult Index()
        {
            return View();
        }

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
