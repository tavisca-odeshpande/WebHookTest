using GithubWebhookExample.Github.webhook.response.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GithubWebhookExample.Github.webhook.events
{
    public class PullRequestReview
    {
        public PullRequest PullRequest { get; set; }
    }
}
