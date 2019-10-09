using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GithubWebhookExample.Github.api
{
    public static class ApiCallerWithAuth
    {
        public static IRestResponse CallApi(string url)
        {
            var client = new RestClient(url);
            var request = new RestRequest(Method.GET);
            request.AddHeader("Authorization", "Bearer 99c8d34f636674527c9dee6e9ca5b5b4b43fd97a");
            return client.Execute(request);
        }
    }
}
