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

            int a ;


            if (!int.TryParse(Console.ReadLine(), out  a) || a < 9999 || a > 100000)
            {
                
                goto l1;

                int x = x / 1000;
                int b = b % 10;
                int c = a + b;
                double z= Math.Pow(c,2);



            }

             Console.WriteLine(a);
        }
    }
}