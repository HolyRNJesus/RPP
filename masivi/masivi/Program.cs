using System;

namespace masivi
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int[] arr = new int[num];
            for (int i = 0; i < num; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(OptionsManager.CountLess100(arr));
            Console.WriteLine(OptionsManager.MaxNum(arr));
            OptionsManager.PrintArray(OptionsManager.EvenNum(arr));
            Console.WriteLine(OptionsManager.EvenNumSum(arr));
            Console.WriteLine(OptionsManager.EvenNumCount(arr));
            OptionsManager.PrintArray(OptionsManager.ReverseArray(arr));
        }
    }
}
