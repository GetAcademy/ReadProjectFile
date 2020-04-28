using System;
using System.IO;

namespace ReadProjectFile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(File.ReadAllText("Assets/Textfiles/Textfile1.txt"));
        }
    }
}
