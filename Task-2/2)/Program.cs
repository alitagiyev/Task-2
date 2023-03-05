using System.Text.RegularExpressions;

namespace _2_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
              verilmihs 6 reqemli ededin
            ilk 3 denesinin 
            reqemleri cemi tap: example: 123600= 1+2+3 

             */
            int n, qaliq = 0 , yenireqem;

            Console.Write("6 reqemli ededi daxil edin: ");

            n = int.Parse(Console.ReadLine());

            while (n != 0)
            {
                yenireqem = n % 10;

                qaliq = qaliq * 10 + yenireqem;

                n /= 10;
            }
            Console.WriteLine("Tersi: " + qaliq);

            int count= 0,   cem1=0, qaliq1=0;   
           while (qaliq >0)
            {
                qaliq1= qaliq % 10;

                qaliq /= 10;
                 if (count < 3)
                {
                    cem1 += qaliq1;
                }
                 count++;   

            }

            Console.WriteLine($"Netice:{cem1}");
        }
    }
}