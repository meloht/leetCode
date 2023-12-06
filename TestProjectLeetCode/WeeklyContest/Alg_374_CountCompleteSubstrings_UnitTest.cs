﻿using leetCode.WeeklyContest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProjectLeetCode.WeeklyContest
{
    [TestClass]
    public class Alg_374_CountCompleteSubstrings_UnitTest
    {
        Alg_374 alg;
        [TestInitialize]
        public void Init()
        {
            alg = new Alg_374();
        }

        [TestMethod]
        public void TestCase01()
        {
            string word = "igigee";
            int res = alg.CountCompleteSubstrings(word, 2);
            Assert.AreEqual(3, res);//igig，ee，igigee
        }


        [TestMethod]
        public void TestCase02()
        {
            string word = "aaabbbccc";
            int res = alg.CountCompleteSubstrings(word, 3);
            Assert.AreEqual(6, res);//aaa,bbb,ccc,aaabbb,bbbccc,aaabbbccc
        }

        [TestMethod]
        public void TestCase03()
        {
            string word = "aaabbbcccddeee";
            int res = alg.CountCompleteSubstrings(word, 3);
            Assert.AreEqual(7, res);
        }

        [TestMethod]
        public void TestCase04()
        {
            string word = "aaa";
            int res = alg.CountCompleteSubstrings(word, 1);
            Assert.AreEqual(3, res);
        }

        [TestMethod]
        public void TestCase05()
        {
            string word = "abb";
            int res = alg.CountCompleteSubstrings(word, 1);
            Assert.AreEqual(4, res);
        }
        [TestMethod]
        public void TestCase06()
        {
            string word = "igigiee";
            int res = alg.CountCompleteSubstrings(word, 2);
            Assert.AreEqual(3, res);//igig，ee，igigee
        }

        [TestMethod]
        public void TestCase07()
        {
            string word = "aca";
            int res = alg.CountCompleteSubstrings(word, 1);
            Assert.AreEqual(5, res);
        }

        [TestMethod]
        public void TestCase08()
        {
            string word = "baa";
            int res = alg.CountCompleteSubstrings(word, 2);
            Assert.AreEqual(1, res);
        }

        [TestMethod]
        public void TestCase09()
        {
            string word = "ab";
            int res = alg.CountCompleteSubstrings(word, 2);
            Assert.AreEqual(0, res);
        }

        [TestMethod]
        public void TestCase10()
        {
            string word = "acb";
            int res = alg.CountCompleteSubstrings(word, 2);
            Assert.AreEqual(0, res);
        }

        [TestMethod]
        public void TestCase11()
        {
            string word = "baaa";
            int res = alg.CountCompleteSubstrings(word, 2);
            Assert.AreEqual(2, res);
        }

        [TestMethod]
        public void TestCase12()
        {
            string word = "aac";
            int res = alg.CountCompleteSubstrings(word, 2);
            Assert.AreEqual(1, res);
        }

        [TestMethod]
        public void TestCase13()
        {
            string word = "aacb";
            int res = alg.CountCompleteSubstrings(word, 2);
            Assert.AreEqual(1, res);
        }

        [TestMethod]
        public void TestCase14()
        {
            string word = "abaab";
            int res = alg.CountCompleteSubstrings(word, 2);
            Assert.AreEqual(2, res);
        }
        [TestMethod]
        public void TestCase15()
        {
            string word = "aab";
            int res = alg.CountCompleteSubstrings(word, 2);
            Assert.AreEqual(1, res);
        }

        [TestMethod]
        public void TestCase16()
        {
            string word = "abbab";
            int res = alg.CountCompleteSubstrings(word, 2);
            Assert.AreEqual(2, res);
        }

        [TestMethod]
        public void TestCase17()
        {
            string word = "abbba";
            int res = alg.CountCompleteSubstrings(word, 3);
            Assert.AreEqual(1, res);
        }
    }
}
