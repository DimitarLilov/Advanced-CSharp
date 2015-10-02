using System;
using System.IO;

class LineNumbers
{
    static void Main()
    {

        StreamReader reader = new StreamReader("../../LineNumbers.cs");
        StreamWriter writer = new StreamWriter("../../Line Numbers copy.cs");
        using (reader)
        {
            using (writer)
            {
                int lineNumber = 0;
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    lineNumber++;
                    string writeLine = string.Format("Line {0}: {1}", lineNumber, line);
                    writer.WriteLine(writeLine);
                }
            }
        }
    }
}
