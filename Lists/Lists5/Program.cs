using System;
using System.Collections.Generic;
using System.Linq;

namespace Lists5 {
    static class Program {
        static void Main() {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            
            while (true) {
                string[] cmd = Console.ReadLine().Split();
                if (cmd[0] == "print") {
                    Console.WriteLine('[' + string.Join(", ", nums) + ']');
                    break;
                }

                switch (cmd[0]) {
                    case "add":
                        nums.Insert(int.Parse(cmd[1]), int.Parse(cmd[2]));
                        break;
                    case "addMany": {
                        int[] elements = cmd.Skip(1).Select(int.Parse).ToArray();
                        nums.InsertRange(elements[0], elements.Skip(1));
                        break;
                    }
                    case "contains": {
                        int num = int.Parse(cmd[1]);
                        Console.WriteLine(nums.Contains(num) ? nums.IndexOf(num) : -1);
                        break;
                    }
                    case "remove":
                        nums.RemoveAt(int.Parse(cmd[1]));
                        break;
                    case "sumPairs": {
                        for (int i = 0; i < nums.Count - 1; i++) {
                            nums[i] += nums[i + 1];
                            nums.RemoveAt(i + 1);
                        }
                        break;
                    }
                    case "shift": {
                        int shifts = int.Parse(cmd[1]);
                        for (int i = shifts; i < nums.Count; i++) {
                            nums[i - shifts] = nums[i];
                        }
                        break;
                    }
                }
            }
        }
    }
}