using System;
using System.IO;

class CopyBinaryFile
{
    static void Main()
    {
        string file = "../../duck.jpg";
        string copy = "../../duckCopy.jpg";
        using (var source = new FileStream(file, FileMode.Open))
        {
            using (var destination = new FileStream(copy, FileMode.Create))
            {
                var buffer = new byte[4096];
                while (true)
                {
                    int readBytes = source.Read(buffer, 0, buffer.Length);
                    if (readBytes == 0)
                    {
                        break;
                    }
                    destination.Write(buffer, 0, readBytes);
                    Console.WriteLine("{0:P}", source.Position / source.Length);
                }
            }
        }
    }
}

