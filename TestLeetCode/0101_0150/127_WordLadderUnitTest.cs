using leetCode._0101_0150;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0101_0150
{
    [TestClass]
    public class _127_WordLadderUnitTest
    {
        _127_WordLadderAlg alg = new _127_WordLadderAlg();

        [TestMethod]
        public void TestCase01()
        {
            string beginWord = "hit";
            string endWord = "cog";
            string[] wordList = ["hot", "dot", "dog", "lot", "log", "cog"];
            var res = alg.LadderLength(beginWord, endWord, wordList);
            Assert.AreEqual(5, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            string beginWord = "hit";
            string endWord = "cog";
            string[] wordList = ["hot", "dot", "dog", "lot", "log"];
            var res = alg.LadderLength(beginWord, endWord, wordList);
            Assert.AreEqual(0, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            string beginWord = "red";
            string endWord = "tax";
            string[] wordList = ["ted", "tex", "red", "tax", "tad", "den", "rex", "pee"];
            var res = alg.LadderLength(beginWord, endWord, wordList);

            Assert.AreEqual(4, res);
        }
        [TestMethod]
        public void TestCase04()
        {
            string beginWord = "hot";
            string endWord = "dog";
            string[] wordList = ["hot", "dog", "dot"];
            var res = alg.LadderLength(beginWord, endWord, wordList);

            Assert.AreEqual(3, res);
        }
        [TestMethod]
        public void TestCase05()
        {
            string beginWord = "hot";
            string endWord = "dog";
            string[] wordList = ["hot", "cog", "dog", "tot", "hog", "hop", "pot", "dot"];
            var res = alg.LadderLength(beginWord, endWord, wordList);
            Assert.AreEqual(3, res);
        }

        [TestMethod]
        public void TestCase06()
        {
            string beginWord = "leet";
            string endWord = "code";
            string[] wordList = ["lest", "leet", "lose", "code", "lode", "robe", "lost"];
            var res = alg.LadderLength(beginWord, endWord, wordList);

            Assert.AreEqual(6, res);
        }

        [TestMethod]
        public void TestCase10()
        {
            string beginWord = "magic";
            string endWord = "pearl";
            string[] wordList = ["flail", "halon", "lexus", "joint", "pears", "slabs", "lorie", "lapse", "wroth", "yalow", "swear", "cavil", "piety", "yogis", "dhaka", "laxer", "tatum", "provo", "truss", "tends", "deana", "dried", "hutch", "basho", "flyby", "miler", "fries", "floes", "lingo", "wider", "scary", "marks", "perry", "igloo", "melts", "lanny", "satan", "foamy", "perks", "denim", "plugs", "cloak", "cyril", "women", "issue", "rocky", "marry", "trash", "merry", "topic", "hicks", "dicky", "prado", "casio", "lapel", "diane", "serer", "paige", "parry", "elope", "balds", "dated", "copra", "earth", "marty", "slake", "balms", "daryl", "loves", "civet", "sweat", "daley", "touch", "maria", "dacca", "muggy", "chore", "felix", "ogled", "acids", "terse", "cults", "darla", "snubs", "boats", "recta", "cohan", "purse", "joist", "grosz", "sheri", "steam", "manic", "luisa", "gluts", "spits", "boxer", "abner", "cooke", "scowl", "kenya", "hasps", "roger", "edwin", "black", "terns", "folks", "demur", "dingo", "party", "brian", "numbs", "forgo", "gunny", "waled", "bucks", "titan", "ruffs", "pizza", "ravel", "poole", "suits", "stoic", "segre", "white", "lemur", "belts", "scums", "parks", "gusts", "ozark", "umped", "heard", "lorna", "emile", "orbit", "onset", "cruet", "amiss", "fumed", "gelds", "italy", "rakes", "loxed", "kilts", "mania", "tombs", "gaped", "merge", "molar", "smith", "tangs", "misty", "wefts", "yawns", "smile", "scuff", "width", "paris", "coded", "sodom", "shits", "benny", "pudgy", "mayer", "peary", "curve", "tulsa", "ramos", "thick", "dogie", "gourd", "strop", "ahmad", "clove", "tract", "calyx", "maris", "wants", "lipid", "pearl", "maybe", "banjo", "south", "blend", "diana", "lanai", "waged", "shari", "magic", "duchy", "decca", "wried", "maine", "nutty", "turns", "satyr", "holds", "finks", "twits", "peaks", "teems", "peace", "melon", "czars", "robby", "tabby", "shove", "minty", "marta", "dregs", "lacks", "casts", "aruba", "stall", "nurse", "jewry", "knuth"];
            var res = alg.LadderLength(beginWord, endWord, wordList);

            Assert.AreEqual(11, res);

        }
        [TestMethod]
        public void TestCase11()
        {
            string beginWord = "hot";
            string endWord = "dog";
            string[] wordList = ["hot", "dog"];
            var res = alg.LadderLength(beginWord, endWord, wordList);

            Assert.AreEqual(0, res);

        }
    }
}
