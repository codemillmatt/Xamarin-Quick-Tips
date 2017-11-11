namespace MobileCenter
{
    using System;
    using System.Net;
    using System.Collections.Generic;

    using Newtonsoft.Json;

    public class Post
    {
        [JsonProperty("body")]
        public string Body { get; set; }

        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("userId")]
        public long UserId { get; set; }
    }
}
