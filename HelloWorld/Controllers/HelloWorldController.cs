using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Common;

namespace HelloWorld.Controllers
{
    public class HelloWorldController : ApiController
    {

      private readonly ILogger _logger;

      public HelloWorldController()
      {
         _logger = new ConsoleLogger();
      }

      // Need to rework when implemented Dependency Injection
      public HelloWorldController(ILogger logger)
      {
         this._logger = logger;
      }

        // GET: api/HelloWorld
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        // GET: api/HelloWorld/5
        public string Get(string message)
        {
            _logger.Log("This is from Hello World Controller");
            return message;
        }

        // POST: api/HelloWorld
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/HelloWorld/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/HelloWorld/5
        public void Delete(int id)
        {
        }
    }
}
