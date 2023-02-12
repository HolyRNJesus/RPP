using System;
using System.Linq;

namespace masivi2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string[] arr = Console.ReadLine()!.Split().ToArray();

            args = Console.ReadLine()!.Split();
            while (args[0] != "END") {
                switch (args[0]) {
                    case "Reverse": {
                        arr = arr.Reverse().ToArray();
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
                        Console.WriteLine(string.Join(" ", arr.Where(x => x.StartsWith(args[1]))));
                        break;
                    }
                }
                args = Console.ReadLine()!.Split();
            }
            Console.WriteLine(string.Join(", ", arr));
        }
    }
}
