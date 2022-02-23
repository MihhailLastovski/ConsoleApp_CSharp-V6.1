using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.OutputEncoding = Encoding.UTF8;
            double hind = 15;
            string p_tuup = "täis";
            Console.WriteLine("Hello world!!! Mis on sinu nimi?");
            Console.Title = "ZXC";
            string nimi = Console.ReadLine();
            char[] tahed = nimi.ToCharArray();
            int i = 0;
            nimi = "";
            string n2, n3;
            double a, b;
            foreach (var t in tahed)
            {
                if (i == 0) 
                {
                    nimi += t.ToString().ToUpper();

                }
                else
                {
                    nimi += t.ToString().ToLower();
                }
                i++;
            }
            Console.WriteLine("Tere {0}",nimi);
            if (nimi.ToUpper()=="GHOUL?" || nimi.ToLower()=="zxc?")
            {
                
                Console.WriteLine($"Tule külla! {nimi} Kas tahad kinno?");
                string vastus = Console.ReadLine();
                if (vastus.ToLower()=="jah" || vastus.ToLower()=="да")
                {
                    Console.WriteLine("how old are u?");
                    int vanus = int.Parse(Console.ReadLine());
                    if (vanus <= 0 || vanus > 109)
                    {
                        Console.WriteLine("Viga");
                    }
                    else
                    {
                        if (vanus > 0 && vanus < 6)
                        {
                            hind = 0;
                            p_tuup = "tasuta";

                        }
                        else if (vanus >= 6 && vanus <= 14)
                        {
                            hind = hind - (hind * 0.35);
                            p_tuup = "lastepilet";
                        }
                        else if (vanus >= 15 && vanus <= 65)
                        {
                            
                            p_tuup = "täispilet";

                        }
                        else if (vanus >65)
                        {
                            hind = hind - (hind * 0.4);
                            p_tuup = "soduspilet";

                        }
                        Console.WriteLine($"{nimi}, sul on {p_tuup} vaja maksta {hind}");

                    }
                }
                else
                {
                    Console.WriteLine("Daammmm");
                }
            }
            else
            {
                Console.WriteLine("Täna ma olen hõivatud!");
            }



            //1
            Console.WriteLine("Mis on sinu nimi?");
            n2 = Console.ReadLine();
            Console.WriteLine("Mis on sinu nimi?");
            n3 = Console.ReadLine();
            if ((n2=="mihhail" &&n3=="marco")|| (n3 == "mihhail" && n2 == "marco")|| (n3 == "ed" && n2 == "marco")|| (n2 == "ed" && n3 == "marco")||(n2=="er"&&n3=="vl")|| (n3 == "er" && n2 == "vl")||(n2=="a"&&n3=="a")||(n2=="a"&&n3=="d")||(n3 == "a" && n2 == "d")||(n2=="al"&&n3=="e")|| (n3 == "al" && n2 == "e"))
            {
                Console.WriteLine("Te olete pinginaabdrid");
            }
            else
            {
                Console.WriteLine("(((");
            }
            



            //2
            Console.WriteLine("Какова длина пола?");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Какова ширина пола?");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Хотите ли вы сделать ремонт?");
            string vastus = Console.ReadLine();
            if (vastus=="yes")
            {
                Console.WriteLine("Cколько стоит квадратный метр?");
                float metr = float.Parse(Console.ReadLine());
                double price = a * b * metr;
                Console.WriteLine($"Цена замены пола {price}");
            }
            else
            {
                Console.WriteLine("Ну ладно");
            }
            



            //3
            Console.WriteLine("Цена со скидкой:");
            double price_1 = Convert.ToDouble(Console.ReadLine());
            double price_2 = price_1 * 100 / 70;
            Console.WriteLine($"Изначальная цена: {price_2}");
            


            //4
            Console.WriteLine("Какова температура воздуха в комнате?");
            double temp = Convert.ToDouble(Console.ReadLine());
            if (temp < 18)
            {
                Console.WriteLine("В комнате холодно");
            }
            else if (temp>28)
            {
                Console.WriteLine("В комнате жарко");
            }
            else
            {
                Console.WriteLine("В комнате нормальная температура");
            }
            


            //5
            Console.WriteLine("Какой у вас рост?");
            double rost = Convert.ToDouble(Console.ReadLine());
            if (rost < 156)
            {
                Console.WriteLine("Вы низкий");
            }
            else
            {
                Console.WriteLine("Вы высокий");
            }
            



            //6
            Console.WriteLine("Какого вы пола?");
            string m_f = Console.ReadLine();
            if (m_f.ToLower()=="женщина"|| m_f.ToLower() == "женский" || m_f.ToLower() == "женского")
            {
                Console.WriteLine("Какой у вас рост?");
                double rost = Convert.ToDouble(Console.ReadLine());
                if (rost < 150)
                {
                    Console.WriteLine("Вы низкая");
                }
                else if (rost>=150||rost<170)
                {
                    Console.WriteLine("У вас средний рост");
                }
                else
                {
                    Console.WriteLine("Вы высокая");
                }
            }
            else if (m_f.ToLower() == "мужчина" || m_f.ToLower() == "мужской" || m_f.ToLower() == "мужского")
            {
                Console.WriteLine("Какой у вас рост?");
                double rost = Convert.ToDouble(Console.ReadLine());
                if (rost < 160)
                {
                    Console.WriteLine("Вы низкий");
                }
                else if (rost >= 160 || rost < 180)
                {
                    Console.WriteLine("У вас средний рост");
                }
                else
                {
                    Console.WriteLine("Вы высокий");
                }
            }
            else
            {
                Console.WriteLine("Вы неправильно написали");
            }
           




            //7
            double fullprice = 0;
            Console.WriteLine("Хотите ли вы купить молоко?");
            string vastus_1 = Console.ReadLine().ToLower();
            Console.WriteLine("Хотите ли вы купить булку?");
            string vastus_2 = Console.ReadLine().ToLower();
            Console.WriteLine("Хотите ли вы купить хлеб?");
            string vastus_3 = Console.ReadLine().ToLower();
            if (vastus_1=="да")
            {
                fullprice += 1.5;
            }
            else if (vastus_2 == "да")
            {
                fullprice += 1.2;
            }
            else if (vastus_3 == "да")
            {
                fullprice += 0.9;
            }
            else
            {
                Console.WriteLine("Ну ладно");
            }
            Console.WriteLine($"Это все будет стоить {fullprice} евро");
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
