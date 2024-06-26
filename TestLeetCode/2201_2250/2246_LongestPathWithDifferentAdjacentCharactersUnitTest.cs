﻿using leetCode._2201_2250;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._2201_2250
{
    [TestClass]
    public class _2246_LongestPathWithDifferentAdjacentCharactersUnitTest
    {
        _2246_LongestPathWithDifferentAdjacentCharactersAlg alg = new _2246_LongestPathWithDifferentAdjacentCharactersAlg();

        [TestMethod]
        public void TestCase01()
        {
            int[] parent = [-1, 0, 0, 1, 1, 2];
            string s = "abacbe";
            int exp = 3;
            int res = alg.LongestPath(parent, s);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            int[] parent = [-1, 0, 0, 0];
            string s = "aabc";
            int exp = 3;
            int res = alg.LongestPath(parent, s);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            //Thread thread = new Thread(Test, 81943040);
            //thread.Start();
            string nums = File.ReadAllText(@"TestData/2201_2250/2246/parent.txt");
            string s = File.ReadAllText(@"TestData/2201_2250/2246/s.txt");


            int[] parent = nums.Split(',', StringSplitOptions.RemoveEmptyEntries).Select(p => int.Parse(p)).ToArray();

            int exp = 1;
            int res = alg.LongestPath(parent, s);
            Assert.AreEqual(exp, res);
        }
        private void Test()
        {
            _2246_LongestPathWithDifferentAdjacentCharactersAlg alg1 = new _2246_LongestPathWithDifferentAdjacentCharactersAlg();
            string nums = File.ReadAllText(@"TestData/2201_2250/2246/parent.txt");
            string s = File.ReadAllText(@"TestData/2201_2250/2246/s.txt");


            int[] parent = nums.Split(',', StringSplitOptions.RemoveEmptyEntries).Select(p => int.Parse(p)).ToArray();

            int exp = 1;
            int res = alg1.LongestPath(parent, s);
            System.Diagnostics.Debug.WriteLine(res);

        }

    }
}
