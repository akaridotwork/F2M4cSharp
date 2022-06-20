using System;
using System.IO;

namespace StringSplits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string file = File.ReadAllText(@"E:\! School\Leerjaar 1\L1P4\F2M4GD\cSharp\cSharp2Opdrachten\StringSplits\Files\stringsplit.txt");
            string value = file.Replace(" ", "");
            string[] text = value.Split(':', ',');

            for (int i = 0; i < text.Length; i++)
            {
                Console.WriteLine(text[i]);
            }
        }
    }
}
