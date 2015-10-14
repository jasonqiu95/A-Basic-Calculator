using Microsoft.VisualStudio.TestTools.UnitTesting;
using homework2_1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework2_1.Tests
{
    [TestClass()]
    public class CalculatorTests
    {
        Calculator c = new Calculator();

        [TestMethod()]
        public void parseTest()
        {
            Assert.AreEqual(true, c.parse("( 5 + 2'4/5 )")); // only have plus sign
            Assert.AreEqual(true, c.parse("( 4'1/3 - 1 )")); // only have minus sign
            Assert.AreEqual(true, c.parse("( -0 × 1/3 )")); // only have multi sign
            Assert.AreEqual(true, c.parse("( 2 ÷ 1 )")); // only have division sign
            Assert.AreEqual(true, c.parse("( 1 + ( 3 + 2 ) )")); // only have integers
            // Mixed
            Assert.AreEqual(true, c.parse("( ( ( ( -4 - 2'1/4 ) + 4'2/4 ) ÷ 4 ) × 4 )"));
            Assert.AreEqual(true, c.parse("( 3'3/5 + ( 3 - ( 5 - 4'1/4 ) ) )"));
        }

        [TestMethod]
        [ExpectedException(typeof(System.FormatException))]
        public void parseTestWrongFormat()
        {
            // should not be able to parse
            Assert.AreEqual(false, c.parse("25. (4 + (2 - 1))"));
            Assert.AreEqual(false, c.parse("( ( ( ( -4 - 2'1/4 ) + 4'2/4 ) ÷ 4 ) × 4 )q"));
            Assert.AreEqual(false, c.parse("( 2( ( ( -4 - 2'1/4 ) + 4'2/4 ) ÷ 4 ) × 4 )"));
            Assert.AreEqual(false, c.parse("( -0 × 1/@3 )"));
            Assert.AreEqual(false, c.parse("( --0 × 1/3 )"));
        }

        [TestMethod()]
        public void calculateTest()
        {
            Assert.AreEqual("7'4/5", c.calculate("( 5 + 2'4/5 )").ToString()); // only have plus sign
            Assert.AreEqual("3'1/3", c.calculate("( 4'1/3 - 1 )").ToString()); // only have minus sign
            Assert.AreEqual("0", c.calculate("( -0 × 1/3 )").ToString()); // only have multi sign
            Assert.AreEqual("2", c.calculate("( 2 ÷ 1 )").ToString()); // only have division sign
            Assert.AreEqual("-1", c.calculate("( ( 1 - ( -0 + 0 ) ) × -1 )").ToString()); // don't have decimal

        }
    }
}