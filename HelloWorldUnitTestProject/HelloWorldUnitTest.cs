using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using COMP123S2016_Ckawakam_300821245_A1_resubmit;

namespace HelloWorldUnitTestProject
{
    [TestClass]
    public class HelloWorldUnitTest
    {
        [TestMethod]
        public void HelloWorldToConsoleTestMethod()
        {
            //Arrange
            string expectedresult = "Hello,World!";

            //Act
            string result = Program.HelloWorldToConsole();

            //Assert
            Assert.AreEqual(expectedresult, result);
        }
    }
}
