using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldConsoleApp.Services
{
   public interface IService
   {
      Task<string> GetMessage();
   }
}
