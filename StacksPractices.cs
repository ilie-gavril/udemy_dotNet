using System;
using System.Collections.Generic;

namespace Udemy_dotNet
{
    public class StacksPractices
    {
        public static void Run()
        {
            Stack<int> stack = new Stack<int>();
            //add elements

            stack.Push(1);
            stack.Push(132);
            stack.Push(523);
            stack.Push(243);
            stack.Push(123);

            //while(stack.Count > 0)
            //{
            //    Console.WriteLine("Top value in the stack is {0}", stack.Peek());
            //    stack.Pop();
            //}

            //Console.WriteLine(stack.Count);

            int[] numbers = new int[] { 1, 2, 4, 5, 6, 7 };

            Stack<int> numbersStack = new Stack<int>();

            foreach (int number in numbers)
            {
                Console.Write(number + " ");
                numbersStack.Push(number);
            }
            Console.WriteLine("\nReversed array:");
            while(numbersStack.Count > 0)
            {
                Console.Write(numbersStack.Peek() + " ");
                numbersStack.Pop();
            }



        }
    }
}
