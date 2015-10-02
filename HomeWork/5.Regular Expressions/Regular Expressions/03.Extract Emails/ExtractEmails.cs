using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class ExtractEmails
{
    static void Main()
    {


        string input = Console.ReadLine();
        Regex rgx = new Regex(@"(\w*[-._]*\w+)([-.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*");
        Match match = rgx.Match(input);
        List<string> emails = new List<string>();

        while (match != Match.Empty)
        {
            string email = match.Value;
            if ((email[0] != '.') && (email[0] != '-') && (email[0] != '_'))
            {
                emails.Add(email);
            }
            match = match.NextMatch();
        }

        foreach (string e in emails)
        {
            Console.WriteLine(e);
        }
    }
}
