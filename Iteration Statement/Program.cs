// Author: Hanisha Pagarani
// Date: 01/28/2021
// Comments: This C# Console application code demonstrates the use of
// iterative statements after getting input from users. 

using System;

namespace Iteration_Statement
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask the user for input 
            Console.WriteLine("Enter an integer value between 1 and 100 to execute an iterative statement.");

            // This variable will gather data from user input
            string input = Console.ReadLine();
            // This variable will be used to perform the iterative statement and is parsed as an integer
            int value_of_input = int.Parse(input);

            // If the value of user input is between 1 and 100, execute a For Loop
            if ((value_of_input > 0) && (value_of_input < 100))
            {
                Console.WriteLine("Executing a For Loop!");
                Console.WriteLine("The For Loop will iterate" + value_of_input.ToString() + "times.");

                // This is the For loop
                for (int i = 0; i < value_of_input; i++)
                {
                    Console.WriteLine("The value of this variable i in this iteration is: " + i.ToString());
                }
                Console.WriteLine("Press any key to exit the program...");
                // Pause the program and await the user to press a key to exit the program
                Console.ReadKey(true);
            }
            // If the user does enter a value between 1 and 100, display a message
                    else
            {
                Console.WriteLine("Error! Please enter a number between 1 and 100.");
                Console.WriteLine("Press any key to exit the program and try again...");
                Console.ReadKey(true);

            }

            }
    }
}
