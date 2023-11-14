using leetCode._1_50;

namespace leetCode
{
    internal class Program
    {

        static void Main(string[] args)
        {
            _50_PowxNAlg alg=new _50_PowxNAlg();
            var res = alg.MyPow(0.00001d, 100);

            Console.WriteLine(res);
        }
    }
}