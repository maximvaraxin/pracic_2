/*
 *  Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
 *  645 -> 5
 *  78 -> третьей цифры нет
 *  32679 -> 6
 */

namespace App_7
{
    class Programm
    {   
        static void Main(string[] args)
        {
            Console.Write($"enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());   
            
            string res = ThirdNumber(number) == -1 ? $"третьей цифры нет" :ThirdNumber(number).ToString();
            Console.WriteLine($"the third number of the array: { res } ");
        }

        static int ThirdNumber(int number)
        {   
            int result = 0;
                   
            if(number >= 100 && number < 1000)
            {
                result = number % 10;
            }
            else if(number >= 1000)
            {
                result = StringArray(number);
            }
            else
            {
                result = -1;
            }

            return result; 
        }

        static int StringArray(int number)
        {   
            string array = Convert.ToString(number);
            int result = Convert.ToInt32(array[2].ToString());

            return result;
        }
    }
}