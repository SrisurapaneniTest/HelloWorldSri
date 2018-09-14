using Common;
using HelloWorld.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace HelloWorld.Tests.Controllers
{
   /// <summary>
   /// Test cases for Hello World Controller
   /// </summary>
   [TestClass]
   public class HelloWorldControllerTest
   {
      /// <summary>
      /// Test case for Get Method - Integration Test
      /// </summary>
      [TestMethod]
      public void Get()
      {
         // Arrange
         HelloWorldController controller = new HelloWorldController(new ConsoleLogger());

         // Act
         string result = controller.Get("Hello World from TestMethods");

         // Assert
         Assert.IsNotNull(result);
         Assert.AreEqual("Hello World from TestMethods", result);
      }

      /// <summary>
      /// This is Unit Test Method - Mocking objects
      /// </summary>
      [TestMethod]
      public void GetUnit()
      {
         var mock = new Mock<ILogger>();
         mock.Setup(x => x.Log(It.IsAny<string>())); // Mocking logger

         HelloWorldController controller = new HelloWorldController(mock.Object);
         var message= controller.Get("Hello World Unit Tests");
         // Assert
         Assert.IsNotNull(message);
         Assert.AreEqual("Hello World Unit Tests", message);

      }

      //public Setup()
      //{
      //   var contro
      //}
   }
}
