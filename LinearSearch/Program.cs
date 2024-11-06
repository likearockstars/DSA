using System;
using System.Data;

namespace LinearSearch
{
    class LinearSearch
    {
        public static void Main()
        {
            int[] array = {1, 2, 3, 4};

        
            Console.WriteLine(Search(array, 2));
            Console.ReadLine();
        
        }
        static bool Search(int[] array, int key)
        {
            for(int i = 0; i < array.Length; i++)
            {
                if(array[i] == key)
                {
                    return true;
                }
            }
            return false;
        }
    }
}