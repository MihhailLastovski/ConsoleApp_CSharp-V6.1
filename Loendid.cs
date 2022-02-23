using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_CSharp
{
    class Loendid
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> opilased = new Dictionary<int, string>(6);
            opilased.Add(74587, "Mihhail");
            opilased.Add(74588, "Aleksandr");
            opilased.Add(74589, "Edgar");
            opilased.Add(74590, "Mark");
            opilased.Add(74591, "Daniil");
            opilased.Add(74564, "Alina");
            string nimi = opilased[74588];
            opilased[74588] = "Aleksander";
            foreach (KeyValuePair<int,string> keyValue in opilased)
            {
                Console.WriteLine(keyValue);
            }
            Console.WriteLine();
            LinkedList<string> loetelu = new LinkedList<string>();
            loetelu.AddLast("Kass");
            loetelu.AddLast("Koer");
            loetelu.AddFirst("Hund");
            LinkedList<string>.Enumerator ahel = loetelu.GetEnumerator();
            while (ahel.MoveNext())
            {
                Console.WriteLine(ahel.Current);
            }
            Console.WriteLine();
            List<inimesed> Inimesed = new List<inimesed>();
            Inimesed.Add(new inimesed() { Nimi = "Mati" });
            Inimesed.Add(new inimesed() { Nimi = "Kati" });
            Inimesed.Add(new inimesed() { Nimi = "Mark" });
            foreach (inimesed inimene in Inimesed)
            {
                Console.WriteLine(inimene.Nimi);
            }
            Console.WriteLine();
            List<int> numbrid = new List<int>();
            numbrid.Add(100);
            for (int i = 0; i < 9; i++)
            {
                numbrid.Add(i + 1);
            }
            int n = numbrid.Count();
            foreach (int num in numbrid)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine();
            int v = int.Parse(Console.ReadLine());
            if (numbrid.Contains(v))
            {
                Console.WriteLine($"{v} on olemas loendis");
            }
            else
            {
                Console.WriteLine($"{v} ei ole olemas loendis");
            }
            Console.ReadKey(true);

        }

    }
}
