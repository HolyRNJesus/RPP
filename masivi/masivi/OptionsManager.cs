using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace masivi
{
    class OptionsManager
    {
        public static int CountLess100(int[] arr)
        {
            return arr.Count(x => x < 100);
        }
        public static int MaxNum(int[] arr)
        {
            return arr.Max();
        }
        public static int[] ReverseArray(int[] arr)
        {
            return arr.Reverse().ToArray();
        }
        public static void PrintArray(int[] arr)
        {
            Console.WriteLine(string.Join(", ", arr));
        }
        public static int EvenNumCount(int[] arr)
        {
            return arr.Count(x => x % 2 == 0);
        }
        public static int EvenNumSum(int[] arr)
        {
            arr = arr.Where(x => x % 2 == 0).ToArray();
            return arr.Sum();
        }
        public static int[] EvenNum(int[] arr)
        {
            return arr.Where(x => x % 2 == 0).ToArray();
        }
    }
}
