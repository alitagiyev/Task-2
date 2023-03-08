namespace _4_
{
    internal class Program
    {
        static void Main(string[] args)
        {
        /*verilmihs 5 reqemli
         * ilk ve son reqemlerinin 
         * ceminin
         * kvadrati
         */
        l1:
            Console.Write("5 reqemli eded daxil edin: ");
            string number = Console.ReadLine();
            int a;

            if (!int.TryParse(number, out a))
            {
                goto l1;
            }
            int len = (int)Math.Log10(a) + 1;

            if (len != 5)
            { 
                goto l1;    
            }

            int x = a / 10000;
            int y = a % 10;
            int z = x + y;
            double f =Math.Pow(z, 2);   

           Console.WriteLine(f);
        }

    }
}