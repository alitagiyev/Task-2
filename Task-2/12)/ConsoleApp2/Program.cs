using System.Runtime.ConstrainedExecution;
using System;
using System.Runtime.CompilerServices;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //13) 3 dene 5 reqemli eded var.
            //Her bir  ededin ilk ve son reqemlerininden 1 eded duzlet. Alinan neticeleri topla
            //Yekunda alian cavabin 50 % -ni hemin ededin uzerine gel.

            int number1 = Tapsiriqbir();
            int number2 = Tapsiriqbir();
            int number3 = Tapsiriqbir();

            



        }
        static int Tapsiriqbir()
        {
        l1:
            Console.Write("Ededi daxil edin:");
            if (!int.TryParse(Console.ReadLine(), out int secim)||(int)Math.Log10(secim) + 1 != 5)
            {
                Console.WriteLine("Yalniz 5 reqemli eded daxil edin !");
                goto l1;
            }
            return secim;



        }
    } 
    
}