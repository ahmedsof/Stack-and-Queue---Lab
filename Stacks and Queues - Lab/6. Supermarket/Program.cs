﻿using System;
using System.Collections;
using System.Collections.Generic;

namespace _6._Supermarket
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();

            Queue<string> queue = new Queue<string>();

            while (name != "End")
            {
                if (name == "Paid")
                {
                    foreach (var item in queue)
                    {
                        Console.WriteLine(item);
                    }
                    queue.Clear();
                    
                }
                else
                {
                    queue.Enqueue(name);
                }

                name = Console.ReadLine();

            }

            Console.WriteLine($"{queue.Count} people remaining.");
            
        }
    }
}
