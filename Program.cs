using System;
// your name, assignment, note
/*
 * a;sdfkads;if
 * a;gldjfas;kgi
 * multi-line comment
 */

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {




            double avg(int num1, int num2)
            {
                double average = (num1 + num2) / 2.0;
                return average;
            }



            int num1, num2;
            double result;
            bool correct = false;
            string name;
            int guess, answer;
            Console.WriteLine("please enter your name");
            name = Console.ReadLine();
            Console.WriteLine("welcome" + name);
            Random rand = new Random();
            answer = rand.Next(1, 11);// 1- 10

            while (!correct)
            {
                Console.WriteLine("please enter a # between 1 and 10");
                guess = Convert.ToInt32(Console.ReadLine());
                if (guess == answer)
                {
                    Console.WriteLine("you guessed it!!");
                    correct = true;
                }
                else if (guess < answer)
                {
                    Console.WriteLine("Too low");
                }
                else // this means it is great than
                {
                    Console.WriteLine("Too high");
                }
            }

            Console.WriteLine("please enter 1st number");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("please enter 2nd number");
            num2 = Convert.ToInt32(Console.ReadLine());
            result = avg(num1, num2);
            Console.WriteLine(" The average of " + num1 + num2 + " = " + result);
        }
    }
}