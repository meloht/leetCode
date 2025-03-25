using leetCode._0801_0850;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._0801_0850
{
    [TestClass]
    public class _833_FindAndReplaceInStringTest
    {
        _833_FindAndReplaceInStringAlg alg = new _833_FindAndReplaceInStringAlg();

        [TestMethod]
        public void TestCase01()
        {
            string s = "abcd";
            int[] indices = [0, 2];
            string[] sources = ["a", "cd"], targets = ["eee", "ffff"];

            string exp = "eeebffff";
            string res = alg.FindReplaceString(s, indices, sources, targets);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase02()
        {
            string s = "abcd";
            int[] indices = [0, 2];
            string[] sources = ["ab", "ec"], targets = ["eee", "ffff"];

            string exp = "eeecd";
            string res = alg.FindReplaceString(s, indices, sources, targets);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase03()
        {
            string s = "abcde";
            int[] indices = [2, 2, 3];
            string[] sources = ["cde", "cdef", "dk"], targets = ["fe", "f", "xyz"];

            string exp = "abfe";
            string res = alg.FindReplaceString(s, indices, sources, targets);
            Assert.AreEqual(exp, res);
        }

        [TestMethod]
        public void TestCase04()
        {
            string s = "hjclvqqhbvvtqenyzudypfeyzwdnfozvozgzisyjqhzdbrilwyylyibfjvwfcsvfmngedhcufeprzrwvbhsezftisudgtecqszipqilqncelrmrjlwtopaweidhjuzdviehtivmyzcosnorimpljdyhdreconkljdxyrzjrfpkebllthvjyjkbykoczlofuiovlifdbuqvvwuxyfuengatwyndvktmkxzqbqcvwdquxnjdhwexzkjjxqvefasxaufgtgecmllkdwhqpyguiqkanlxnwzwojblxgdkdxvuvfillxqaznqzxqeqqsmfiriyqwalddgsqqkianfvoshgkagkqalgkapsedaqvylogbadplhmklzjmqdqcqjscdwcudkvsqgvhshxllloqjxxbinnlcsgfjaowwuirnxyzmzffqatuakdzyhnfpmcwugelngeeuyeltfuzsodyqwfaribylowtshbwwgzaiwmkxzcppuwazfoudupzvargijmhospiobfqemybkrhntydolixgeoofpqewtxjslroupdjjuegcnbjtpezahjbmvdbxegavooqzzhflenpkvxpyxqmqqwkkdtddcfcgjiunrprgykeszevsbcequphhsjiodayprqialpzykzerikrmmtftxfgdemlopqygpoxlqbidtiihtnitanzkbvpdufwuxbgkqtrvztwrdfibcqleoszbrteyuomzhvxwbesnlmpuctdwzbdmhnwgdhoqkoulsokggeccehzlfkysclgturgtrjctmibnpsrlmqrgdwpniqyhahedwtnajbigoqqtfmivhdtzijnoceesyjhothygsvfadpdfahppiuipjgieevisxxbppbdwnohncgnillezufykcmpoeocpqyxclehpyixkaulgyrfdtdvkgsnlmdyuswfmevkjhypcmynreeygxksjbuqpauajrxabvgcifcktysymioopek";
            int[] indices = [872, 859, 303, 533, 841, 702, 135, 161, 800, 643, 289, 203, 117, 381, 18, 469, 153, 583, 399, 728, 320, 37, 929, 732, 419, 509, 437, 847, 569, 282, 878, 80, 9, 581, 355, 944, 295, 900, 725, 744, 311, 326, 422, 803, 719, 988, 919, 479, 712, 813, 103, 597, 937, 955, 979, 545, 833, 239, 76, 762, 217, 531, 90, 52, 390, 695, 361, 185, 521, 273, 306, 261, 633, 375, 992, 457, 815, 330, 256, 554, 175, 835, 787, 147, 962, 447, 406, 653, 627, 637, 246, 660, 416, 67, 270, 934, 393, 432, 227, 675];
            string[] sources = ["ipjgi", "vfadpdfah", "qa", "oli", "zi", "ufwu", "yzcosno", "xyrz", "bnp", "ayprqialpz", "xgdkdx", "wuxy", "aweidhj", "cd", "dypfeyzwdnfozvozg", "aribylo", "econ", "oqzzhfl", "loqjx", "zbrt", "yq", "syjqhzdbrilwy", "gyr", "eyuom", "uir", "gijm", "zyh", "ees", "ahjbmvdbxeg", "wzwoj", "evisxxbppbdwnohncgnil", "bhsezfti", "vvt", "vo", "aqvylo", "yuswfmevkjh", "vuvfi", "ezuf", "eos", "snlmpuc", "eqq", "dg", "nxyzm", "srlm", "fi", "ktys", "ehpyixkau", "hb", "rvz", "ni", "qnce", "yxqmqqwkkdtddcfcgji", "kgsn", "ypcmyn", "xabvgcifc", "wtxjslr", "tf", "wex", "zr", "dhoqkoulsokggeccehzlf", "dvktmkxz", "yd", "dgtecqszipqi", "yi", "qgv", "nz", "gbadplhm", "czlofuiovli", "qemybk", "uiqkan", "nqzx", "cml", "quph", "dqcq", "ymioopek", "ltfuzsodyq", "qy", "qkianfvoshgkagk", "fgt", "pdjjuegcnbjtp", "hvjy", "mivhd", "lgturgtrjct", "jd", "ee", "gel", "innlcsgfja", "ykzer", "evsbc", "hsjiod", "xqvef", "rmmt", "ow", "edhc", "py", "tdv", "hshxl", "tu", "qcvwdquxn", "qygpoxlq"], 
                targets = ["ydwpt", "qziiurzp", "dix", "oibx", "nyz", "aajk", "oowsno", "frrm", "vesc", "gzfwrmbqt", "wbvbut", "tujrh", "ednufjcb", "vl", "lemjqpegrenbcdln", "inzxvaf", "ldw", "zwbwgniz", "pbft", "hqft", "p", "dqqpsyhmsounq", "hhgw", "wiplme", "hrwo", "knnid", "nyrs", "cwiu", "qciskyiaqm", "jxqfg", "dliolrcbjnsoustvswwhbz", "zrmjtpfm", "xj", "ow", "qtenoc", "xuxzqxcify", "qgsoo", "ogoia", "dbvi", "dnawzllw", "slp", "gu", "rjiqi", "qnct", "xp", "yuxme", "bvayefdfw", "kw", "twd", "sof", "nhtbx", "ixaqypjbbpdxztgpydd", "rzrj", "rynyb", "qisarlnflf", "pcnqzo", "vba", "kduz", "wsa", "mjafnhhgzqmtwbcbqbekb", "ecfnoxme", "vr", "srxpggvwrgte", "se", "es", "yew", "syenusif", "fwjtodvnaz", "lmguo", "elpxs", "gdqqi", "qer", "cbkvx", "plmn", "wneyunyj", "lneqkrtizo", "on", "gmfnvzyfkinlrh", "cmvk", "ahxakqykdfzllz", "uvype", "ywmaw", "kpdawhdhnced", "of", "wgz", "tye", "tleifzbpqzc", "jmxzzj", "rtem", "ymwpuk", "buxa", "arnwt", "bj", "mlivy", "l", "lcku", "unoln", "nz", "pbkazpla", "czqbfufoc"];

            string exp = "hjclvqqhbxjqenyzulemjqpegrenbcdlnzidqqpsyhmsounqylsebfjvwfcsvfmngmlivyufeprwsawvzrmjtpfmsusrxpggvwrgtelnhtbxlrmrjlwtopednufjcbuzdviehtivmoowsnorimplofyhdrldwkljdfrrmjrfpkeblltuvypejkbykofwjtodvnazfdbuqvvtujrhfuengatwynecfnoxmeqbpbkazplajdhkduzzkjjbuxaasxaucmvkgeqerlkdwhqlgelpxslxnjxqfgblwbvbutqgsoollxdixzgdqqiqslpsmfiripwaldgusqgmfnvzyfkinlrhqalgkapsedqtenocsyenusifklzjmqplmnjsvlwcudkvsesunolnlpbftxbtleifzbpqzcbjwhrworjiqizffqanzakdnyrsnfpmcwutyengeeuyelneqkrtizowfinzxvafwtskwwwgzaiwmkxzcppuwazfoudupzvarknnidhospiobflmguorhntvroibxxgeoofpqepcnqzoouahxakqykdfzllzezqciskyiaqmaowzwbwgnizenpkvxpixaqypjbbpdxztgpyddunrprgykeszrtemecbkvxymwpukgzfwrmbqtjmxzzjikarnwtftxfgdemlopczqbfufocbidtiihtnitayewkbvpdaajkxbgkqttwdtwrdxpbcqldbvihqftwiplmezhvxwbednawzllwtdwzbdmhnwgmjafnhhgzqmtwbcbqbekbkysckpdawhdhncedmivescqnctqrgdwpsofonhahedwtnajbigoqqvbaywmawtnyzjnoccwiuyjhothygsqziiurzpppiuydwptedliolrcbjnsoustvswwhbzlogoiaykcmpoeocpqyxclbvayefdfwlhhgwfdlckurzrjlmdxuxzqxcifyrynybrwgzygxksjbuqpauajrqisarlnflfyuxmewneyunyj";
            string res = alg.FindReplaceString(s, indices, sources, targets);
            Assert.AreEqual(exp, res);
        }
    }
}
