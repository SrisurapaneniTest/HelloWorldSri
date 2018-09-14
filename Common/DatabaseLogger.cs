using System;

namespace Common
{
   /// <summary>
   /// This class provides methods to log in database
   /// </summary>
   public class DatabaseLogger : ILogger
   {
      /// <summary>
      /// Logs the message to database
      /// </summary>
      /// <param name="message"></param>
      public void Log(string message)
      {
         Console.WriteLine(message + "This is from database logging");
      }
   }
}
