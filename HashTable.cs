using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hesh
{
    class HashTable
    {
        List<int>[] table;
        public HashTable(int n)
        {
            table = new List<int>[n];
            for (int i = 0; i < n; i++)
            {
                table[i] = new List<int> { };
            }
        }

        public void Add(int key)
        {
            int index = key % table.Length;
            table[index].Add(key);
        }

        public void Print()
        {
            for (int i = 0; i < table.Length; i ++)
            {
                Console.Write(i);
                Console.Write("  ");
                for (int j = 0; j < table[i].Count; j++)
                {
                    Console.Write(table[i][j] + " ");
                }
                Console.WriteLine();
            }
        }

        public bool Contains(int key)
        {
            bool flag = false;
            for (int i = 0; i < table.Length; i++)
                for (int j = 0; j < table[i].Count; j++)
                {
                    if (table[i][j] == key)
                    flag = true;
                }
            return flag;
        }

        public int Count()
        {
            int k = 0;
            for (int i = 0; i < table.Length; i++)
                for (int j = 0; j < table[i].Count; j++)
                    k++;
            return k;
        }
    }
}
