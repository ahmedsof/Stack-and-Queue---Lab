using System;
using System.Collections;
using System.Collections.Generic;

namespace _4._Matching_Brackets
{
    class Program
    {
        static void Main(string[] args)
        {
            string exspresion = Console.ReadLine();

            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < exspresion.Length; i++)
            {
                if (exspresion[i] == '(')
                {
                    stack.Push(i);

                }

                if (exspresion[i] == ')')
                {
                    int start = stack.Pop();
                    Console.WriteLine(exspresion.Substring(start, i - start + 1));


                }
            }

        }
    }
}
