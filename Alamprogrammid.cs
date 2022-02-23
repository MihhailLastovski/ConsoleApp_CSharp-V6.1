using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_CSharp
{
    class Alamprogrammid
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //Console.WriteLine(Funktsioonid.Keskmine(4));
            //Funktsioonid.kalkulator();
            //Funktsioonid.stars(15);
            Console.Write("Первое число: ");
            int first = int.Parse(Console.ReadLine());
            Console.Write("Второе число: ");
            int second = int.Parse(Console.ReadLine());
            Console.Write("Третье число: ");
            int third = int.Parse(Console.ReadLine());
            Funktsioonid.starsnumb(first,second,third);
            
            Console.ReadKey(true);
            
        }
    }
}
