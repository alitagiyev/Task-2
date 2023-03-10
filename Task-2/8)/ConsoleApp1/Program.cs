namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //8) Verilmis ededdin axirdan 3 - cu reqemi ile sonuncu reqeminin cemini tap
            int number = 345678;
            

            int LastDigit = number % 10;

            number = number / 100;

            int ThirdDigit = number % 10;


           
            int cem = LastDigit + ThirdDigit;

            Console.WriteLine(cem);
        }
    }
}

