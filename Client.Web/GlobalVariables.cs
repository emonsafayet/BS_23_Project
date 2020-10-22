using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;

namespace Client.Web
{
    public static class GlobalVariables
    {
        public static HttpClient ApiClient = new HttpClient();

        static GlobalVariables()
        {
            ApiClient.BaseAddress = new Uri("http://localhost:53516/api/");
            ApiClient.DefaultRequestHeaders.Clear();
            ApiClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

        }
    }
}