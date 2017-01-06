using System;
using System.Collections.Generic;
using Facebook;

namespace Frontend
{
    public static class Facebook
    {
        private const string PageId = "1790653341199179";
        private const string AppId = "1797812087146101";
        private const string AppSecret = "73d6a5ade078880f0bf2e0f71360118a";
        private const string AccessToken =
            "EAAZAjGb7TxnUBAGSWDZCaZB6ByiVZCtZBfyty6Mr2MXVSrv2VvvdPVcJOheWRnd3ZCMW0XvKqzB1ZBy3jbdsum0CVwOq4fCiteuer1t6PZCZAvjgd8aUMm7ZAukeTWssNy7lQthDqjgvjVFg8gM8a3nw83KvXNDITRZBZASyCRMKH5eskAZDZD";

        public static object PublishPost(string message, FacebookMediaObject media)
        {
            FacebookClient client = new FacebookClient(AccessToken)
            {
                AppId = AppId,
                AppSecret = AppSecret
            };
            return client.Post($"{PageId}/photos?", new Dictionary<string, object>
            {
                {"message", message},
                {"source", media}
            });
        }
    }
}