using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades.Tests.Types
{
    [TestClass]
    class ReferenceTypeTests
    {
        [TestMethod]
        public void IntVariavlesHoldAValue()
        {
            int x1 = 100;
            int x2 = x1;

            x1 = 4;
            Assert.AreEqual(x1, x2);
        }

        [TestMethod]
        public void GradeBookVeriablesHoldRefrence()
        {

            GradeBook g1 = new GradeBook();
            GradeBook g2 = g1;

            g1 = new GradeBook();
            g1.Name = "Scott's GradeBook";
            Assert.AreEqual(g1.Name, g2.Name);
        }
    }
}
