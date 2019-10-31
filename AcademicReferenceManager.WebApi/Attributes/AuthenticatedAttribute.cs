using AcademicReferenceManager.Models.Exceptions;
using Microsoft.AspNetCore.Mvc.Filters;

namespace AcademicReferenceManager.WebApi.Attributes
{
    public class AuthenticatedAttribute : ActionFilterAttribute
    {
        private readonly string authorizationToken = "auth";

        public override void OnActionExecuting(ActionExecutingContext context)
        {
            if(context.HttpContext.Request.Headers["Authorization"] != authorizationToken) 
            {
                throw new AuthorizationException("You are currently unauthorized");
            }
        }
    }
}
    
