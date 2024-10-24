using System;
using System.IO;
class FileLineReader
{
    public static void Main()
    {
        string filePath = @"D:\INPUT.TXT";
        if (!File.Exists(filePath))
        {
            Console.WriteLine("File does not exist :{0} ", filePath);
            return;
        }

        string[] textFromFile = File.ReadAllLines(filePath);
        foreach (string line in textFromFile)
        {
            Console.WriteLine(line);
        }
    }
}