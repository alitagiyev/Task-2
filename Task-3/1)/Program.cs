using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace _1_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            l1:
            Console.Write("Nece telebe daxil olsun:");
            if (!int.TryParse(Console.ReadLine(),out number))
            {
                Console.WriteLine( "Reqem daxil et!!" );
                goto l1;
            }
            Student[] student1 = new Student[number];

            for (int i = 0; i < student1.Length; i++)
            {
                Student student = new Student();
                student.Name = Student.Helper($"{i + 1}.Telebenin adi:", false);
                student.Surname = Student.Helper($"{i + 1}.Telebenin soyadi:", false);
                student.Age = Student.Helper1($"{i + 1}.Telebenin yasi:");
                student.Speciality = Student.Helper($"{i + 1}.Telebenin ixtisasi:", false);
                student.GroupNo = Student.Helper($"{i + 1}.Telebenin Qrup nomresi:", false);
                student1[i] = student;
            }
           Console.Clear();
            foreach (var item in student1)
            {
                Console.WriteLine($"Adi:{item.Name} Soyad:{item.Surname}  Yasi:{item.Age}  Ixdisas:{item.Speciality}  Qrupu:{item.GroupNo}");
            }
        }

    }
}