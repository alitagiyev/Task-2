namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
        //12) 2 dene 5 reqemli eded daxil et.
        //I ededin reqemleri ceminin usutne II ededin reqemleri hasilini gel.
        //Neticenin axirina I ededin en axiinci reqemini artir.
        l1:
            Console.Write("5 reqemli eded daxil dein: ");

            int number;

            if (!int.TryParse(Console.ReadLine(), out number))
            {
                goto l1;
            }
            int len1 = (int)Math.Log10(number) + 1;
            if (len1!=5)
            {
                goto l1;
            }
        l2:
            Console.Write("5 reqemli eded daxil dein: ");

            int number1;

            if (!int.TryParse(Console.ReadLine(), out number1))
            {
                goto l2;
            }
            int len2 = (int)Math.Log10(number1) + 1;
            if (len2!=5)
            {
                goto l2;    
            }
            int cem = 0;
            int a = number % 10;
            while (number>0) 
            {
                cem = cem + (number % 10);
                number = number / 10;
            }
            int hasil = 0;
            while (number1>0)
            {
                hasil = hasil * (number1 % 10);
                number1 = number1 / 10;   
            }
            cem = cem + hasil;
            int cavab = cem * 10 + a;
            Console.WriteLine(cavab);
        }   
    }
}