using AdventLibrary;
using NUnit.Framework;
using System.Collections.Generic;


namespace AdventTests
{
    [TestFixture]
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void findRow()
        {
            SeatAllocator allocator = new SeatAllocator();

            int row = allocator.FindRow("FBFBBFF");

            Assert.That(row, Is.EqualTo(44));
        }

        [Test]
        public void findColumn()
        {
            SeatAllocator allocator = new SeatAllocator();

            int column = allocator.FindColumn("RLR");

            Assert.That(column, Is.EqualTo(5));

        }

        [TestCase("FBFBBFFRLR", 357)]
        [TestCase("BFFFBBFRRR", 567)]
        [TestCase("FFFBBBFRRR", 119)]
        [TestCase("BBFFBBFRLL", 820)]
        public void getSeatId(string seatSpec, int expected)
        {
            SeatAllocator allocator = new SeatAllocator();

            int column = allocator.GetSeatId(seatSpec);

            Assert.That(column, Is.EqualTo(expected));
        }
    }
}