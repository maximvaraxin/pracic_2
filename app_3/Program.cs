﻿/*
 *  12. Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому.
 *      Если число 2 не кратно числу 1, то программа выводит остаток от деления.
 *      34, 5 -> не кратно, остаток 4 
 *      16, 4 -> кратно
 */

namespace App_2
{
    class Programm
    {
        static void Main(string[] args)
        {
            //TestMethod($"Все работает");
            Console.WriteLine(Multiple( 4, 2 ));
   
        }

        static void TestMethod(string str)
        {
            Console.WriteLine(str);
        }

        static string Multiple(int num_1, int num_2)
        {
            string multiple = (num_1 % num_2 == 0) ? $"multiples" : $"remainder of division :  {num_1 % num_2}";
            return multiple;
        }
    }
}