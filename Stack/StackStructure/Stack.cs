using System;
using System.ComponentModel.DataAnnotations;

namespace StackStructure
{
    class StackStruct
    {
            public int MaxSize; //Array stacks you need a maxsize to init array
            public string[] stackArray; //This holds our array
            public int top; //This keeps track of the top

            public StackStruct(int size)
            {
                //This holds constructor value
                this.MaxSize = size;
                //Create array and new up size
                stackArray = new string[MaxSize];
                //We give the top -1 because array is zero index; If we don't it will skip the first element
                this.top = -1;

            }
            
            public void Push(string item) //Putting data
            {
                top++;
                stackArray[top] = item;
            }

            public string Pop() //Removing an item
            {
                //Placeholder
                int old_top = top;
                //Decrement for the new top
                top--;
                return stackArray[top];
            }

            public string Peek()
            {
                return stackArray[top];
            }

            public bool isEmpty()
            {
                return top == 0;
            }

            public bool isFull()
            {
                return (MaxSize - 1 == top);
            }
    }
}