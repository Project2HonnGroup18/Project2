using System;
using AcademicReferenceManager.Models.Exceptions;
using Microsoft.AspNetCore.Mvc.Filters;

namespace AcademicReferenceManager.WebApi.Attributes
{
    public class AuthenticatedAttribute : ActionFilterAttribute
    {
        private readonly string authorizationToken = "auth";
        private readonly string authorizationMaster = "admin";

        public override void OnActionExecuting(ActionExecutingContext context)
        {
            if(context.HttpContext.Request.Headers["Authorization"] != authorizationToken 
                    || context.HttpContext.Request.Headers["Authorization"] != authorizationMaster)
            {
                throw new AuthorizationException("You are currently unauthorized");
            }
        }
    }
}
    
