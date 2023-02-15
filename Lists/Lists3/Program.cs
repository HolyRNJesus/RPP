using System;
using System.Collections.Generic;
using System.Linq;

namespace Lists3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<List<string>> kon = new List<List<string>>();
            args = Console.ReadLine()!.Split('|');
            for (int i = 0; i < args.Length - 1; i++) {
                string elements = args[i];
                List<string> list1 = elements.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();
                kon.Add(list1);
            }

            for (int i = 0; i < kon.Count - 1; i++) {
                
            }
        }
    }
}