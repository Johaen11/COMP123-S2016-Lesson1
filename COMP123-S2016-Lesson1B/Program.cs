using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Author: Johaen Gnanakumar
 * Date Created: May 13,2016
 * Date Modified: May 13, 2016
 * Student ID: 300880309
 * 
 * 
 *Description: This Program demonstrates GitHub and version control 
 * best practices. We Also explore Unit Testing
 * 
 * Version: 0.6 - Refactored OutputStringToConsole
 */


    
namespace COMP123_S2016_Lesson1B
{/*This is the driver class for our program
  *@class Program
  *
  */
    public class Program
    {
        /*
         * Main Method for class Program
         * 
         * @param{string[]} args
         * @construtor Main
         */ 


        static void Main(string[] args)
        {
            GetUserName();
        }
        
        
     /*This method reads the UserName from the Console
      * 
      * @method GetUserName
      * @return {string} UserName
      * 
      */

        public static string GetUserName()
        {
            //Initialize Variable
            String UserName = "";

            OutputStringToConsole("Enter UserName: ", false);
            UserName = Console.ReadLine();

            Console.WriteLine("\n=====================\n");
            Console.WriteLine("You Entered: " + UserName + "\n");

            return UserName;
        }

        /*
         * This method writes a string to the console. Parameters allow the user to 
         * choose to ass a newLine character
         * 
         * @method OutputStringToConsole
         * @param {string} outputString
         * @param {bool} hasNewLine
         * @param {string} outputString
         * **/
        private static string OutputStringToConsole(string outputString, bool hasNewLine)
        {
            if (hasNewLine)
            {
                Console.WriteLine(outputString);
            }
            else
            {
                Console.Write(outputString);
            }
             // refactored using the ternary operator
            string suffixhasNewLine = hasNewLine ? "\n" : "";

            Console.Write(outputString + suffixString);

            return outputString;
        }
    }
}
