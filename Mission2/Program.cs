using System;

namespace Mission2
{
    class Program
    {
        static void Main(string[] args)
        {
            int rolls = 0;
            int i = 0;
            int[] arr = new int[11];
            int numAsterisks = 0;

            Console.WriteLine("Welcome to the dice throwing simulator!\n");
            Console.Write("How many dice rolls would you like to simulate? ");
            rolls = Convert.ToInt32(Console.ReadLine());

            for (i = 0; i < rolls; i++)
            {
                Random rnd = new Random();
                int dice1 = rnd.Next(1, 7);
                int dice2 = rnd.Next(1, 7);
                int total = dice1 + dice2;
                
                arr[total-2]++;
            }
            
            Console.WriteLine("\nDICE ROLLING SIMULATION RESULTS \nEach \"*\" represents 1% of the total number of rolls.");
            Console.WriteLine("Total number of rolls = {0}", rolls + ".\n");

            for (int count = 0; count < 11; count++)
            {
                numAsterisks = 100 * arr[count] / rolls;

                Console.Write(count + 2 + ": ");
                for (int k = 0; k < numAsterisks; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
            Console.WriteLine("\nThank you for using the dice throwing simulator. Goodbye!");
        }
    }
}
