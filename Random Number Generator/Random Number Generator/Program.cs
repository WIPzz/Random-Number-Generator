using System;
using System.Dynamic;
using System.Text;




/*
x - Set the lenght of the random number (how many numbers)
x - Generate the random number based on n lenght
x - Show generate random number

Fix
x - Only accepts numbers as lenght
x - Create another random number if want
x - Dont accept 0 as lenght
x - Generating large numbers (1 000 000+) lenght takes too long.
        Before = 1 000 000 = 20sec
        After = 1 000 000 = 1sec

*/

namespace randomNumberGenerator
{
    class randomNumberGenerator
    {
        static void Main()
        {
            Console.WriteLine("This is a random number generator!");

            // Loop through the generator again if user wants to
            bool again = true;
            while (again)
            {
                numGen();

                Console.Write("\nDo you want another random number (Y/N)? ");
                string response = Console.ReadLine();

                // Only accepts y,Y,n,N
                while (response.ToUpper() != "Y" && response.ToUpper() != "N")
                {
                    Console.WriteLine("Invalid input.");
                    Console.Write("Do you want another random number (Y/N)? ");
                    response = Console.ReadLine();
                }

                again = (response.ToUpper() == "Y");
            }
            
        }
        static void numGen()
        {
            int lenNum;

            // Gets the lenght of the random number
            Console.Write("Set the lenght of the number: ");

            // Checks if lenNum is a number or > 0
            while (!int.TryParse(Console.ReadLine(), out lenNum) || lenNum == 0)
            {
                Console.WriteLine("Invalid input. Please enter an integer.");
                Console.Write("Set the lenght of the number: ");
            }

            // Create a random number
            Random rnd = new Random();
            StringBuilder sb = new StringBuilder();
            
            for (int i = 1; i <= lenNum; i++)
            {
                int rndNum = rnd.Next(0, 9);
                sb.Append(rndNum);
               // Console.Write(rndNum);
            }
            Console.Write(sb.ToString());

        }
    }
}
