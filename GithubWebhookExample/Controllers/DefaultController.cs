using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using GithubWebhookExample.Github.api;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;

namespace GithubWebhookExample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("MyPolicy")]
    public class DefaultController : ControllerBase
    {
        [HttpGet]
        public ActionResult Check()
        {
            IRestResponse result =ApiCallerWithAuth.CallApi("https://api.github.com/repos/tavisca-odeshpande/WebhooksTest/pulls/1");
            return Ok();
        }

        //[HttpPost]
        //public ActionResult RecievedResponse(Payload payload)
        //{


        //    //var y = Request.Headers["X-Github-Event"];

        //    return Ok();
        //}
    }


}