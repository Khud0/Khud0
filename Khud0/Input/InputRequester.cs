using System;
using System.Collections.Generic;
using System.Text;

namespace Khud0.Input
{
    public class InputRequester
    {
        /// <summary>
        /// Asks user to provide an intereger and returns this value.
        /// </summary>
        /// <param name="inputDescription">What do you want user to provide? Example "desired sum".</param>
        /// <returns>0 if input is incorrect, otherwise user input.</returns>
        public int RequestInteger(string inputDescription)
        {
            Console.WriteLine($"Please enter {inputDescription}:\n");
            string input = Console.ReadLine();
            int parsedInput;
            if (int.TryParse(input, out parsedInput))
            {
                return parsedInput;
            } else 
            {
                Console.WriteLine("Invalid input. Using default value: 0");
                return 0;
            }  
        }
    }
}
