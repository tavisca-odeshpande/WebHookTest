using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GithubWebhookExample.Github.api;
using GithubWebhookExample.Github.webhook.events;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GithubWebhookExample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PullRequestReviewController : ControllerBase
    {
        [HttpPost]
        public ActionResult<string> GetAllComments([FromBody]PullRequestReview pullRequestReview)
        {
            var x=ApiCallerWithAuth.CallApi(pullRequestReview.PullRequest.Url.ToString());
            return "";
        }

    }
}