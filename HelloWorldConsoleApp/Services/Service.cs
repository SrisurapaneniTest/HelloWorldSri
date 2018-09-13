using System.Threading.Tasks;
using System.Net.Http;

namespace HelloWorldConsoleApp.Services
{
   /// <summary>
   /// This class consumes all service methods
   /// </summary>
   public class Service : IService
   {
      /// <summary>
      /// GetMessage
      /// </summary>
      /// <param name="message">string message</param>
      /// <returns></returns>
      public async Task<string> GetMessage(string message)
      {              
         var httpClient = new HttpClient();
         var Url = "http://localhost:57533/api/HelloWorld?message=" + message;

         HttpResponseMessage response = await httpClient.GetAsync(Url);
         if (response.IsSuccessStatusCode)
         {
            message = await response.Content.ReadAsStringAsync();
         }

         return message;
         
      }
   }
}
