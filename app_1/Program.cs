/*
 * Напишите программу, выводит рандомное число и выводит максимальную цифру этого числа в интервале от 10 до 100.
 * (вроде как то так звучало). 
 * Ну это от себя:  если не попадает в интервал вывести -1.
 * 18 -> 8 
 * 23 -> 3
 * 161 -> 6
 */


namespace App_1
{
    class Programm
    {
        static void Main(string[] args)
        {
            
            int num = GetRandomNumber(-10,99);

            Console.WriteLine($"write rand: {num} ");

            Console.WriteLine($"write max: {GetMaxDigit(num)} ");

        }

        static int GetRandomNumber(int minBorder, int maxBorder)
        {
           int result = new Random().Next(minBorder,maxBorder + 1 );
           return result;
        }

        static int GetMaxDigit(int number)
        {   
            int result = 0;
            int num = Math.Abs(number);
            
            if(num > 10 && num < 100)
            {
                int digitOne = number / 10;
                int digitTwo = number % 10;
                result = digitOne;
                
                if(result < digitTwo)
                {
                    result = digitTwo;
                }
            }
            else
            {
                result = -1;
            }

            return result;
        }
    }
}