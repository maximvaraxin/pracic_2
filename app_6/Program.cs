/*
 *  Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
 *  456 -> 5
 *  782 -> 8
 *  918 -> 1
 */

namespace App_6
{
    class Programm
    {
        static void Main(string[] args)
        {
            Console.Write($"enter a three-digit number: ");
            int number = Convert.ToInt32(Console.ReadLine());   

            Console.WriteLine($"the second number of the array: { SecondNumber(number) } ");
        }

        static int SecondNumber(int number)
        {   
            int result = 0;

            if(number >= 100 && number <= 999)
            {
                result = (number % 100) / 10;
            }
            else
            {
                result = -1;
            }
            
            return result;
        }

    }
}