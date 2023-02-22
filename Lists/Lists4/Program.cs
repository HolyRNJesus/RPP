using System;
using System.Collections.Generic;
using System.Linq;

namespace Lists4 {
    static class Program {
        static void Main() {
            List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();
            Console.WriteLine(string.Join(' ', input.Where(x => Math.Sqrt(x) % 1 == 0).OrderBy(x => x).Reverse()));
        }
    }
}