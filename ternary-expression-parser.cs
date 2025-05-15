// 439. Ternary Expression Parser   
// https://leetcode.com/problems/ternary-expression-parser
// Medium 50.7%
// 284.80584766619927
// Submission: https://leetcode.com/submissions/detail/101881901/
// Runtime: 136 ms
// Your runtime beats 53.85 % of csharp submissions.

public class Solution {
    public string ParseTernary(string exp) {
        int i = 0;
        return ((char)ParseTernary(exp, ref i)).ToString();
    }
        public int ParseTernary(string exp, ref int i)
    {
        var cond = Read(exp, ref i);
        if ( Peek(exp, i) != '?' )
            return cond;
        i++;
        var left = ParseTernary(exp, ref i);
        i++;
        var right = ParseTernary(exp, ref i);
        return (cond == 'T') ? left : right;
    }
        public int Read(string exp, ref int i)
    {
        if (i>=exp.Length)
            return 0;
        return exp[i++];
    }
        public int Peek(string exp, int i)
    {
        return Read(exp, ref i);
    }
}
