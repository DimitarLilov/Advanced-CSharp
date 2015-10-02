using System;
using System.Collections.Generic;
using System.Linq;

class Phonebook
{


    static void Main()
    {
        Dictionary<string, string> phonebook = new Dictionary<string, string>();
        string[] input = Console.ReadLine().Split('-') ;
        while (input[0] != "search")
        {
            string name = input[0];
            string phoneNumber = input[1];
            if (phonebook.Keys.Contains(name))
            {
                phonebook[name] = phonebook[name] + " , " + phoneNumber;
            }
            else
            {
                phonebook.Add(name, phoneNumber);
            }
            input = Console.ReadLine().Split('-');
        }
        input = Console.ReadLine().Split();
        while (!input.Equals(String.Empty))
        {
            if (phonebook.Keys.Contains(input[0]))
            {
                Console.WriteLine("{0} -> {1}", input[0], phonebook[input[0]]);
            }
            else
            {
                Console.WriteLine("Contact {0} does not exist.", input);
            }
            input = Console.ReadLine().Split();
        }
    }
}

