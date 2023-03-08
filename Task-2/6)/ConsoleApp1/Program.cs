using System.ComponentModel.DataAnnotations;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
        //6) verilmihs 8 reqemli ededin ilk I ve axirinci reqemlerini legv et
        l1:
            Console.WriteLine("8 reqemli eded daxil edin:");

            string number1 = Console.ReadLine();

            int number;

            if (!int.TryParse(number1, out number))
            {
                goto l1;
            }
            int len = (int)Math.Log10(number) + 1;
            if (len != 8)
            {
                goto l1;
            }
            number = number % 10000000;
            number = number /  10;

            Console.WriteLine(number);

        }
    }
}