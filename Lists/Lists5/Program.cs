using System;
using System.Collections.Generic;
using System.Linq;

namespace Lists5 {
    static class Program {
        static void Main() {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();

            int changesCounter = 0;
            while (true) {
                string[] cmd = Console.ReadLine().Split();
                if (cmd[0] == "end") {
                    if (changesCounter != 0) {
                        Console.WriteLine('[' + string.Join(", ", nums) + ']');
                    }
                    break;
                }

                switch (cmd[0]) {
                    case "add":
                        nums.Insert(int.Parse(cmd[1]), int.Parse(cmd[2]));
                        changesCounter++;
                        break;
                    case "addMany": {
                        int[] elements = cmd.Skip(1).Select(int.Parse).ToArray();
                        nums.InsertRange(elements[0], elements.Skip(1));
                        changesCounter++;
                        break;
                    }
                    case "contains": {
                        int num = int.Parse(cmd[1]);
                        changesCounter++;
                        Console.WriteLine(nums.Contains(num) ? nums.IndexOf(num) : -1);
                        break;
                    }
                    case "remove":
                        nums.RemoveAt(int.Parse(cmd[1]));
                        changesCounter++;
                        break;
                    case "sumPairs": {
                        for (int i = 0; i < nums.Count - 1; i++) {
                            nums[i] += nums[i + 1];
                            nums.RemoveAt(i + 1);
                        }
                        changesCounter++;
                        break;
                    }
                    case "shift": {
                        int shifts = int.Parse(cmd[1]);
                        for (int i = shifts; i < nums.Count; i++) {
                            nums[i - shifts] = nums[i];
                        }
                        changesCounter++;
                        break;
                    }
                    
                    case "Contains":
                        int element = int.Parse(cmd[1]);
                        Console.WriteLine(nums.Contains(element) ? "Yes" : "No such number");
                        break;
                    case "PrintEven":
                        Console.WriteLine(string.Join(' ', nums.Where(x => x % 2 == 0)));
                        break;
                    case "PrintOdd":
                        Console.WriteLine(string.Join(' ', nums.Where(x => x % 2 != 0)));
                        break;
                    case "GetSum":
                        Console.WriteLine(nums.Sum());
                        break;
                    case "Filter":
                        switch (cmd[1]) {
                            case ">":
                                Console.WriteLine(string.Join(' ', nums.FindAll(x => x > int.Parse(cmd[2]))));
                                break;
                            case "<":
                                Console.WriteLine(string.Join(' ', nums.FindAll(x => x < int.Parse(cmd[2]))));
                                break;
                            case ">=":
                                Console.WriteLine(string.Join(' ', nums.FindAll(x => x >= int.Parse(cmd[2]))));
                                break;
                            case "<=":
                                Console.WriteLine(string.Join(' ', nums.FindAll(x => x <= int.Parse(cmd[2]))));
                                break;
                        }
                        break;
                }
            }
        }
    }
}