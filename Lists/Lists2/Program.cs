using System;
using System.Collections.Generic;
using System.Linq;

namespace Lists2
{
    class Program
    {
        static void Main()
        {
            List<int> nums = Console.ReadLine()!.Split().Select(int.Parse).ToList();
            for (int i = 0; i < nums.Count - 1; i++) {
                if (nums[i] < 0) {
                    nums.Remove(nums[i]);
                    i--;
                }
            }

            if (nums.Count - 1 == 0) {
                Console.WriteLine("Empty");
            }
            else {
                for (int i = nums.Count - 1; i >= 0; i--) {
                    Console.Write($"{nums[i]} ");
                }
            }
            
        }
    }
}