using System.Runtime.ConstrainedExecution;
using System.Threading.Channels;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 11) 8 reqemli ededin reqemlerini iki -iki qruplashdir.
            // Qruplarin cemini tap.Alinan cavabin axirina 99 artir.
            // Sonra cavabin ozunden onun 18 % ni cix;

            int number = 12345678;
            int cem = 0;

            while (number > 0)
            {
                cem = cem +(number%100);
                number /= 100;
            }

            cem = cem * 100 + 99;
            double cavab = cem * 0.82;
            Console.WriteLine(cavab);
        }
       
    }

}