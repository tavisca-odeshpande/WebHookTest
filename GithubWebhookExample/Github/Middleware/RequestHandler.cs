using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;

namespace GithubWebhookExample.Github.Middleware
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class RequestHandler
    {
        private readonly RequestDelegate _next;

        public RequestHandler(RequestDelegate next)
        {
            _next = next;
        }

        public Task Invoke(HttpContext httpContext)
        {
            httpContext = ControllerSelector(httpContext);
            return _next(httpContext);
        }

        private HttpContext ControllerSelector(HttpContext httpContext)
        {
            var eventType = httpContext.Request.Headers["X-Github-Event"];
            switch (eventType)
            {
                case "commit_comment":
                    httpContext.Request.Path = "/api/CommitComment";
                    break;
                case "pull_request_review":
                    httpContext.Request.Path = "/api/PullRequestReview";
                    break;
            }
            return httpContext;
        }
    }

    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class ResponseMiddlewareExtensions
    {
        public static IApplicationBuilder UseResponseMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<RequestHandler>();
        }
    }

}
