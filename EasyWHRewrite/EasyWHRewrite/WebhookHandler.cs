using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using ServiceStack;
using ServiceStack.Text;

namespace EasyWHRewrite
{
    class WebhookHandler
    {
        public string URL;
        public string Nick;
        public string Avatar;

        public WebhookHandler(){}

        // Set the Webhook info
        public void SetInfo(string URL, string Nick)
        {
            this.URL = URL;
            this.Nick = Nick;
            Avatar = null;
        }
        public void SetInfo(string URL, string Nick, string Avatar)
        {
            this.URL = URL;
            this.Nick = Nick;
            this.Avatar = Avatar;
        }

        // Makes and sends a JSON POST request to the Webhook
        public string Talk(string Content)
        {
            return SendRequest(MakeJSON(Content.Replace("\"", "\\\"")));
        }

        // Makes the JSON data of a request
        private object MakeJSON(string Content)
        {
            if(Avatar != null)
            {
                return new { avatar_url = Avatar, content = Content, username = Nick };
            }
            else
            {
                return new { content = Content, username = Nick };
            } 
        }

        // Sends a POST requset to the Webhook
        private string SendRequest(object JSON)
        {
            return URL.PostJsonToUrl(JSON);
        }
    }
}
