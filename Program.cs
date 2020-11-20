using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Exercises_Random
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput;
            
            do
            {
                userInput = GetUserInput();
                if (userInput.Length < 5)
                {
                    Console.WriteLine("You must enter at least 5 characters.");
                }
            }
            while (userInput.Length < 5);
                        
        }

        public static string GetUserInput()
        {
            Console.WriteLine("Please type something...");
            return Console.ReadLine();
        }
    }
}
