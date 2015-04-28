using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net;
using System.Collections.Specialized;

namespace SlackPlugin {
	public class SlackClient {

        private Encoding _encoding = new UTF8Encoding();

        public Uri webHookUrl { get; set; }

        public SlackClient() {

        }

		public SlackClient (string webhook){
            webHookUrl = new Uri(webhook);
	    }

        public void SendMessage(string text, string username, string channel) {
            var payload = new Payload {
                Channel = channel,
                UserName = username,
                Text = text
            };

            string json = JsonConvert.SerializeObject(payload);
            using (var client = new WebClient()) {
                var data = new NameValueCollection();
                data["payload"] = json;
                var response = client.UploadValues(webHookUrl, "POST", data);
                string responseText = _encoding.GetString(response);

                //do we care about response??
            }
        }
	}

    public class Payload {

        [JsonProperty("channel")]
        public string Channel { get; set; }

        [JsonProperty("username")]
        public string UserName { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }
}
