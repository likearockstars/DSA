using System;
using System.Runtime.CompilerServices;

namespace Queuee
{
    class Queue
    {
        public int MaxSize; //Sets the number of elements because this is an array
        public int[] QueueArray; //Actual array we will store elements in
        public int Front; //Index to keep track of front
        public int Rear; //Index to keep track of adds
        public int NItems; //This will keep track of the length

        public Queue(int size)
        {
            this.MaxSize = size;
            this.QueueArray = new int[size];
            Front = 0;
            Rear = -1;
        }

        //Somebody is going into chik fila line
        public void Enqueue(int item)
        {
            //Increment our pointer
            Rear++;
            Rear = (Rear + 1) % MaxSize;
            //Insert into where the rear was incremented
            QueueArray[Rear] = item;
            //Increment
            NItems++;
        }

        public int Dequeue()
        {
            int temp = QueueArray[Front];
            Front++;
            if(Front == MaxSize)
            {
                Front = 0;
            }
            NItems--;
            return temp;
        }

        public int Peek()
        {
            return QueueArray[Front];
        }


    }
}