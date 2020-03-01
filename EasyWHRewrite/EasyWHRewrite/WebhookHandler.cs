using ServiceStack;

namespace EasyWHRewrite
{
    class WebhookHandler
    {
        public string URL;
        public string Nick;
        public string Avatar;

        public WebhookHandler(){}

        /// <summary>
        /// Sets the webhook info
        /// </summary>
        /// <param name="URL">Webhook's URL</param>
        /// <param name="Nick">Name to use</param>
        public void SetInfo(string URL, string Nick)
        {
            this.URL = URL;
            this.Nick = Nick;
            Avatar = null;
        }
        /// <summary>
        /// Sets the webhook info (with avatar)
        /// </summary>
        /// <param name="URL">Webhook's URL</param>
        /// <param name="Nick">Name to use</param>
        /// <param name="Avatar">Avatar URL to use</param>
        public void SetInfo(string URL, string Nick, string Avatar)
        {
            this.URL = URL;
            this.Nick = Nick;
            this.Avatar = Avatar;
        }

        /// <summary>
        /// Makes and sends a JSON POST request to the Webhook
        /// </summary>
        /// <param name="Content">Text to send as a message</param>
        public string Talk(string Content)
        {
            string R = SendRequest(MakeJSON(Content.Replace("\"", "\\\"")));
            if (R == "")
                return Nick + ": " + Content;
            else
                return R;
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
