using System;
using HashTab;

namespace HashTable
{
    class HashTable
    {
        public static void Main()
        {
            //It works like an array that keeps 2 types of data, the value and the key
            //Disadvantage - Collusions and Load Factor

            HashT hasTable = new HashT();

            hasTable.Set("Carlos", "621111");
            hasTable.Set("Leo", "621111");
            hasTable.Set("Murilo", "621111");

            Console.WriteLine(hasTable.Get("Carlos"));
            Console.WriteLine(hasTable.Get("Leo"));
            Console.WriteLine(hasTable.Get("Murilo"));

            Console.ReadLine();

        }
    }
}