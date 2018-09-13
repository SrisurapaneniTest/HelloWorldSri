using HelloWorldConsoleApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace HelloWorldConsoleApp
{
   //public class MainProgram : IMainProgram
   //{
   //   private readonly IService _service;
   //   private readonly ILogger _logger;

   //   public MainProgram(IService service, ILogger logger)
   //   {
   //      this._service = service;
   //      this._logger = logger;
   //   }

   //   public void MainInit(string[] args)
   //   {
   //      var message = _service.GetMessage();
   //   }
   //}

   //public interface IMainProgram
   //{
   //   void MainInit(string[] args);

   //}


   //public class StartUp
   //{
   //   public static void Main(string[] args)
   //   {
   //      // Setup dependency injection and run the application
   //      using (var container = new ServiceContainer())
   //      {
   //         // Configure depenency injection
   //         //container.Register<IHelloWorldConsoleApp, HelloWorldConsoleApp>();
   //         //container.Register<IAppSettings, ConfigAppSettings>();
   //         //container.Register<IConsole, SystemConsole>();
   //         //container.Register<ILogger, ConsoleLogger>();
   //         //container.Register<IUri, SystemUri>();
   //         //container.Register<IHelloWorldWebService, HelloWorldWebService>();
   //         //container.RegisterInstance(typeof(IRestClient), new RestClient());
   //         //container.RegisterInstance(typeof(IRestRequest), new RestRequest());

   //         // Run the main program
   //         container.GetInstance<IService>().Run(args);
   //      }

   //   }
   //}

   public class Program
   {
      // **** This is commented as getting error 'program-doesnt-contain-a-static-main-method-suitable-for-an-entry-point'
      //public async static void Main(string[] args)
      //{
      //   var service = new Service();
      //   var message = await service.GetMessage();
      //   Console.WriteLine(message);
      //}

      public static void Main(string[] args)
      {
         var service = new Service();
         var message = service.GetMessage();
         Console.WriteLine(message);
      }

   }

  
}
