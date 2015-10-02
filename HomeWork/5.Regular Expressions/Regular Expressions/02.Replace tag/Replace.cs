using System;
using System.Text.RegularExpressions;

class Replace
{
    static void Main()
    {
        string input = Console.ReadLine();
        string pattern = @"<a.*href=((?:.|\n)*?(?=>))>((?:.|\n)*?(?=<))<\/a>";
        string replace = @"[URL href=$1]$2[/URL]";
        string replaced = Regex.Replace(input, pattern, replace);
        Console.WriteLine(replaced);

    }
}

