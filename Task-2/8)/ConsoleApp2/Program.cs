﻿namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             9) 9 reqemli ededdin tek yerde dayananlardan bir eded duzlet: 132346389=12439
             */

            int a = 123456789;

            int newNum = 0, qaliq = 0;

            while (a != 0)

            {
                qaliq = a % 10;

               


                if (a % 2 != 0)
                {
                    newNum = newNum * 10 + qaliq;
                    

                }
                a /= 10;
            }
         

        }
    }
}