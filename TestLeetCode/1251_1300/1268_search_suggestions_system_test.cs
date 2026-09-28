using leetCode._1251_1300;
using System;
using System.Collections.Generic;
using System.Text;

namespace Test._1251_1300
{
    [TestClass]
    public class _1268_search_suggestions_system_test
    {
        _1268_search_suggestions_system alg = new _1268_search_suggestions_system();

        [TestMethod]
        public void Test01()
        {
            string[] products = ["mobile", "mouse", "moneypot", "monitor", "mousepad"];
            string searchWord = "mouse";
            IList<IList<string>> exp = [
["mobile","moneypot","monitor"],
["mobile","moneypot","monitor"],
["mouse","mousepad"],
["mouse","mousepad"],
["mouse","mousepad"]
];

            IList<IList<string>> res = alg.SuggestedProducts(products, searchWord);
            Assert.IsTrue(Utils.IsSame(exp, res));
        }

        [TestMethod]
        public void Test02()
        {
            string[] products = ["havana"];
            string searchWord = "havana";
            IList<IList<string>> exp = [["havana"], ["havana"], ["havana"], ["havana"], ["havana"], ["havana"]];

            IList<IList<string>> res = alg.SuggestedProducts(products, searchWord);
            Assert.IsTrue(Utils.IsSame(exp, res));
        }
        [TestMethod]
        public void Test03()
        {
            string[] products = ["bags", "baggage", "banner", "box", "cloths"];
            string searchWord = "bags";
            IList<IList<string>> exp = [["baggage", "bags", "banner"], ["baggage", "bags", "banner"], ["baggage", "bags"], ["bags"]];

            IList<IList<string>> res = alg.SuggestedProducts(products, searchWord);
            Assert.IsTrue(Utils.IsSame(exp, res));
        }

        [TestMethod]
        public void Test04()
        {
            string[] products = ["havana"];
            string searchWord = "tatiana";
            IList<IList<string>> exp = [[], [], [], [], [], [], []];

            IList<IList<string>> res = alg.SuggestedProducts(products, searchWord);
            Assert.IsTrue(Utils.IsSame(exp, res));
        }
    }
}
