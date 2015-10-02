using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SortedSubsetSums
{
    static List<List<int>> subsets = new List<List<int>>();
    static int counter = 0;
    static int n;
    static int[] numbers;
    static void Main()
    {
        n = int.Parse(Console.ReadLine());
        string input = Console.ReadLine();
        numbers = input.Split().Select(int.Parse).Distinct().ToArray();
        Array.Sort(numbers);
        List<int> subset = new List<int>();
        Make(0, subset);
        var sorted = subsets.OrderBy(x => x.Count);
        foreach (var i in sorted)
        {
            Console.WriteLine("{0} = {1}", string.Join(" + ", i), n);
        }
        if (counter == 0)
        {
            Console.WriteLine("No matching subsets.");
        }
    }
    static void Make(int index, List<int> subset)
    {
        if (subset.Sum() == n && subset.Count > 0)
        {
            subsets.Add(new List<int>(subset));
            counter++;
        }
        for (int i = index; i < numbers.Length; i++)
        {
            subset.Add(numbers[i]);
            Make(i + 1, subset);
            subset.RemoveAt(subset.Count - 1);
        }
    }

}

