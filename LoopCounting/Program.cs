using System;

namespace LoopCounting
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine(i+1);
            }

            Console.WriteLine();

            for(int i = 10; i > 0; i--)
            {
                Console.WriteLine(i);
            }
        }
    }
}
