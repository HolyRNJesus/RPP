using System;
using System.Collections.Generic;
using System.Linq;

namespace Lists5 {
    static class Program {
        static void Main() {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            string[] cmd = Console.ReadLine().Split();
            while (true) {
                if (cmd[0] == "print") {
                    Console.WriteLine('[' + string.Join(", ", nums) + ']');
                    break;
                }
                switch (cmd[0]) {
                    case "add": //works
                        nums.Insert(int.Parse(cmd[1]), int.Parse(cmd[2]));
                        break;
                    
                    case "addMany": //works
                        int[] elements = cmd.Skip(1).Select(int.Parse).ToArray();
                        nums.InsertRange(elements[0], elements.Skip(1));
                        break;
                    
                    case "contains": //works
                        int num = int.Parse(cmd[1]);
                        Console.WriteLine(nums.Contains(num) ? nums.IndexOf(num) : -1);
                        break;
                    
                    case "remove": //works
                        nums.RemoveAt(int.Parse(cmd[1]));
                        break;
                    
                    case "sumPairs": //works
                        for (int i = 0; i < nums.Count - 1; i++) {
                            nums[i] += nums[i + 1];
                            nums.RemoveAt(i + 1);
                        }
                        break;
                    
                    case "shift": //TODO
                        break;
                }
                cmd = Console.ReadLine().Split();
            }
        }
    }
}