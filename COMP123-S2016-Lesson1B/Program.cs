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
 * Version: 0.2 - Added GetUserName method
 */



namespace COMP123_S2016_Lesson1B
{
    class Program
    {
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
