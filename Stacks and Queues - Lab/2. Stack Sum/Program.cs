using System;
using System.Linq;
using System.Collections.Generic;
using System.Collections;

namespace _2._Stack_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            Stack<int> stack = new Stack<int>(numbers);

            string command = Console.ReadLine().ToLower();

            while (command != "end")
            {

                var splitetd = command.Split(' ');

                if (splitetd[0] == "add")
                {
                    stack.Push(int.Parse(splitetd[1]));
                    stack.Push(int.Parse(splitetd[2]));
                }

                else if (splitetd[0] == "remove")
                {
                    int count = int.Parse(splitetd[1]);

                    if (count <= stack.Count)
                    {
                        for (int i = 0; i < count; i++)
                        {
                            stack.Pop();
                        }
                    }
                }

                command = Console.ReadLine().ToLower();
            }

            int sum = 0;
            while (stack.Count > 0)
            {
                sum += stack.Pop();
            }

            Console.WriteLine($"Sum: {sum}");
        }
    }
}
