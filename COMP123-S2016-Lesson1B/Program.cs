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
 * Version: 0.3 - Updated comments for driver class program
 */


    
namespace COMP123_S2016_Lesson1B
{/*This is the driver class for our program
  *@class Program
  *
  */
    class Program
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
            Console.Write("Enter UserName: ");
           UserName =  Console.ReadLine();
            Console.WriteLine("/n=====================");
            Console.WriteLine("You Entered: "+ UserName);

            return UserName;
        }
    }
}
