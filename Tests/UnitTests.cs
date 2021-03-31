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
            Assert.AreEqual(1, Program.Subtract("4", "3"));
        }
        
        [Test]
        public void Sub_InvalidBrewer()
        {
            Assert.Throws<FormatException>(() => Program.Subtract("1", "a"));
        }
        
        [Test]
        public void Sub_NullBrewer()
        {
            Assert.Throws<ArgumentNullException>(() => Program.Subtract("1", null));  
        }
        
        [Test]
        public void Mult_ValidBrewer()
        {
            Assert.AreEqual(10, Program.Multiply("2","5"));
            Assert.AreEqual(12, Program.Multiply("4","3"));
            //intentional fail
            Assert.AreEqual(10, Program.Multiply("5","2"));
        }
        
        [Test]
        public void Mult_InvalidBrewer()
        {
            Assert.Throws<FormatException>(() => Program.Multiply("1", "a"));
        }
        
        [Test]
        public void Mult_NullBrewer()
        {
            Assert.Throws<ArgumentNullException>(() => Program.Multiply("1", null));  
        }
        
        [Test]
        public void Div_ValidBrewer()
        {
            Assert.AreEqual(5, Program.Divide("10","2"));
            Assert.AreEqual(3, Program.Divide("12","4"));
            //intentional fail
            Assert.AreEqual(2, Program.Divide("10","5"));
        }
        
        [Test]
        public void Div_InvalidBrewer()
        {
            Assert.Throws<FormatException>(() => Program.Divide("1", "a"));
        }
        
        [Test]
        public void Div_NullBrewer()
        {
            Assert.Throws<ArgumentNullException>(() => Program.Divide("1", null));  
        }
        
        [Test]
        public void Pow_ValidBrewer()
        {
            Assert.AreEqual(4, Program.Power("2","2"));
            Assert.AreEqual(27, Program.Power("3","3"));
            //intentional fail
            Assert.AreEqual(16, Program.Power("2","4"));
        }
        
        [Test]
        public void Pow_InvalidBrewer()
        {
            Assert.Throws<FormatException>(() => Program.Power("1", "a"));
        }
        
        [Test]
        public void Pow_NullBrewer()
        {
            Assert.Throws<ArgumentNullException>(() => Program.Power("1", null));
        }
    }
}
