using System.Threading.Tasks;

namespace HelloWorldConsoleApp.Services
{
   /// <summary>
   /// IService Interface - Provides Service methods
   /// </summary>
   public interface IService
   {
      /// <summary>
      /// GetMessage
      /// </summary>
      /// <param name="message">string message</param>
      /// <returns></returns>
      Task<string> GetMessage(string message);
   }
}
