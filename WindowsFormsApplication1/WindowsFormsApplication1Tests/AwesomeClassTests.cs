using Microsoft.VisualStudio.TestTools.UnitTesting;
using WindowsFormsApplication1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.Tests
{
    [TestClass()]
    public class AwesomeClassTests
    {
        AwesomeClass ac = new AwesomeClass();
        [TestMethod()]
        public void test1Test()
        {
            Assert.IsFalse(ac.test1(2));
            Assert.IsTrue(ac.test1(1));
        }

        [TestMethod()]
        public void test2Test()
        {
            Assert.Equals(ac.test2(true), 1);
            Assert.Equals(ac.test2(false), 2);
        }
    }
}