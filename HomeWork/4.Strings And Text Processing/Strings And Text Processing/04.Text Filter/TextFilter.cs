using System;
using System.Text;

class TextFilter
{
    static void Main()
    {
        string[] bannWords = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
        StringBuilder input = new StringBuilder(Console.ReadLine());
        foreach (string bannWord in bannWords)
        {
            string mask = new string('*', bannWord.Length);
            input.Replace(bannWord, mask);
        }
        Console.WriteLine(input);
    }
}
