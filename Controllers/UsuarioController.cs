using System;
using Microsoft.AspNetCore.Mvc;
using GEM.Repository;
using GEM.Helpers;
using System.Linq;
using GEM.Models;

namespace GEM.Controllers
{
    public class UsuarioController : Controller
    {
        // GET: Usuario
        public ActionResult Index(int Cod_Comum = 0, string q = "", string Status = "")
        {
            if(UserSession.Get(Request.HttpContext).UserLogged()){
                if(Cod_Comum == 0 || !UserSession.Get(Request.HttpContext).Admin()){
                    Cod_Comum = UserSession.Get(Request.HttpContext).Cod_Comum();
                }
            }

            ViewBag.Cod_Comum = Cod_Comum;
            ViewBag.Status = Status;
            ViewBag.q = q;
            return View();
        }
        
        public ActionResult List(int Cod_Comum = 0, int Cod_Grupo = 0, string q = "", string Status = "")
        {
            if(Cod_Comum == 0 || !UserSession.Get(Request.HttpContext).Admin()){
                Cod_Comum = UserSession.Get(Request.HttpContext).Cod_Comum();
            }

            ViewBag.q = q; 
            ViewBag.Status = Status; 
            ViewBag.Cod_Comum = Cod_Comum;
            ViewBag.Cod_Grupo = Cod_Grupo;

            return View(Usuario.ListByComum(Cod_Comum, Cod_Grupo, "", Status));
        }

        [HttpGet]
        public ActionResult Edit(Usuario item)
        {
            if(item.Cod_Usuario == 0){
                item.Ativo = true;
            }
            return View(item);
        }

        [HttpPost]
        public ActionResult Save(Usuario model)
        {
            try{
                var usuario = UserSession.Get(Request.HttpContext).Usuario;
                if(model.Cod_Comum == 0 || !usuario.Admin){
                    model.Cod_Comum = usuario.Cod_Comum;
                }

                if(usuario.Instrutor){
                    //if(model.Aluno && model.Instrutor){
                      //  throw new Exception("Se o usuário é aluno, ele não pode ser instrutor!");
                    //}

                    if(Usuario.EmailJaCadastrado(model.Email, model.Cod_Usuario)){
                        throw new Exception("Email já cadastrado!");
                    }
                    
                    char oper = model.Cod_Usuario == 0 ? 'C' : 'U';
                    model.Save();
                    Monitor.Add<Usuario>(HttpContext, oper, model.Nome);
                }

                return Json("ok");
            }
            catch (Exception ex){
                return Json(ex.Message);
            }   
        }
    
        [HttpPost]
        public ActionResult Delete(int id = 0, int Cod_Comum = 0)
        {
            try{
                if(Cod_Comum==0 || !UserSession.Get(Request.HttpContext).Admin()){
                    Cod_Comum = UserSession.Get(Request.HttpContext).Cod_Comum();
                }

                string nome = Usuario.Find(id).Nome;
                Usuario.Delete(id, Cod_Comum);
                Monitor.Add<Usuario>(HttpContext, 'D', nome);
                return Json("ok");
            }
            catch (Exception ex){
                return Json(ex.Message);
            }
        }

        [HttpGet]
        public ActionResult Impersonate()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Impersonate(string Email)
        {
            try{
                GEM.Repository.Usuario usuario = GEM.Repository.Usuario.FindByEmail(Email);
                if(!usuario.Ativo){
                        throw new Exception("Usuário com acesso bloqueado.<br /> Clique em solicitar novo acesso!");
                    }
                UserSession.SetUsuario(Request.HttpContext, usuario);
                return RedirectToAction("Index", "Home");
            }
            catch(Exception ex){
                ViewBag.error = ex.Message;
                return View();
            }
        }

        public ActionResult ModoInstrutor(){
            var usuario = UserSession.Get(Request.HttpContext).Usuario;
            usuario.Dev = false;
            usuario.Admin = false;
            UserSession.SetUsuario(Request.HttpContext, usuario);
            return RedirectToAction("Index","Home");
        }

        public ActionResult ComboGrupo(int Cod_Comum = 0, int Cod_Grupo = 0, string DefaultText = "", string OnChange = ""){
            Combo combo = new Combo(); 
            combo.Name = "Cod_Grupo";
            combo.Id = "Cod_Grupo";
            combo.Class = "form-control";
            combo.DefaultText = DefaultText;
            combo.SelectedItem = Cod_Grupo.ToString();
            combo.OnChange = OnChange;
            combo.Items = GEM.Repository.Grupo.List(Cod_Comum).Select(e => new ComboItem(){Text=e.Nome,Value=e.Cod_Grupo.ToString()}).ToList();
            return PartialView("~/Views/Shared/_Combo.cshtml", combo);
        }
    }
}
