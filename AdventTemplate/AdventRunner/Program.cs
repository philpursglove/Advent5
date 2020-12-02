using AdventLibrary;
using System;
using System.Collections.Generic;
using System.IO;

namespace AdventRunner
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = new List<string>();

            using (FileStream stream = new FileStream("InputFile.txt", FileMode.Open))
            {
                using (StreamReader reader = new StreamReader(stream))
                {
                    while(!reader.EndOfStream)
                    {
                        input.Add(reader.ReadLine());
                    }
                }
            }

            Console.ReadLine();
        }
    }
}
