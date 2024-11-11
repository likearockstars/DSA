using System;
using StackStructure;

namespace Stack
{
    class Stack
    {
        public static void Main()
        {
            
            StackStruct stack = new StackStruct(10);

            for(int i = 0; i < 3; i++)
            {
                stack.Push("Squirtle");
                stack.Push("Pikachu");
                stack.Push("Charmander");
            }

            stack.Pop();
            stack.Pop();

            while(!stack.isEmpty())
            {
                var var = stack.Pop();
                Console.WriteLine(var);
            }   

        }
    }
   
}