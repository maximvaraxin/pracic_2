//доделать после занятия(не успел без условия)


namespace App_1
{
    class Programm
    {
        static void Main(string[] args)
        {
            //TestMethod($"Все работает");
            
            int num = GetRandomNumber(10,30);
            Console.WriteLine($"write rand: ");
            Console.WriteLine(num);
            Console.WriteLine($"write max: ");
            Console.WriteLine(GetMaxDigit(num));
        }

        static void TestMethod(string str)
        {
            Console.WriteLine(str);
        }

        static int GetRandomNumber(int minBorder, int maxBorder)
        {
           int result = new Random().Next(minBorder,maxBorder + 1 );
           return result;
        }

        static int GetMaxDigit(int number)
        {   
            int result = 0;
            number = Math.Abs(number);
            
            if(number > 10 && number < 100)
            {
                int digitOne = number / 10;
                int digitTwo = number % 10;
                result = digitOne;
                
                if(result < digitTwo)
                {
                    result = digitTwo;
                }
            }
            return result;
        }
    }
}