using System;
using System.IO;

namespace FileIOOpdracht
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Creating File.");

            string[] text = new string[]
            {
                "Dit is een nieuwe tekstbestand",
                "dat is aangemaakt via de Console."
            };
            File.WriteAllLines(@"E:\! School\Leerjaar 1\L1P4\F2M4GD\consoleMon\FileIOOpdracht\FileIOOpdracht\txt.txt", text);

            Console.WriteLine("File created.\n\n");
            Console.WriteLine("Reading File.\n\n");


            foreach (string word in File.ReadLines(@"E:\! School\Leerjaar 1\L1P4\F2M4GD\consoleMon\FileIOOpdracht\FileIOOpdracht\txt.txt"))
            {
                System.Console.WriteLine(word);
            }

            Console.ReadLine();
        }
    }
}
