// 20. Valid Parentheses   
// https://leetcode.com/problems/valid-parentheses
// Easy 33.1%
// 1304.8856559100814
// Submission: https://leetcode.com/submissions/detail/67655282/
// Runtime: 120 ms
// Your runtime beats 25.26 % of csharp submissions.

public class Solution {
    public bool IsValid(string s) {
        var stack = new Stack<char>();
        foreach(var ch in s)
        {
            var matching = '\0';
            switch(ch)
            {
            case '(':
            case '[':
            case '{':
                stack.Push(ch);
                continue;
            case ')':
                matching = '(';
                break;
            case ']':
                matching = '[';
                break;
            case '}':
                matching = '{';
                break;
            }
                        if (stack.Count == 0 || stack.Pop() != matching)
                return false;
        }
        return stack.Count==0;
    }
}
