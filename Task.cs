using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_CSharp
{
    class Task
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //1
            //List<int> list_ = new List<int>();
            //List<int> list_2 = new List<int>();
            //for (int i = 0; i < 5; i++)
            //{
            //    list_.Add(int.Parse(Console.ReadLine()));
            //}

            //int left_index = list_.Count - 1;
            //int right_index = 1;
            //int middle_index = 0;
            //while (middle_index < (list_.Count))
            //{
            //    list_2.Add(list_[left_index] + list_[right_index]);
            //    left_index += 1;
            //    right_index += 1;
            //    middle_index += 1;
            //    if (left_index == list_.Count)
            //    {
            //        left_index = 0;
            //    }
            //    if (right_index == list_.Count)
            //    {
            //        right_index = 0;
            //    }
            //}
            //Console.WriteLine();
            //foreach (int item in list_2)
            //{
            //    Console.Write(item + " ");
            //}
            //Console.ReadKey(true);


            //2
            //Random rnd = new Random();
            //int[] numbers = new int[20];
            //int[] numbers_2 = new int[20];
            //for (int i = 0; i < 20; i++)
            //{
            //    numbers[i] = rnd.Next(1, 20);
            //}
            //foreach (int itemas in numbers)
            //{
            //    Console.Write(itemas + " ");
            //}
            //Console.WriteLine();
            //int d = 0;
            //foreach (int item in numbers) 
            //{
            //    if (item/2==item/2+0.5)
            //    {
            //        numbers_2[d]=item;
            //    }
            //    d++;
            //}
            //foreach (int items in numbers_2)
            //{
            //    Console.Write(items + " ");
            //}


            //4
            Dictionary<string, string> linn = new Dictionary<string, string>();
            linn.Add("Valgamaa", "Valga");
            linn.Add("Harjumaa", "Tallinn");
            linn.Add("Saaremaa", "Saaremaa");
            linn.Add("Raplamaa", "Rapla");
            linn.Add("Laanemaa", "Haapsalu");
            while (true)
            {
                Console.WriteLine("1.Вывести словарь\n2.Поиск по уезду\n3.Добавить уезд и город в словарь");
                int answer = int.Parse(Console.ReadLine());
                Console.WriteLine();
                if (answer == 1)
                {
                    foreach (KeyValuePair<string, string> keyValue in linn)
                    {
                        Console.WriteLine(keyValue);
                    }
                }
                else if (answer == 2)
                {
                    Console.Write("Введите уезд-> ");
                    string slovo = Console.ReadLine();
                    string key = "";
                    if (linn.ContainsKey(slovo))
                    {
                        Console.WriteLine($"{slovo}-{linn[slovo]}");
                    }
                    //else if (linn.ContainsValue(slovo))
                    //{
                    //    foreach (var pair in linn)
                    //    {
                    //        key = pair.Key;

                    //    }
                    //    Console.WriteLine($"{slovo}-{key}");
                    //}

                }
                else if (answer == 3)
                {
                    Console.WriteLine("Введите уезд: ");
                    string yezd = Console.ReadLine();
                    Console.WriteLine("Введите город: ");
                    string gorod = Console.ReadLine();
                    linn.Add(yezd, gorod);
                }
                Console.WriteLine();

            }
        }
    }
}
