using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_CSharp
{
    public class Funktsioonid
    {
        public static int Korrutamine(int arv1, int arv2)
        {
            int kor = arv1 * arv2;
            return kor;
        }
        public static int[] masisvi(int n,bool t_f)
        {
            Random rnd = new Random();
            int[] arvud = new int[n];
            for (int i = 0; i < n; i++)
            {
                if (t_f==true)
                {
                    Console.WriteLine("Введите число");
                    string input = Console.ReadLine();
                    int output;
                    if (int.TryParse(input, out output))
                    {
                        arvud[i] = output;
                    }
                    else
                    {
                        Console.WriteLine("Вводите только числа");
                    }

                    
                }
                else
                {
                    arvud[i] = rnd.Next(1, 100);
                }
            }
            return arvud;
        }

        public static void ArvudEkran(Array massiiv)
        {
            int result = 0;
            int k = 0;
            foreach (var m in massiiv)
            {
                k = m.ToString().Length;
             
                if (k > result)
                {
                    result = k;
                }

            }
            result++;
            foreach (var m in massiiv)
            {
                Console.Write("{0,1}",m,result);
            }
        }

        public static double Keskmine(int n) 
        {
            double[] arvud = new double[n];
            double kesk=0;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Напишите число:");
                arvud[i] = int.Parse(Console.ReadLine());
            }
            foreach (double item in arvud)
            {
                kesk += item;
            }
            kesk = Math.Round(kesk / n,4);
            return kesk;

        }

        public static void kalkulator()
        {
            double a;
            double b;
            double answer = 0;
            char oper;
            Console.OutputEncoding = Encoding.GetEncoding(866);
            Console.InputEncoding = Encoding.GetEncoding(866);

            Console.Write("Введите первое число:");
            a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите второе число:");
            b = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите действие:");
            oper = Convert.ToChar(Console.ReadLine());

            if (oper == '+')
            {
                answer = a + b;
            }

            else if (oper == '-')
            {
                answer = a - b;
            }

            else if (oper == '*')
            {
                answer = a * b;
            }

            else if (oper == '/')
            {
                if (b != 0)
                    answer = a / b;
                else Console.WriteLine("На 0 делить нельзя");
            }
            else
            {
                Console.WriteLine("Неизвестное действие");
            }
            for (int i = 0; i < answer; i++)
            {
                Console.Write("nurr ");
            }
        }

        public static void stars(int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write("*");
                
            }
        }
        public static void starsnumb(int a, int b, int c) 
        {
            for (int i = 0; i < a; i++)
            {
                Console.Write("*");

            }
            Console.WriteLine();
            for (int i = 0; i < b; i++)
            {
                Console.Write("*");

            }
            Console.WriteLine();
            for (int i = 0; i < c; i++)
            {
                Console.Write("*");

            }
        }
    }


}
