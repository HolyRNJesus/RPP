using System;
using System.Collections.Generic;
using System.Linq;

namespace Lists
{
    class Program
    {
        static void Main()
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            int index = nums[^1];
            Console.WriteLine(string.Join(" ", nums.Where(x => x != index)));
        }
    }
}