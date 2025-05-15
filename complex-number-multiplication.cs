// 537. Complex Number Multiplication   
// https://leetcode.com/problems/complex-number-multiplication
// Medium 65.2%
// 289.67927448410654
// Submission: https://leetcode.com/submissions/detail/101912365/
// Runtime: 142 ms
// Your runtime beats 35.62 % of csharp submissions.

public class Solution {
    public string ComplexNumberMultiply(string a, string b) {
        double r1,r2,i1,i2;
        Parse(a, out r1, out i1);
        Parse(b, out r2, out i2);
        var r3 = r1*r2 - i1*i2;
        var i3 = r1*i2 + r2*i1;
        return $"{r3}+{i3}i";
    }
            public void Parse(string x, out double r, out double i)
    {
        var split = x.Substring(0, x.Length-1).Split('+');
        r = double.Parse(split[0]);
        i = double.Parse(split[1]);
    }
}
