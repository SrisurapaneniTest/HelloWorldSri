using System.Web.Http;
using Common;

namespace HelloWorld.Controllers
{
   /// <summary>
   /// HellWorld Controller
   /// </summary>
   public class HelloWorldController : ApiController
   {
      #region Member variables

      private readonly ILogger _logger;

      #endregion

      #region Contructor

      /// <summary>
      /// Default constructor
      /// </summary>
      public HelloWorldController()
      {
         this._logger = new ConsoleLogger();
      }


      /// <summary>
      /// Parameterized constructor
      /// </summary>
      /// <param name="logger"></param>
      public HelloWorldController(ILogger logger)
      {
         this._logger = logger;
      }

      #endregion Constructor

      #region Public Methods

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

      #endregion

   }
}
