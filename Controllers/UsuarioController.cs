using System;
using Microsoft.AspNetCore.Mvc;
using GEM.Repository;
using GEM.Helpers;
using System.Linq;
using GEM.Models;
using System.Collections.Generic;

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

                //if(!model.Aluno && !model.Oficializado && !model.Instrutor)

                if(model.Cod_Usuario != 0 && !usuario.Admin && UsuarioComum.Find(model.Cod_Usuario, model.Cod_Comum) == null){
                    throw new Exception("Usuário não cadastrado nesta comum!");
                }

                if(Usuario.EmailJaCadastrado(model.Email, model.Cod_Usuario)){
                    throw new Exception("Email já cadastrado!");
                }

                char oper = model.Cod_Usuario == 0 ? 'C' : 'U';
                model.Save();
                Monitor.Add<Usuario>(HttpContext, oper, model.Nome);

                if(usuario.Dev || usuario.Admin || usuario.Instrutor){
                    UsuarioPermissao permissao = UsuarioPermissao.Find(model.Cod_Usuario);

                    if(usuario.Dev){
                        permissao.Dev = model.Dev;
                    }

                    if(usuario.Admin){
                        permissao.Admin = model.Admin;
                        //permissao.Cod_Comum = model.Cod_Comum;
                    }

                    if(usuario.Instrutor){
                        permissao.Instrutor = model.Instrutor;
                        permissao.Oficializado = model.Oficializado;
                        permissao.RJM = model.RJM;
                        permissao.Aluno = model.Aluno;
                        permissao.Ativo = model.Ativo;
                        //permissao.Cod_Grupo = model.Cod_Grupo;   
                    }

                    permissao.Update();

                    if (usuario.Instrutor)
                    {
                        UsuarioGrupo.UpdateGrupos(model.Cod_Usuario, model.Cod_Grupos);
                    }
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

        [HttpPost]
        public ActionResult ListGrupos(int[] Cod_Grupos, int Cod_Comum) {
            ViewBag.Cod_Grupos = Cod_Grupos;
            ViewBag.Cod_Comum = Cod_Comum;
            return View("ListGrupos");
        }

        /*public ActionResult AddGrupo(List<int> Cod_Grupos, int Cod_Grupo, int Cod_Comum = 0)
        {
            if (Cod_Grupos.IndexOf(Cod_Grupo) == -1) {
                Cod_Grupos.Add(Cod_Grupo);
            }
            return View("ListGrupos", Cod_Grupos);
        }

        public ActionResult RemoveGrupo(List<int> Cod_Grupos, int Cod_Grupo, int Cod_Comum = 0)
        {
            for (int i = 0; i < Cod_Grupos.Count; i++)
            {
                if (Cod_Grupos[i] == Cod_Grupo) {
                    Cod_Grupos.RemoveAt(i);
                }
            }
            return View("ListGrupos", Cod_Grupos);
        }*/

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

        [HttpGet]
        public ActionResult Perfil(){
            return View(Usuario.Find(UserSession.Get(HttpContext).Cod_Usuario()));
        }
    }
}
