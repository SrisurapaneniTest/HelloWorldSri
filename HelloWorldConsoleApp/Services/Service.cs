using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Configuration;

namespace HelloWorldConsoleApp.Services
{
   public class Service : IService
   {

      //private readonly IRestClient restserviceClient;

      static HttpClient client = new HttpClient();

      //static async Task RunAsync()
      //{
      //   client.BaseAddress = new Uri("url");
      //   client.DefaultRequestHeaders.Accept.Clear();
      //   client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
      //}

      public async Task<string> GetMessage()
      {
         string message = string.Empty;

         //var apiUrl =  ConfigurationManager.AppSettings["APIUrl"];
         //client.BaseAddress = new Uri("http://localhost:57533/api/HelloWorld");
         //client.DefaultRequestHeaders.Accept.Clear();
         //client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

         //HttpResponseMessage response = await client.GetAsync(" "); // TODO
         //if (response.IsSuccessStatusCode)
         //{
         //   message = await response.Content.ReadAsStringAsync();

         //}
         //   return message;

         var httpClient = new HttpClient();
         var Url = "http://localhost:57533/api/HelloWorld";
         HttpResponseMessage response = await client.GetAsync(Url);
         if (response.IsSuccessStatusCode)
         {
            message = await response.Content.ReadAsStringAsync();
         }

         return message;
         
      }
   }
}
