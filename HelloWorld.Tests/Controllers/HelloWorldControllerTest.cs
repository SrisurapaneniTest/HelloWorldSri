using HelloWorld.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HelloWorld.Tests.Controllers
{
   /// <summary>
   /// Test cases for Hello World Controller
   /// </summary>
   [TestClass]
   public class HelloWorldControllerTest
   {
      /// <summary>
      /// Test case for Get Method
      /// </summary>
      [TestMethod]
      public void Get()
      {
         // Arrange
         HelloWorldController controller = new HelloWorldController();

         // Act
         string result = controller.Get("Hello World from TestMethods");

         // Assert
         Assert.IsNotNull(result);
         Assert.AreEqual("Hello World from TestMethods", result);
      }
   }
}
