using System;

namespace BubbleSort
{
    class BubbleSort
    {
        public static void Main()
        {
            int[] array = {2, 10, 50, 28, 13, 100, 97, 29, 1, 5};

            for(int i = 0; i < 10; i++)
            {
                for(int j = 0; j < 9; j++)
                {
                    if(array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }

            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine(array[i]);
            }
            
            Console.ReadLine();
        }
    }
}