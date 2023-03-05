namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 12345;
            int a = number / 100000;
            int b = number % 10;
            int c= a+b;
            double d =Math.Pow(c,2);
            Console.WriteLine(d);

        }
    }
}