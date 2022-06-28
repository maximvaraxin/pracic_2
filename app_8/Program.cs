/*
 *  Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
 *  6 -> да
 *  7 -> да
 *  1 -> нет
 */

namespace App_8
{
    class Programm
    {
        static void Main(string[] args)
        {
            Console.Write($"enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());   

            Console.WriteLine(GetWeekday(number));
        }

        static string GetWeekday( int num )
        {
            if( num > 0 && num <= 5)
            {
                return $"Сегодня рабочий день";
            }
            else if(num > 5 && num < 8)
            {
                return $"Сегодня выходной";
            }
            else
            {
                return $"Введено неверное число";
            }
        }
    }
}