using System;

namespace BinarySearch
{
    class BinarySearch
    {
        public static void Main()
        {
            //In a binary search, you're always searching the mid point
            //It always have a Start and an End
            int[] array = {-22, -15, 2, 7, 20, 30, 54};

            
            Console.WriteLine(BinarySearchh(array, 54));
            Console.ReadLine();
            
        }
        public static int BinarySearchh(int[] array, int value)
            {
                int start = 0;
                int end = array.Length;
                //Important to say, the start and end always are the array position, it doesn't restart,
                //that means that even if u make the new mid point, the start won't start at 0
                //start end + while less than is going criss crossing
                while(start < end)
                {
                    //Put in parenthensis because add them incorrect
                    int midPoint = (start + end) / 2;

                    //Search the middle of the book
                    if(array[midPoint] == value)
                    {
                        return midPoint;
                    }
                    else if(array[midPoint] < value)
                    {
                        start = midPoint + 1;
                    }
                    else
                    {
                        end = midPoint;
                    }
                }

                return -1;
            }
    }
}