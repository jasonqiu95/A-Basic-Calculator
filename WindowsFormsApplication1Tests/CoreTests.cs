using Microsoft.VisualStudio.TestTools.UnitTesting;
using homework2_1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace homework2_1.Tests
{
    [TestClass()]
    public class CoreTests
    {
        Core c = new Core();
        Calculator cl = new Calculator();

        [TestMethod()]
        public void calcTest()
        {
            Assert.AreEqual("7'4/5", c.calc("( 5 + 2'4/5 )").ToString()); // only have plus sign
            Assert.AreEqual("3'1/3", c.calc("( 4'1/3 - 1 )").ToString()); // only have minus sign
            Assert.AreEqual("0", c.calc("( -0 × 1/3 )").ToString()); // only have multi sign
            Assert.AreEqual("2", c.calc("( 2 ÷ 1 )").ToString()); // only have division sign
            Assert.AreEqual("-1", c.calc("( ( 1 - ( -0 + 0 ) ) × -1 )").ToString()); // don't have decimal
        }

        [TestMethod()]
        public void generateTest()
        {
            try {
                string lineE;
                string lineA;
                c.setting(5, 5, 3, true, true, true);
                c.generate();
                StreamReader sr1 = new StreamReader(@"exercises.txt");
                StreamReader sr2 = new StreamReader(@"answers.txt");
                while ((lineE = sr1.ReadLine()) != null && (lineA = sr2.ReadLine()) != null)
                {
                        string question = lineE.Substring(3);   
                        Assert.AreEqual(true, cl.parse(question));
                        string answerTxt = lineA.Substring(3);
                        string answer = cl.calculate(question).toString();
                        Assert.AreEqual(answer, answerTxt);
                }
                sr1.Close();
                sr2.Close();
            } catch(Exception)
            {
                Assert.Fail();
            }
        }

        [TestMethod()]
        public void gradeTest()
        {
            c.setting(5, 5, 3, true, true, true);
            c.generate();
            c.grade("answers.txt", "exercises.txt");
        }
    }
}