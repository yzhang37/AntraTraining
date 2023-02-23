// See https://aka.ms/new-console-template for more information

// test myStack, let's try LeetCode 20. Valid Parentheses
using SpecialStack;

namespace SpecialStack
{
    class Program
    {
        static void MakeTest(string s, Solution sol)
        {
            Console.WriteLine($"sol.IsValid(\"{s}\") = {sol.IsValid(s)}");
        }
        
        static void Main(string[] args)
        {
            var sol = new Solution();
            MakeTest("()", sol);
            MakeTest("()[]{}", sol);
            MakeTest("(]", sol);
            MakeTest("([)]", sol);
            MakeTest("]", sol);
        }
    }
}

public class Solution {
    public bool IsValid(string s) {
        var st = new MyStack<char>();
        foreach (var c in s) {
            if (c == '(')
                st.Push(')');
            else if (c == '[')
                st.Push(']');
            else if (c == '{')
                st.Push('}');
            else if (st.Count == 0 || st.Top != c) // 中间如果空了，但是字符串还没结束，是错的。
                return false;
            else
                st.Pop();
        }
        return st.Count == 0; // 最后如果没空，那也是不对的。
    }
}