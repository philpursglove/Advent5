using AdventLibrary;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

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

            List<int> seatIds = new List<int>();

            SeatAllocator allocator = new SeatAllocator();

            foreach (string seatSpec in input)
            {
                seatIds.Add(allocator.GetSeatId(seatSpec));
            }

            // Part 1
            //Console.WriteLine(seatIds.Max());

            seatIds = seatIds.OrderBy(i => i).ToList();

            //foreach(int seatId in seatIds)
            //{
            //    Console.WriteLine(seatId);
            //}

            for (int i = seatIds.Min(); i < seatIds.Max(); i++)
            {
                if (!seatIds.Contains(i) && seatIds.Contains(i - 1) && seatIds.Contains(i + 1))
                {
                    Console.WriteLine(i);
                }
            }

            Console.ReadLine();
        }
    }
}
