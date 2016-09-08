using System;
using Domain;
using Logic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AssignmentTest
{
    [TestClass]
    public class TriangleUnitTest
    {
        [TestMethod]
        public void TestNoTriangle()
        {
            Assert.AreEqual(TriangleLogic.GetTriangleType(5, 2, 1), TriangleType.NoTriangle);
        }

        [TestMethod]
        public void TestIsosceles()
        {
            Assert.AreEqual(TriangleLogic.GetTriangleType(5, 2, 5), TriangleType.Isosceles);
        }

        [TestMethod]
        public void TestEquilateral()
        {
            Assert.AreEqual(TriangleLogic.GetTriangleType(5, 5, 5), TriangleType.Equilateral);
        }

        [TestMethod]
        public void TestScalene()
        {
            Assert.AreEqual(TriangleLogic.GetTriangleType(5, 7, 8), TriangleType.Scalene);
        }
    }
}
