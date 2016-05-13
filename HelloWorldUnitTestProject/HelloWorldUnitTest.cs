using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using COMP123S2016_Ckawakam_300821245_A1_resubmit;

namespace HelloWorldUnitTestProject
{
    /**
     * This class is used to test the  HelloWorld Project
     * Used for development only.
     * 
     * @class HelloWorldUnitTest
     *
     */
    [TestClass]
    public class HelloWorldUnitTest
    {

        /**
         * Unit test for HelloWorldToConsole Method from class 
         * 
         *  @method HelloWorldToConsoleTestMethod
         */
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
