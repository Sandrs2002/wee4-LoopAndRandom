using System;

namespace CalculateSumInLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int sum = 0;

            for(int i = 1; i < 11; i++)
            {
                int myRandom = rnd.Next(1, 11);
                sum = sum + myRandom;
                Console.WriteLine($"My random number is {myRandom}");
            }
            Console.WriteLine($"Total = {sum}");
        }
    }
}
