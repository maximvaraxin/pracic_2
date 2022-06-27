/*
 *  12. Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому.
 *      Если число 2 не кратно числу 1, то программа выводит остаток от деления.
 *      34, 5 -> не кратно, остаток 4 
 *      16, 4 -> кратно
 */

namespace App_3
{
    class Programm
    {
        static void Main(string[] args)
        {   
            Console.Write($"enter the first number: ");
            double num_1 = Convert.ToDouble(Console.ReadLine());

            Console.Write($"enter the second number: ");
            double num_2 = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine(Multiple( num_1, num_2 ));
        }

        static string Multiple(double num_1, double num_2)
        {
            
            string multiple = (num_2 % num_1 == 0) ? $"multiples" : $"remainder of division : { num_2 % num_1 }";
            
            return multiple;
        }
    }
}