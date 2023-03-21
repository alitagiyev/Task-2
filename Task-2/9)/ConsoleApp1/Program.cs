using System;
using System.Runtime.InteropServices;
using System.Threading.Channels;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //10)        sonra cut yerde dayanlarinda bir eded duzlet, sonra onlari topla

            int number = 123456789;

            int reversedNumber = 0;
            
            while (number>0)
            {
                int eded = number % 10;
                reversedNumber = reversedNumber * 10 + eded;
                number /= 10;   
            }
            int even = 0;

            int odd = 0;

            number = reversedNumber;

            reversedNumber = 0;

            while (number>0)
            {
                int qaliq=number % 10;
                odd = odd * 10 + qaliq;
                number /= 10;

                if (number>0)
                {
                    int qaliq1 = number % 10;
                    even = even * 10 + qaliq1;
                    number /= 10;
                }
               
            }
            Console.WriteLine($"tek:{odd}");
            Console.WriteLine($"cut:{even}");
        }  

    }
}