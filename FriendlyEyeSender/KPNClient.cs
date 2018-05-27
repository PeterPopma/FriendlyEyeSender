using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FriendlyEyeSender
{
    class KPNClient
    {
        static HttpClient client = new HttpClient();
        const string HOST_URL = "http://192.168.1.103:8000";  // "http://localhost:8000"; 

        public KPNClient()
        {
     //       client.BaseAddress = new Uri("");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public void PostSMS(string telephoneNumber, string address)
        {
            HttpResponseMessage response = null;
            string access_token = "";
            try
            {
                /* curl -X POST \
                     'https://api-prd.kpn.com/oauth/client_credential/accesstoken?grant_type=client_credentials' \
                     -H 'content-type: application/x-www-form-urlencoded' \
                     -d 'client_id=APP_CONSUMER_KEY&client_secret=APP_CONSUMER_SECRET'
                */
                client.DefaultRequestHeaders.TryAddWithoutValidation("Content-Type", "application/x-www-form-urlencoded");
                var content = new FormUrlEncodedContent(new[]
                {
                    new KeyValuePair<string, string>("client_id", "OheiFTNnQDAiIorhTVaBRcVhSt7hYWKy"), new KeyValuePair<string, string>("client_secret", "MvgAJadHESAghMpy")
                });
                response = client.PostAsync("https://api-prd.kpn.com/oauth/client_credential/accesstoken?grant_type=client_credentials", content).GetAwaiter().GetResult();
            }
            catch (HttpRequestException)
            {
                MessageBox.Show("Cannot connect to KPN host!");
                return;
            }

            string text = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();

            // Look for access token
            Regex re = new Regex(@"(?<=access_token\"" : \"")(.*?)(?=\"")");
            Match match = re.Match(text);
            if (match.Success)
            {
                access_token = match.Value;
            }


            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.Add("authorization", "BearerToken " + access_token);

            SMSMessage smsMessage = new SMSMessage("Warning! Suspicous activity on: " + address, telephoneNumber);
            SMS sms = new SMS("Friendly Eye");
            sms.messages.Add(smsMessage);
            string jsonString = sms.ToJSON();
            var jsonContent = new StringContent(jsonString, Encoding.UTF8, "application/json");

            try
            {

                client.DefaultRequestHeaders.TryAddWithoutValidation("Content-Type", "application/json");
                response = client.PostAsync("https://api-prd.kpn.com/messaging/sms-kpn/v1/send", jsonContent).GetAwaiter().GetResult();
            }
            catch (HttpRequestException)
            {
                MessageBox.Show("Cannot connect to KPN host!");
                return;
            }


        }

    }
}
