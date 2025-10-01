using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Animation
{
    internal class Program
    {
        static (int, int) tuple = (5, 10);
        static void Main(string[] args)
        {
            while (true)
            {


                Random randomposition = new Random();
                int randomNumber = randomposition.Next(0, 10);
                Console.CursorVisible = false;
                Console.BackgroundColor = ConsoleColor.Blue;

                //Console.SetCursorPosition(tuple.Item1 , tuple.Item2);
                // Console.WriteLine(" ");

                tuple.Item1 = randomNumber;

                for (int i = 0; i < 10; i++)
                {

                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                    Console.SetCursorPosition(tuple.Item1, i);
                    Console.WriteLine(" ");

                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                    Console.SetCursorPosition(tuple.Item1, i);
                    Console.WriteLine(" ");
                    if (i > 0)
                    {
                        Console.SetCursorPosition(tuple.Item1, i - 1);
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.Write(" ");
                    }
                    Thread.Sleep(100);
                }

            }
        }
    }
}
