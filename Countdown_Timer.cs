using System;
using System.Threading;

namespace CountdownTimer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the countdown time in seconds: ");
            int countTime = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            while (countTime >= 0)
            {
                Console.SetCursorPosition(0, 0);
                TimeSpan time = TimeSpan.FromSeconds(countTime);
                Console.Write("Time Remaining: " + time.ToString(@"hh\:mm\:ss"));
                Thread.Sleep(1000);
                countTime--;
            }
        }
    }
}