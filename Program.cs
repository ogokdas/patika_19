using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patika_19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> L1 = new List<string>();
            L1.Add("Ahmet");
            L1.Add("Mehmet");
            string[] dizi = { "ömer", "veli", "deli" };
            L1.AddRange(dizi);
            L1.Remove("veli");
            //L1.Sort();
            L1.ForEach(i => Console.WriteLine(i)); // LINQ
            Console.WriteLine(L1.BinarySearch("deli"));
            
            
            Console.WriteLine(L1.IndexOf("ömer"));
            Console.ReadLine();

        }
    }
}
