using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace _1_
{
    internal class Student
    {

        public string Name;
        public string Surname;
        public int Age;
        public string Speciality;
        public string GroupNo;
        

        public static string Helper(string Add,bool allowEmpty)

        {   
            l1:
            Console.Write(Add);
            string name =Console.ReadLine();

            if (!allowEmpty&&string.IsNullOrWhiteSpace(name))
            {
                goto l1;
            }
            return name;
        }
        public static int Helper1(string Add) 
        {
            int number;
           l2: Console.Write(Add);
            if (!int.TryParse(Console.ReadLine(),out number))
            {
                Console.WriteLine( "Reqem daxil edin:");
                goto l2;
            }
            return number;  
        }

    }

}
