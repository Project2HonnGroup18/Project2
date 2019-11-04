using System.Collections.Generic;
using AcademicReferenceManager.Models.Exceptions;
using AcademicReferenceManager.WebApi.Attributes;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Abstractions;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Routing;
using Xunit;

namespace UnitTests
{
    public class AuthorizeAttributeTests
    {
        private ActionExecutingContext generateContext()
        {
            var httpContext = new DefaultHttpContext();
            return new ActionExecutingContext(
                new ActionContext
                {
                    HttpContext = httpContext,
                    RouteData = new RouteData(),
                    ActionDescriptor = new ActionDescriptor()
                },
                new List<IFilterMetadata>(),
                new Dictionary<string, object>(),
                null
            );
            
        }
    
        [Fact]
        public void AuthorizeAdminAttribute_AsAuthenticated()
        {
            var context = generateContext();
            context.HttpContext.Request.Headers["Authorization"] = "auth";

            var admin = new AdminAttribute();
            Assert.Throws<AuthorizationException>(() => admin.OnActionExecuting(context));
        }

        [Fact]
        public void AuthorizeAdminAttribute_AsAdmin()
        {
            var context = generateContext();
            context.HttpContext.Request.Headers["Authorization"] = "admin";

            var admin = new AdminAttribute();
            admin.OnActionExecuting(context);
        }

         [Fact]
        public void AuthorizeAdminWithQueryAttributes_AsAnonymousNoQueries()
        {
            var context = generateContext();
            var admin = new AdminWithQueryAttributes();
        }

        [Fact]
        public void AuthorizeAdminWithQueryAttributes_AsAnonymousWithQueries()
        {
            var context = generateContext();
            context.HttpContext.Request.QueryString = context.HttpContext.Request.QueryString.Add("LoanDuration", "20");
   
            var admin = new AdminWithQueryAttributes();
            Assert.Throws<AuthorizationException>(() => admin.OnActionExecuting(context));
        }

        [Fact]
        public void AuthorizeAdminWithQueryAttributes_AsAdminWithQueries()
        {
            var context = generateContext();
            context.HttpContext.Request.Headers["Authorization"] = "admin";
            context.HttpContext.Request.QueryString = context.HttpContext.Request.QueryString.Add("LoanDuration", "20");
   
            var admin = new AdminWithQueryAttributes();
            admin.OnActionExecuting(context);
        }

        [Fact]
        public void AuthorizeAuthenticatedAttribute_AsAuthenticated()
        {
            var context = generateContext();
            context.HttpContext.Request.Headers["Authorization"] = "auth";

            var admin = new AuthenticatedAttribute();
            admin.OnActionExecuting(context);
        }

        [Fact]
        public void AuthorizeAuthenticatedAttribute_AsAdmin()
        {
            var context = generateContext();
            context.HttpContext.Request.Headers["Authorization"] = "admin";

            var admin = new AuthenticatedAttribute();
            admin.OnActionExecuting(context);
        }

        [Fact]
        public void AuthorizeAuthenticatedAttribute_AsAnonymous()
        {
            var context = generateContext();

            var admin = new AdminAttribute();
            Assert.Throws<AuthorizationException>(() => admin.OnActionExecuting(context));
        }
    }
}