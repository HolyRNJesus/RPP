using System;
using System.Collections.Generic;
using System.Linq;

namespace Lists3 {
    static class Program {
        static void Main() {
            List<string> results = new();
            List<string> input = Console.ReadLine().Split('|',
                StringSplitOptions.RemoveEmptyEntries).ToList();
            
            for (int i = input.Count - 1; i >= 0; i--) {
                string[] elements = input[i].Split(' ', StringSplitOptions.RemoveEmptyEntries);
                results.AddRange(elements);
            }
            Console.WriteLine(string.Join(' ', results));
        }
    }
}