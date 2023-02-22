using System;
using System.Collections.Generic;
using System.Linq;

namespace Lists6
{
    static class Program
    {
        static void Main()
        {
            //input: Learn programming at CodeCamp: Java, PHP, JS, HTML 5, CSS, Web, C#, SQL, databases, AJAX, etc.
            char[] separators = { ',', ';', ':', '.', '!', '(', ')', '\"', '\'', '\\', '/', '[', ']', ' ' };
            List<string> words = Console.ReadLine().Split(separators, StringSplitOptions.RemoveEmptyEntries).ToList();

            List<string> lowerCaseWords = new();
            List<string> mixedCaseWords = new();
            List<string> upperCaseWords = new();

            foreach (var item in words) {
                if (item == item.ToLower()) {
                    lowerCaseWords.Add(item);
                }
                else if (item == item.ToUpper()) {
                    upperCaseWords.Add(item);
                }
                else {
                    mixedCaseWords.Add(item);
                }
            }

            Console.WriteLine("Lower-case: " + string.Join(", ", lowerCaseWords));
            Console.WriteLine("Mixed-case: " + string.Join(", ", mixedCaseWords));
            Console.WriteLine("Upper-case: " + string.Join(", ", upperCaseWords));
        }
    }
}