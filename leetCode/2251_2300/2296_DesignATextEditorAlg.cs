using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode._2251_2300
{
    public class _2296_DesignATextEditorAlg
    {
        public class TextEditor
        {
            private LinkedList<char> left;
            private LinkedList<char> right;

            public TextEditor()
            {
                left = new LinkedList<char>();
                right = new LinkedList<char>();
            }

            public void AddText(string text)
            {
                foreach (char c in text)
                {
                    left.AddLast(c);
                }
            }

            public int DeleteText(int k)
            {
                int count = 0;
                while (k > 0 && left.Count > 0)
                {
                    left.RemoveLast();
                    count++;
                    k--;
                }
                return count;
            }

            public string CursorLeft(int k)
            {
                int move = Math.Min(k, left.Count);
                for (int i = 0; i < move; i++)
                {
                    right.AddLast(left.Last.Value);
                    left.RemoveLast();
                }
                return GetLeftText();
            }

            public string CursorRight(int k)
            {
                int move = Math.Min(k, right.Count);
                for (int i = 0; i < move; i++)
                {
                    left.AddLast(right.Last.Value);
                    right.RemoveLast();
                }
                return GetLeftText();
            }

            private string GetLeftText()
            {
                var text = new char[Math.Min(10, left.Count)];
                var current = left.Last;
                int index = text.Length - 1;
                while (current != null && index >= 0)
                {
                    text[index--] = current.Value;
                    current = current.Previous;
                }
                return new string(text);
            }

        }

        public class TextEditor1
        {

            private Stack<char> left;
            private Stack<char> right;

            public TextEditor1()
            {
                left = new Stack<char>();
                right = new Stack<char>();
            }

            public void AddText(string text)
            {
                foreach (char c in text)
                {
                    left.Push(c);
                }
            }

            public int DeleteText(int k)
            {
                int k0 = k;
                while (k > 0 && left.Count > 0)
                {
                    left.Pop();
                    k--;
                }
                return k0 - k;
            }

            public string Text()
            {
                // Get the last 10 characters from the left stack
                Stack<char> temp = new Stack<char>();
                int count = Math.Min(10, left.Count);
                for (int i = 0; i < count; i++)
                {
                    temp.Push(left.Pop());
                }

                string result = new string(temp.ToArray());

                // Restore the characters back to the left stack
                foreach (char c in temp)
                {
                    left.Push(c);
                }

                return result;
            }

            public string CursorLeft(int k)
            {
                while (k > 0 && left.Count > 0)
                {
                    right.Push(left.Pop());
                    k--;
                }
                return Text();
            }

            public string CursorRight(int k)
            {
                while (k > 0 && right.Count > 0)
                {
                    left.Push(right.Pop());
                    k--;
                }
                return Text();
            }

        }
    }
}
