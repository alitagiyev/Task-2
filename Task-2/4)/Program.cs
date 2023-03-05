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

            if (!int.TryParse(Console.ReadLine(), out int a) || a < 9999 || a > 100000)
            {

                goto l1;
            }

         
        }
    }
}