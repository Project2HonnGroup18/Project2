using AcademicReferenceManager.Models.Exceptions;
using Microsoft.AspNetCore.Mvc.Filters;

namespace AcademicReferenceManager.WebApi.Attributes
{
    public class AdminAttribute : ActionFilterAttribute
    {
        private readonly string authorizationToken = "admin";

        public override void OnActionExecuting(ActionExecutingContext context)
        {
            if(context.HttpContext.Request.Headers["Role"] != authorizationToken) 
            {
                throw new AuthorizationException("Not authorized as admin");
            }
        }
    }
}
