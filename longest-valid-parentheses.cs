// 32. Longest Valid Parentheses   
// https://leetcode.com/problems/longest-valid-parentheses
// Hard 23.0%
// 667.858669163969
// Submission: https://leetcode.com/submissions/detail/70689907/
// Runtime: 136 ms
// Your runtime beats 22.06 % of csharp submissions.

public class Solution {
    public int LongestValidParentheses(string s) {
        var stack = new Stack<int>();
                int maxlen = 0;
        int validStart = 0;
        for (int i=0; i<s.Length; i++)
        {
            switch(s[i])
            {
            case '(':
                stack.Push(i);
                break;
            case ')':
                if (stack.Count == 0)
                {
                    stack.Clear();
                    validStart = i+1;
                }
                else
                {
                    int prev = stack.Pop();
                    int start = stack.Count==0 ? validStart : stack.Peek()+1; 
                    maxlen = Math.Max(maxlen, i-start+1);
                }
                break;
            }
        }
                return maxlen;
    }
}
