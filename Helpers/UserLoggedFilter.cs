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
            if (!AllowAnonymous(context))
            {
                try
                {
                    if (!UserSession.Get(context.HttpContext).UserLogged())
                    {
                        string action = context.RouteData.Values["action"].ToString().ToLower();
                        if (action == "index")
                        {
                            context.HttpContext.Response.Redirect("/Home/Login?callback=" + context.HttpContext.Request.Path.Value);
                        }
                        else
                        {
                            context.HttpContext.Response.Redirect("/Home/Clear");
                        }
                    }
                }
                catch
                {
                    context.HttpContext.Response.Redirect("/Home/Clear");
                }
            }  
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
        }


        public bool AllowAnonymous(FilterContext context)
        {
            AllowAnonymous apiAttribute = (AllowAnonymous)context.ActionDescriptor.EndpointMetadata.FirstOrDefault(q => { return q.GetType() == typeof(AllowAnonymous); });
            return apiAttribute != null;
        }
    }    
}