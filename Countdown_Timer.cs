using System;

namespace CountdownTimer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the countdown time in seconds: ");
            int countTime = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
        }
    }
}