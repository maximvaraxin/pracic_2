/*
 * 11. Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
 * 456 -> 46
 * 782 -> 72
 * 918 -> 98
 */

namespace App_2
{
    class Programm
    {
        static void Main(string[] args)
        {
            //TestMethod($"Все работает");
            
            DelNumber(Rand());
   
        }

        static void TestMethod(string str)
        {
            Console.WriteLine(str);
        }

        static int Rand()
        {
           return new Random().Next(100,1000);
        }

        static void DelNumber(int num)
        {   
            int numDel = (num % 100) / 10;
            
            int num1 = (num / 100) % 10;
            int num2 = num % 10;

            Console.Write($"{num1}{num2}");
        }
    }
}