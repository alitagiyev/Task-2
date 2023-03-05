namespace _1_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                Console.Write("4 reqemli eded yazin: ");
                int n = Convert.ToInt32(Console.ReadLine());
                int sum = 0;
                while (n != 0)
                {
                    sum += n % 10;
                    n /= 10;
                }
                Console.WriteLine("Ededin reqemleri cemi: " + sum);
            }
        }
    }
}