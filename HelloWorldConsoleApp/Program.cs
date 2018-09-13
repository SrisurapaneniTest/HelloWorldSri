using HelloWorldConsoleApp.Services;
using System;
using System.Threading.Tasks;

namespace HelloWorldConsoleApp
{
   /// <summary>
   ///  Program Class
   /// </summary>
   public class Program
   {      
      /// <summary>
      /// Main Program
      /// </summary>
      /// <param name="args"></param>
      public static void Main(string[] args)
      {
         Console.WriteLine("Welcome to the Hello World Program");

         var service = new Service();
         var task = Task.Run(()=>service.GetMessage("Hello World"));

         Console.WriteLine(task.Result);
         Console.ReadLine();
      }

   }
  
}
