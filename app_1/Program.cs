namespace App_1
{
    class Programm
    {
        static void Main(string[] args)
        {
            TestMethod($"Все работает");
        }

        static void TestMethod(string str)
        {
            Console.WriteLine(str);
        }
    }
}