using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _3._Simple_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] exspresion = Console.ReadLine().Split(' ').Reverse().ToArray();

            Stack<string> stack = new Stack<string>(exspresion);

            while (stack.Count > 1)
            {
                //PrintStack();
                int first = int.Parse(stack.Pop());
                string sign = stack.Pop();
                int second = int.Parse(stack.Pop());

                switch (sign)
                {
                    case "+":
                        stack.Push((first + second).ToString());
                        break;
                    case "-":
                        stack.Push((first - second).ToString());
                        break;
                        
                }
            }

            Console.WriteLine(stack.Pop());
        }

        static void PrintStack(Stack<string> stack)
        {
            foreach (var item in stack)
            {



                Console.Write(item);
            }

            Console.WriteLine();

        }
    }
}
