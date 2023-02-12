using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace masivi2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine()!.Split();

            args = Console.ReadLine()!.Split();
            while (args[0] != "END") {
                switch (args[0]) {
                    case "Reverse": {
                        int left = 0;
                        int right = arr.Length - 1;
                        while (left < right) {
                            (arr[left], arr[right]) = (arr[right], arr[left]); //swap
                            left++;
                            right--;
                        }
                        break;
                    }
                    case "Distinct": {
                        arr = arr.Distinct().ToArray();
                        break;
                    }
                    case "Replace": {
                        int index = int.Parse(args[1]);
                        if (index > arr.Length - 1 || index < 0) {
                            Console.WriteLine("Invalid Input");
                        }
                        else {
                            arr[index] = args[2];
                        }
                        break;
                    }
                    case "Print": {
                        StringBuilder sb = new();
                        foreach (var item in arr.Where(x => x.StartsWith(args[1]))) {
                            sb.Append(item + " ");
                        }
                        Console.WriteLine(sb.ToString());
                        break;
                    }
                }
                args = Console.ReadLine()!.Split();
            }
            Console.WriteLine(string.Join(", ", arr));
        }
    }
}
