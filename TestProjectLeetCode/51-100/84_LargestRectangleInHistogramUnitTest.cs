﻿using leetCode._51_100;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProjectLeetCode._51_100
{
    [TestClass]
    public class _84_LargestRectangleInHistogramUnitTest
    {
        _84_LargestRectangleInHistogramAlg alg;
        [TestInitialize]
        public void Init()
        {
            alg = new _84_LargestRectangleInHistogramAlg();
        }

        [TestMethod]
        public void TestCase01()
        {
            int[] arr = { 2, 1, 5, 6, 2, 3 };
            int res=alg.LargestRectangleArea(arr);
            Assert.AreEqual(10, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] arr = { 2, 4 };
            int res = alg.LargestRectangleArea(arr);
            Assert.AreEqual(4, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            int[] arr = { 3, 6, 5, 7, 4, 8, 1, 0 };
            int res = alg.LargestRectangleArea(arr);
            Assert.AreEqual(20, res);
        }
    }
}