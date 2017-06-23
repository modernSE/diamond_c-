using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Diamond.Test
{
    [TestClass]
    public class DiamondTest
    {
        [TestMethod]
        public void Diamond3_shouldPrint()
        {
            var expected = new StringBuilder();
            expected.Append(" *\n");
            expected.Append("***\n");
            expected.Append(" *\n");

            Assert.AreEqual(expected.ToString(), new Diamond().Print(3));
        }

        [TestMethod]
        public void Diamond5_shouldPrint()
        {
            var expected = new StringBuilder();
            expected.Append("  *\n");
            expected.Append(" ***\n");
            expected.Append("*****\n");
            expected.Append(" ***\n");
            expected.Append("  *\n");

            Assert.AreEqual(expected.ToString(), new Diamond().Print(5));
        }

        [TestMethod]
        public void Diamond0_shouldReturnNull() 
        {
	        Assert.AreEqual(null, new Diamond().Print(0));
        }

        [TestMethod]
        public void DiamondNegative_shouldReturnNull()
        {
            Assert.AreEqual(null, new Diamond().Print(-1));
        }

        [TestMethod]
        public void DiamondEven_shouldReturnNull()
        {
            Assert.AreEqual(null, new Diamond().Print(10));
        }

    }
}
