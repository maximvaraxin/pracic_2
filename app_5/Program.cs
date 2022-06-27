/*
 * Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
 * 5, 25 -> да
 * -4, 16 -> да 
 * 25, 5 -> да 
 * 8,9 -> нет
 */

namespace App_5
{
    class Programm
    {
        static void Main(string[] args)
        {
            Console.Write($"Введите число: ");
            double num_1 = Convert.ToDouble(Console.ReadLine());

            Console.Write($"Введите число: ");
            double num_2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Является ли одно число квадратом другого: {Sqtr(num_1, num_2)} ");

        }

        static string Sqtr(double number_1, double number_2)
        {
            string sqtr = ( (number_1 * number_1 == number_2) || (number_2 * number_2 == number_1) ) ? $"ДА" : $"НЕТ";

            return sqtr;
        }
    }
}