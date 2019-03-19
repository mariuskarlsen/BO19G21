using Library.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Library.API
{
    public class WebApi
    {
        private static HttpClient client = new HttpClient();
        private static string Baseurl = "https://bo19webapi.azurewebsites.net";

        public static async Task<Survey> GetSurvey(int id)
        {
            string url = $"{Baseurl}/api/survey/{id}";

            Survey survey = null;

            HttpResponseMessage response = await client.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                survey = await response.Content.ReadAsAsync<Survey>();
            }
            return survey;
        }
    }
}