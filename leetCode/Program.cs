using leetCode._1_50;

namespace leetCode
{
    internal class Program
    {
        static void Main(string[] args)
        {

            _44_WildcardMatchingAlg alg = new _44_WildcardMatchingAlg();
            var s = "babaaababaabababbbbbbaabaabbabababbaababbaaabbbaaab";
            var p = "***bba**a*bbba**aab**b";
            var res = alg.IsMatch(s, p);

        }
    }
}