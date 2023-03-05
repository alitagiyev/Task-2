using System.Collections.Specialized;

namespace _3_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             verilmihs 9 reqemli ededin 
            duz ortaya dushen 3 reqeminin 
            reqemleri cemi
             */
            
             
            l1:
            Console.Write("9 reqemli ededi daxil edin: ");
          
            if (!int.TryParse(Console.ReadLine(),out int a)|| a<99999999 || a>1000000000) 
            {
                goto l1;
            }
            int yenireqem = 0, qaliq;
            while (a > 0)
            {
                qaliq = a % 10;
                yenireqem = yenireqem * 10 + qaliq;
               a/= 10;
            }
            Console.Write("Tersi: " + yenireqem);
            int count = 0, cem = 0, sonuc = yenireqem, qaliq1;

            while (sonuc>0)
            {

                qaliq1 = sonuc % 10;
                sonuc /= 10;
                if (count>=3 && count<6)
                {
                   
                    cem += qaliq1;
                }
               
                count++;
            }
            Console.WriteLine();
            Console.WriteLine(cem);
        }
        
           
    }  
    
    
}