using ProblematicLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ProblematicProblemLevel2.Interaction
{
    internal static class UserInteraction
    {
        /// <summary>
        /// Wrapper for Console.ReadLine();
        /// </summary>
        /// <returns>Returns a string representation of the data typed to the console from the user</returns>
        internal static string GetUserInput()
        {            
            return Console.ReadLine();
        }

        internal static int GetUserAge()
        {            
            int age;
            bool success = int.TryParse(GetUserInput(), out age);
            while (!success)
            {
                ConsoleLogging.PassMessage("That is not a number\nTry again...", StatusCode.Error);
                success = int.TryParse(GetUserInput(), out age);
            }

            return age;
        }

        internal static DateTime GetUserDob()
        {            
            DateTime dob;
            bool success = DateTime.TryParse(GetUserInput(), out dob);
            while (!success)
            {
                ConsoleLogging.PassMessage("That is not a valid dob please do dd/mm/yyyy \nTry again...", StatusCode.Error);
                success = DateTime.TryParse(GetUserInput(), out dob);
            }

            return dob;
        }

        internal static int GetUserNumber()
        {
            int num;
            bool success = int.TryParse(GetUserInput(), out num);
            while (!success)
            {
                ConsoleLogging.PassMessage("That is not a valid number \nTry again...", StatusCode.Error);
                success = int.TryParse(GetUserInput(), out num);
            }

            return num;
        }
    }
}
