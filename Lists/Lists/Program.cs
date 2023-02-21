using System;
using System.Collections.Generic;
using System.Linq;

namespace Lists {
    static class Program {
        static void Main() {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            Console.WriteLine(string.Join(' ', nums.Where(x => x != nums[^1])));
        }
    }
}