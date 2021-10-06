using System;

namespace NumberAnalyzerApp
{
    class Program
    {
        static void Main(string[] args)
        {

            //1) Prompt user to enter an integer between 1 and 100
            //2) Determine integer is odd
            //3) Determine integer even and less than 25
            //4) Determine interger odd or even above 26 to 100
            //5) display result to console
            //6) Prompt user if they would like to continue by pressing Y/N
            //7) If Y loop code
            bool goOn = true;
            while (goOn)
            {
                Console.WriteLine("Welcome to the Number Analyzer App!");

                Console.WriteLine("Please input an integer between 1 and 100.");
                int i = int.Parse(Console.ReadLine());

                if (i % 2 == 1)
                {
                    Console.WriteLine($"{i} and Odd");
                }
                else if (i % 2 == 0 && i < 25)
                {
                    Console.WriteLine($"{i} Even and less than 25");
                }
                else if (i % 2 == 0 && i >= 60 || i >= 26 )
                {
                    Console.WriteLine($"{i} and Even");
                }
                else if (i % 2 == 1 && i >= 60 || i >= 26 )
                {
                    Console.WriteLine($"{i} and Odd");
                }
                else
                {
                    Console.WriteLine($"{i} Not an interger");
                }

                Console.WriteLine("Would you like the loop to continue? Y/N");
                string response = Console.ReadLine().ToUpper();
                if (response == "Y")
                {
                    Console.WriteLine("Continuing the loop");

                }
                else if (response == "N")
                {
                    Console.WriteLine("Good Bye!");
                    break;

                }
                else
                {
                    Console.WriteLine("I'm sorry I did not understand!");
                    Console.WriteLine("Try again!");
                }
                Console.WriteLine();
            }
        }
    }
}
            
            
 
    

