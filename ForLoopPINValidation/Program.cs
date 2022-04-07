using System;

namespace ForLoopPINValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Enter your PIN");
                string userPIN = Console.ReadLine();

                if (userPIN == "1234")
                {
                    Console.WriteLine("Welcome");
                    break;
                }
                else
                {
                    Console.WriteLine($"Wrong PIN. You tried to log in {i+1} times");
                    if(i == 2)
                    {
                        Console.WriteLine("No attempts left. Try again later");
                    }
                }
            }
        }
    }
}
