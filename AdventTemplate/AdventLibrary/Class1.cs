using System;
using System.Linq;
using System.Collections.Generic;

namespace AdventLibrary
{
    public class SeatAllocator
    {
        public int FindRow(string rowsSpecifier)
        {
            List<int> rows = new List<int>(128);

            for (int i = 0; i < 128; i++)
            {
                rows.Add(i);
            }

            foreach (char letter in rowsSpecifier)
            {
                switch(letter)
                {
                    case 'F':
                        rows = rows.GetRange(0, rows.Count / 2);
                        break;
                    case 'B':
                        rows = rows.GetRange(rows.Count / 2, rows.Count / 2);
                        break;
                }
            }

            return rows.First();
        }

        public int FindColumn(string columnsSpecifier)
        {
            List<int> columns = new List<int>(8);

            for (int i = 0; i < 8; i++)
            {
                columns.Add(i);
            }

            foreach (char letter in columnsSpecifier)
            {
                switch (letter)
                {
                    case 'L':
                        columns = columns.GetRange(0, columns.Count / 2);
                        break;
                    case 'R':
                        columns = columns.GetRange(columns.Count / 2, columns.Count / 2);
                        break;
                }
            }

            return columns.First();
        }

        public int GetSeatId(string seatSpecifier)
        {
            string rowSpec = seatSpecifier.Substring(0, 6);
            string seatSpec = seatSpecifier.Substring(7, 3);

            int row = FindRow(rowSpec);
            int seat = FindColumn(seatSpec);

            return (row * 8) + seat;
        }
    }
}
