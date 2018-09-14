using System;

namespace Common
{
   /// <summary>
   /// This class provides log methods to console
   /// </summary>
   public class ConsoleLogger : ILogger
   {
      /// <summary>
      /// Logs to console
      /// </summary>
      /// <param name="message"></param>
      public void Log(string message)
      {
         Console.WriteLine(message + "This is logging");
      }
   }
}
