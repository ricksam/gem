using System;
using Microsoft.AspNetCore.Mvc;
using GEM.Repository;
using GEM.Helpers;

namespace GEM.Controllers
{
    public class UsuarioController : Controller
    {
        // GET: Usuario
        public ActionResult Index(int Cod_Comum = 0, string q = "", string Status = "")
        {
            ViewBag.Cod_Comum = Cod_Comum;
            ViewBag.Status = Status;
            ViewBag.q = q;
            return View();
        }
        
        public ActionResult List(int Cod_Comum = 0, string q = "", string Status = "")
        {
            if(!UserSession.Get(Request.HttpContext).Admin){
                Cod_Comum = UserSession.Get(Request.HttpContext).Usuario.Cod_Comum;
            }

            ViewBag.q = q; 
            ViewBag.Status = Status; 
            ViewBag.Cod_Comum = Cod_Comum;

            return View(Usuario.ListByComum(Cod_Comum, "", Status));
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
                if(model.Cod_Comum==0 || !UserSession.Get(Request.HttpContext).Admin){
                    model.Cod_Comum = UserSession.Get(Request.HttpContext).Usuario.Cod_Comum;
                }

                if(model.Aluno && model.Instrutor){
                    throw new Exception("Se o usuário é aluno, ele não pode ser instrutor!");
                }

                if(Usuario.EmailJaCadastrado(model.Email, model.Cod_Usuario)){
                    throw new Exception("Email já cadastrado!");
                }
                
                model.Save();
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
                if(Cod_Comum==0 || !UserSession.Get(Request.HttpContext).Admin){
                    Cod_Comum = UserSession.Get(Request.HttpContext).Usuario.Cod_Comum;
                }

                Usuario.Delete(id, Cod_Comum);
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
    }
}
