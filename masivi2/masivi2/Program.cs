using System;
using System.Linq;

namespace masivi2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string[] arr = Console.ReadLine().Split().ToArray();

            int num = int.Parse(Console.ReadLine());
            for (int i = 0; i < num; i++)
            {
                args = Console.ReadLine().Split();
                if (args[0] == "Reverse")
                {
                    arr = arr.Reverse().ToArray();
                }
                else if (args[0] == "Distinct")
                {
                    arr = arr.Distinct().ToArray();
                }
                else if (args[0] == "Replace")
                {
                    int index = int.Parse(args[1]);
                    arr[index] = args[2];
                }
                else if (args[0] == "Print")
                {
                    Console.WriteLine(string.Join(" ", arr.Where(x => x.StartsWith(args[1]))));
                }   
            }
            Console.WriteLine(string.Join(", ", arr));
        }
    }
}
