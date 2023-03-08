using System.Data;
using System.Net.Http.Headers;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
        //5) verilmihs 6 reqemli ededin 1 ci reqemini hemin ededin axirina at.

        l1:
            Console.Write("6 reqemli eded daxil edin: ");

            string number1 = Console.ReadLine();

            int number;
          

            if (!int.TryParse(number1, out number))
            {
                goto l1;
            }

            int len = (int)Math.Log10(number)+1;
            if (len != 6)
            {
                goto l1;

               
            }
            int a = number / 100000;
            int c = number * 10 + a;




            Console.WriteLine(c);

        }

    }
}