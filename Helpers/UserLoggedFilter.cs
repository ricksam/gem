using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace GEM.Helpers
{
    public class AllowAnonymous:Attribute
    {
    }

    public class UserLoggedFilter : IActionFilter
    {
        public void OnActionExecuting(ActionExecutingContext context)
        {
            try{
                if(!UserSession.Get(context.HttpContext).UserLogged){
                    RedirectToLogin(context);
            }
            }catch{
                RedirectToLogin(context);
            }
            
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
        }

        /*public bool IsApi(FilterContext context) {
            ApiExplorerSettingsAttribute apiAttribute = (ApiExplorerSettingsAttribute)context.ActionDescriptor.EndpointMetadata.FirstOrDefault(q => { return q.GetType() == typeof(ApiExplorerSettingsAttribute); }) ;
            return apiAttribute == null || apiAttribute.IgnoreApi == false;
        }*/

        public bool AllowAnonymous(FilterContext context)
        {
            AllowAnonymous apiAttribute = (AllowAnonymous)context.ActionDescriptor.EndpointMetadata.FirstOrDefault(q => { return q.GetType() == typeof(AllowAnonymous); });
            return apiAttribute != null;
        }

        /*public bool IsLoginAction(FilterContext context) {
            string controller = context.RouteData.Values["controller"].ToString();
            string action = context.RouteData.Values["action"].ToString();
            return action== "Login" && controller == "Home";
        }*/

        public void RedirectToLogin(FilterContext context) {
            if (/*!IsLoginAction(context)&&*/!AllowAnonymous(context)) {
                context.HttpContext.Response.Redirect("/Home/Login?callback="+ context.HttpContext.Request.Path.Value);
            }
        }
    }    
}