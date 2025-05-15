// 22. Generate Parentheses   
// https://leetcode.com/problems/generate-parentheses
// Medium 43.9%
// 1064.6858717112439
// Submission: https://leetcode.com/submissions/detail/68469067/
// Runtime: 424 ms
// Your runtime beats 34.11 % of csharp submissions.

public class Solution {
    List<string> list;
    public IList<string> GenerateParenthesis(int n) {
        list = new List<string>();
        helper("", n,0);
        return list;
    }
        void helper(string s, int parens, int closeParens)
    {
        if (parens + closeParens==0)
        {
            list.Add(s);
            return;
        }
                if (closeParens>0) helper(s+")", parens, closeParens-1);
        if (parens>0) helper(s+"(", parens-1, closeParens+1);
    }
    }
