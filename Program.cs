using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hesh
{
    class Program
    {
        static void Main(string[] args)
        {
            var init = new int[] { 7, 54, 20, 1, 45, 32, 10, 44 };

            var ht = new HashTable(5);


            foreach (var i in init)
                ht.Add(i);

            ht.Print();
            Console.WriteLine(ht.Count());
            Console.WriteLine(ht.Contains(7));
            Console.ReadKey();
        }
    }
}
