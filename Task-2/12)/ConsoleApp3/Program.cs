using System.Threading.Channels;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
        l1:
            Console.Write("5 reqemli eded daxil edin:");
            int eded1;
            if (!int.TryParse(Console.ReadLine(), out eded1))
            {
                goto l1;
            }

            int len = (int)Math.Log10(eded1) + 1;
            if (len != 5)
            {
                goto l1;
            }

          
        l2:
            Console.Write("5 reqemli eded daxil edin:");
            int eded2;
            if (!int.TryParse(Console.ReadLine(), out eded2))
            {
                goto l2;
            }

            int len1 = (int)Math.Log10(eded2) + 1;
            if (len1 != 5)
            {
                goto l2;
            }

           
        l3:
            Console.Write("5 reqemli eded daxil edin:");
            int eded3;
            if (!int.TryParse(Console.ReadLine(), out eded3))
            {
                goto l3;
            }

            int len3 = (int)Math.Log10(eded3) + 1;
            if (len != 5)
            {
                goto l3;
            }

            int Neweded1 = GeneralNum(eded1);
            int Neweded2 = GeneralNum(eded2);
            int Neweded3 = GeneralNum(eded3);

            int cavab=Neweded1 + Neweded2+ Neweded3;

            double cavab2 = cavab + cavab * 0.5;

            Console.WriteLine(eded1);
        }
        static int GeneralNum(int a)
        {

            int last = a % 10;

            int len = (int)Math.Log(a) + 1;

            int pow = (int)Math.Pow(10, len);

            int first = a / pow;

            a = first * 10 + last;

            return a;
        }

        

    }
}