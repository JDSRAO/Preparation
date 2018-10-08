using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http.Filters;

namespace Vidly.Filters
{
    public class HandleExceptionAttribute : ExceptionFilterAttribute
    {
        public override void OnException(HttpActionExecutedContext actionExecutedContext)
        {
            base.OnException(actionExecutedContext);
            var response = new
            {
                message = "Application has encountered an unexpected error. Please try again later.",
            };

            var request = actionExecutedContext.ActionContext.Request;

            actionExecutedContext.Response = request.CreateResponse(HttpStatusCode.BadRequest, response);
        }
    }
}