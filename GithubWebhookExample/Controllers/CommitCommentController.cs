using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GithubWebhookExample.Github.webhook.events;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GithubWebhookExample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommitCommentController : ControllerBase
    {
        [HttpGet]
        public void Check()
        {

        }

        //[HttpPost]
        //public ActionResult RecievedResponse(CommitCommentEvent commitCommentEvent)
        //{

        //    return Ok();
        //}
    }
}