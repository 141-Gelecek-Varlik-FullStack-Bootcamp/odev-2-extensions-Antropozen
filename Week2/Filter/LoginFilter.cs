using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Routing;
using System;

namespace Week2.Filter
{
    public class LoginFilter : Attribute, IActionFilter
    {
        private readonly string _auth;
        public LoginFilter(string auth)
        {
            _auth = auth;
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
            //throw new System.NotImplementedException();
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            if (_auth == "Admin" || _auth == "Developer")
            {
                return;
            }
            else
            {
                context.Result = new RedirectToRouteResult(new RouteValueDictionary(new { Controller = "Home", Action = "Privacy" }));
                return;
            }

        }
    }
}
