using System;
using System.Collections.Generic;
using System.Linq;

namespace Lists2 {
    static class Program {
        static void Main() {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).Where(x => x >= 0).Reverse().ToList();
            Console.WriteLine(nums.Count == 0 ? "Empty" : string.Join(' ', nums));
        }
    }
}