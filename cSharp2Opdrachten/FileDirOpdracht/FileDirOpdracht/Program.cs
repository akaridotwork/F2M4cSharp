using System;
using System.IO;


namespace FileDirOpdracht
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo userDir = new DirectoryInfo("/Users/jah.sanches/Desktop/Ma/Periode3");

            foreach (var i in userDir.GetFiles())
            {
                Console.WriteLine(i.Name);

            }

            



        }
    }
}
