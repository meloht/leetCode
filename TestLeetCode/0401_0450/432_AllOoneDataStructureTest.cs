﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static leetCode._0401_0450._432_AllOoneDataStructureAlg;

namespace Test._0401_0450
{
    [TestClass]
    public class _432_AllOoneDataStructureTest
    {
        [TestMethod]
        public void TestCase01()
        {
            AllOne allOne = new AllOne();
            allOne.Inc("hello");
            allOne.Inc("hello");
            Assert.AreEqual("hello", allOne.GetMaxKey()); // 返回 "hello"
            Assert.AreEqual("hello", allOne.GetMinKey()); // 返回 "hello"
            allOne.Inc("leet");
            Assert.AreEqual("hello", allOne.GetMaxKey()); // 返回 "hello"
            Assert.AreEqual("leet", allOne.GetMinKey()); // 返回 "leet"
        }

       

        [TestMethod]
        public void TestCase02()
        {
            AllOne allOne = new AllOne();
            allOne.Inc("hello");
            allOne.Inc("goodbye");
            allOne.Inc("hello");
            allOne.Inc("hello");
            Assert.AreEqual("hello", allOne.GetMaxKey()); // 返回 "hello"
            allOne.Inc("leet");
            allOne.Inc("code");
            allOne.Inc("leet");
            allOne.Dec("hello");
            allOne.Inc("leet");
            allOne.Inc("code");
            allOne.Inc("code");
            allOne.Dec("leet");
            Assert.AreEqual("goodbye", allOne.GetMinKey()); // 返回 "hello"
          
        }

        [TestMethod]
        public void TestCase03()
        {
            AllOne allOne = new AllOne();
            allOne.Inc("hello");
            allOne.Inc("world");
            allOne.Inc("leet");
            allOne.Inc("code");
            allOne.Inc("ds");
            allOne.Inc("leet");
            Assert.AreEqual("leet", allOne.GetMaxKey()); // 返回 "hello"
            allOne.Inc("ds");
            allOne.Dec("leet");
            Assert.AreEqual("ds", allOne.GetMaxKey());
            allOne.Dec("ds");
            allOne.Inc("hello");
            Assert.AreEqual("hello", allOne.GetMaxKey());
            allOne.Inc("hello");
            allOne.Inc("hello");
            allOne.Dec("world");
            allOne.Dec("leet");
            allOne.Dec("code");
            allOne.Dec("ds");
            Assert.AreEqual("hello", allOne.GetMaxKey());
            allOne.Inc("new");
            allOne.Inc("new");
            allOne.Inc("new");
            allOne.Inc("new");
            allOne.Inc("new");
            allOne.Inc("new");
            Assert.AreEqual("new", allOne.GetMaxKey()); // 返回 "hello"
            Assert.AreEqual("hello", allOne.GetMinKey());

        }

        [TestMethod]
        public void TestCase04()
        {
            AllOne allOne = new AllOne();
            allOne.Inc("hello");
            allOne.Inc("hello");

            Assert.AreEqual("hello", allOne.GetMaxKey()); // 返回 "hello"
            Assert.AreEqual("hello", allOne.GetMinKey()); // 返回 "hello"
            allOne.Inc("leet");
            Assert.AreEqual("hello", allOne.GetMaxKey()); // 返回 "hello"
            Assert.AreEqual("leet", allOne.GetMinKey()); // 返回 "leet"

            allOne.Dec("hello");
            allOne.Dec("hello");
            Assert.AreEqual("leet", allOne.GetMaxKey());

        }
        [TestMethod]
        public void TestCase05()
        {
            AllOne allOne = new AllOne();
            allOne.Inc("hello");
            allOne.Inc("hello");

            Assert.AreEqual("hello", allOne.GetMaxKey()); // 返回 "hello"
            Assert.AreEqual("hello", allOne.GetMinKey()); // 返回 "hello"
            allOne.Dec("hello");
            allOne.Dec("hello");
          
            Assert.AreEqual("", allOne.GetMinKey()); // 返回 "leet"

            allOne.Inc("hello");

            Assert.AreEqual("hello", allOne.GetMinKey());

        }
    }
}
