using leetCode._1_50;
using leetCode._51_100;
using leetCode.WeeklyContest;

namespace leetCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int?[] values = { 1, 2, 3, null, null, 4, 5 };

            BinaryTreeBuilder builder = new BinaryTreeBuilder();
            TreeNode root = builder.BuildTree(values);

            Console.WriteLine("Inorder Traversal:");
            builder.InorderTraversal(root);
        }
    }
}