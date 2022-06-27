﻿/*
 * Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23. 
 * 14 -> нет 
 * 46 -> нет 
 * 161 -> да
 * 
 * Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
 * 5, 25 -> да
 * -4, 16 -> да 
 * 25, 5 -> да 
 * 8,9 -> нет
 */

namespace App_4
{
    class Programm
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Введите число: ");
            double num = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Кратно ли число одновременно 7 и 23: {Multiple(num)} ");

        }

        static string Multiple(double number)
        {
            string multiple = ( (number % 7 == 0) && (number % 23 == 0)) ? $"ДА" : $"НЕТ";

            return multiple;
        }
    }
}