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
    public class GeneratorTests
    {
        Generator g = new Generator();
        [TestMethod()]
        public void settingTest()
        {
            g.setting(4, 2, 3, true, true, true);
        }

        [TestMethod()]
        public void generateQTest()
        {
            g.generateQ();
        }
    }
}