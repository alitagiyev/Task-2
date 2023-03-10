using System.Runtime.InteropServices;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
        //    7) verilmihs 4 reqemli ededin tersine duzub axirina ve evveline 8 artir
        l1:
            Console.Write("4 reqemli eded daxil edin:");

            string number1 = Console.ReadLine();

            int number;

            if (!int.TryParse(number1, out number))
            {
                goto l1;
            }
            int len = (int)Math.Log10(number) + 1;
            if (len != 4)
            {
                goto l1;
            }
            int qaliq;
            int newNum=0;
            while (number != 4)
            {
                qaliq = number % 10;
                newNum = newNum * 10 + qaliq;
                number /= 10;
            }
            Console.Write(newNum);
        }
    }
}