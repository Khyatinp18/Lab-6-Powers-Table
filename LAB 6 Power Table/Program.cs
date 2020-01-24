using System;


namespace LAB_6_Power_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            char continueEntry = 'y';

            while (continueEntry == 'y')
            {
                int number = int.Parse(GetUserInput("Please enter a number:"));

                //Validation for the user's input
                if (number >= 1)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine($"Number\tSquared\tCubed");
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("======\t=======\t=====");

                    //This displays a table of squares and cubes from 1 to the value entered by user 
                    for (int i = 1; i <= number; i++)
                    {
                        int square = Square(i);
                        int cube = Cube(i);

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"{i}\t{square}\t{cube}\n");
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Invalid Entry\n");
                }

                //Validating the user's input and prompting the user to check if they want to continue
                continueEntry = ' ';
                while ((continueEntry != 'y') && (continueEntry != 'n'))
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Would you like to continue (y/n)?");
                    continueEntry = char.Parse(Console.ReadLine().ToLower());

                    
                    if ((continueEntry != 'y') && (continueEntry != 'n'))
                    {
                        Console.WriteLine("Invalid Entry\n");
                    }
                }


            }
            Console.WriteLine("Thank you for your time, Goodbye!");
            Console.ReadKey();
        }

        //Created custom methods to caclculate square and cube of a number entered by user
        public static int Square(int number)
        {

            int squareResult = number * number;
            return squareResult;
        }

        public static int Cube(int number)
        {

            int cubeResult = number * number * number;
            return cubeResult;
        }

        //Custom method to get user's input
        public static string GetUserInput(string message)
        {
            Console.WriteLine(message.ToLower());
            string input = Console.ReadLine();
            return input;
        }
    }

}
