using System;
using NUnit.Framework;

namespace TravisCILab
{
    [TestFixture]
    public class Math
    {
        [Test]
        public void Add_Valid()
        {
            Assert.AreEqual(3, Program.Add("1", "2"));
            Assert.AreEqual(5, Program.Add("3", "2"));
            Assert.AreEqual(12, Program.Add("5", "7"));
        }

        [Test]
        public void Add_Invalid()
        {
            Assert.Throws<FormatException>(() => Program.Add("1", "a"));
            Assert.Throws<FormatException>(() => Program.Add("a", "1"));
            Assert.Throws<FormatException>(() => Program.Add("a", "a"));
        }

        [Test]
        public void Add_Null()
        {
            Assert.Throws<ArgumentNullException>(() => Program.Add("1", null));
            Assert.Throws<ArgumentNullException>(() => Program.Add(null, "1"));
            Assert.Throws<ArgumentNullException>(() => Program.Add(null, null));
        }

        // Implement 3 tests per operation, following a similar pattern as above
        [Test]
        public void Sub_ValidBrewer()
        {
            Assert.AreEqual(6, Program.Subtract("7", "1"));
            Assert.AreEqual(3, Program.Subtract("6", "3"));
            //intentional fail
            Assert.AreEqual(2, Program.Subtract("4", "3"));
        }
        
        [Test]
        public void Sub_InvalidBrewer()
        {
            Assert.Throws<ArgumentNullException>(() => Program.Subtract("1", null));
        }
        
        [Test]
        public void Sub_NullBrewer()
        {
            Assert.Throws<ArgumentNullException>(() => Program.Subtract("1", null));  
        }
    }
}
