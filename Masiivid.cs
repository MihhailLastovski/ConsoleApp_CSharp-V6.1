using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_CSharp
{
    class Masiivid
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            /*
            int q = 10;
            int korrutis = Funktsioonid.Korrutamine(q, 5);
            Console.WriteLine(korrutis);
            Console.ReadKey(true);
            Console.OutputEncoding = Encoding.UTF8;
            
            //2
            Array arvuD;
            arvuD = Funktsioonid.masisvi(5, true);
            Funktsioonid.ArvudEkran(arvuD);
            int summa = 0;
            int korrutis = 1;
            foreach (int arv in arvuD)
            {
                summa += arv;
                korrutis *= arv;
            }
            
            for (int c = 0; c < arvuD.Length; c++)
            {
                summa += arvuD[c];
                korrutis *= arvuD[c];
            }
            Console.WriteLine($"Summa= {summa}");
            Console.WriteLine($"Korrutis= {korrutis}");
            Console.WriteLine($"Keskmine= {summa/arvuD.Length}");
            ConsoleKeyInfo klik;
            do
            {
                klik = Console.ReadKey(true);
                Console.Beep();
            } while (klik.Key != ConsoleKey.Escape);
            Environment.Exit(0);




            /*
            //1
            Random rnd = new Random();
            int N = rnd.Next(1, 50);
            int M = rnd.Next(1, 50);
            if (N > M)
            {
                int abi = N;
                N = M;
                M = abi;
            }
            Console.WriteLine($"N={N}");
            Console.WriteLine($"M={M}");
            int[] NM = new int[M - N + 1];
            for (int j = N; j < M + 1; j++)
            {
                NM[j - N] = j;
                Console.WriteLine(j * j);
            }
            ConsoleKeyInfo klik;
            do
            {
                klik = Console.ReadKey(true);
                Console.Beep();
            } while (klik.Key != ConsoleKey.Escape);
            Environment.Exit(0);
           */
            Array arvud;
            arvud = Funktsioonid.masisvi(10, false);
            foreach (int arv in arvud)
                Funktsioonid.ArvudEkran(arvud);
            /*
            string[] nimed = new string[5] { "Anna", "Olga", "Mark", "Timur", "Jegor" };
            foreach (string nim in nimed)
            {
                Console.WriteLine($"\n {nim} ");
            }

            int a=0;
            do
            {
                Console.WriteLine("Jrkordne number(tavaline inimene): ");
                try
                {
                    a = int.Parse(Console.ReadLine());
                }
                catch (Exception e)
                {

                    Console.WriteLine(e);
                }

            } while (a<1 || a>5);
            Console.WriteLine(nimed[a-1]);
            
            
            //3
            string answer;
            do
            {
                Console.WriteLine("Купи слона!");
                answer = Console.ReadLine();

            } while (answer != "слон");
            ConsoleKeyInfo klik;
            do
            {
                klik = Console.ReadKey(true);
                Console.Beep();
            } while (klik.Key != ConsoleKey.Escape);
            Environment.Exit(0);
            //4
            Random rnd = new Random();
            int arv = rnd.Next(1, 100);
            int answer;
            int i=5;
            while (true)
            {
                Console.WriteLine("Угадайте число от 1 до 100");
                answer = int.Parse(Console.ReadLine());
                i -= 1;
                if (i == 0)
                {
                    Console.WriteLine("У вас закончились попытки");
                    break;
                }
                else if (answer == arv) 
                {
                    Console.WriteLine("Вы угадали число");
                    break;
                }
                Console.WriteLine($"Количество оставшихся попыток {i}");

            }
            ConsoleKeyInfo klik;
            do
            {
                klik = Console.ReadKey(true);
                Console.Beep();
            } while (klik.Key != ConsoleKey.Escape);
            Environment.Exit(0);
            
            //5
            int[,] tabel=new int[10, 10];
            for (int i = 1; i < 11; i++)
            {
                for (int j = 1; j < 11; j++)
                {
                    tavel[row,col] = row * col;
                    Console.Write(i * j+" ");
                }
                Console.WriteLine();
            }
            */
            /*
            Console.WriteLine();
            for (int a = 1; a < 11; a++)
            {
                for (int b = 1; b < 11; b++)
                {
                    Console.Write((a * b) + "\t");
                }
                Console.WriteLine();
            }
            ConsoleKeyInfo klik;
            do
            {
                klik = Console.ReadKey(true);
                Console.Beep();
            } while (klik.Key != ConsoleKey.Escape);
            Environment.Exit(0);

            
            //4
            */
            Array massiiv4;
            massiiv4 = Funktsioonid.masisvi(4, true);
            /*
            int[] massiiv4 = new int[4];
            for (int k = 0; k < massiiv4.Length; k++)
            {
                massiiv4[k] = int.Parse(Console.ReadLine());
            */
            Array.Sort(massiiv4);
            int D = 0;
            int t = 0;
            foreach (int item in massiiv4)
            {
                D=(int)(D+item * Math.Pow(10, t));
                t++;
            }
            Console.WriteLine(D);
            
            /*
            int count = 4;
            int[] numbers = new int[count];
        
            Console.Write("Напишите число: ");
            for (int i = 0; i < count; i++)
            {
                while (numbers[i] == 0)
                {
                    string input = Console.ReadLine();
                    int output;
                    if (int.TryParse(input, out output))
                    {
                        numbers[i] = output;
                        Console.Write("\n"+(count-1-i)+" еще раз: ");
                    }
                    else
                    {
                        Console.Write("\nПишите только числа: ");
                    }
                }
            }
        
            int result = 0;
            foreach (int number in numbers)
            {
                if (number.ToString().Length == 4 && number > result)
                {
                    result = number;
                }
            }
        
            Console.WriteLine("Число: "+result);


            ConsoleKeyInfo klik;
            do
            {
                klik = Console.ReadKey(true);
                Console.Beep();
            } while (klik.Key != ConsoleKey.Escape);
            Environment.Exit(0);
            */

        }
    }
}
