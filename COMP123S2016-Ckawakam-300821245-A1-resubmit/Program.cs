using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Author: Chinatsu Kawakami
 * Date Created: May 13, 2016
 * Date Modified: May 13, 2016
 * Student ID: 300821245
 * 
 * Discription: This program demostrates GitHub and version control
 * best practices. We also explore Unit Testing
 * 
 * Version: 0.4 - Added Test Project
 */
namespace COMP123S2016_Ckawakam_300821245_A1_resubmit
{
    /**
     * This is the driver class for our program
     * 
     * @class Program
     */
    public class Program
    {
        /**
         * Main Method for class Program
         * 
         * @param {string[]} args
         * @constractor Main
         */
        static void Main(string[] args)
        {
            // call the hello world to console method
            HelloWorldToConsole();
        }

        /**
        * @discription: This is my HelloWorldMethod
        * @method: HelloWorldToConsole
        * @return: {string} helloworldString
        */
        public static string HelloWorldToConsole()
        {
            //initialize variables
            string helloworldString = "Hello,World!";
            Console.WriteLine(helloworldString);
            return helloworldString;
        }
    }
}
