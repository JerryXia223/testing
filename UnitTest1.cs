// BasicMathTests.cs

using System;
using NUnit.Framework;
using BasicMath;

namespace BasicMathTests
{
    [TestFixture]
    public class BasicMathTests
    {
        [Test]
        public void TestAdd()
        {
            var basicMath = new BasicMath.BasicMath();
            Assert.AreEqual(4, basicMath.add(2, 2));
        }

        [Test]
        public void TestSubtract()
        {
            var basicMath = new BasicMath.BasicMath();
            Assert.AreEqual(2, basicMath.subtract(4, 2));
        }

        [Test]
        public void TestDivide()
        {
            var basicMath = new BasicMath.BasicMath();
            Assert.AreEqual(2, basicMath.divide(4, 2));
        }

        [Test]
        public void TestMultiply()
        {
            var basicMath = new BasicMath.BasicMath();
            Assert.AreEqual(6, basicMath.multiply(2, 3));
        }

        [Test]
        public void TestDivideByZero()
        {
            var basicMath = new BasicMath.BasicMath();
            Assert.Throws<ArgumentException>(() => basicMath.divide(4, 0));
        }
    }
}