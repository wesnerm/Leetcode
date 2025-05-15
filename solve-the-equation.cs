// 640. Solve the Equation   
// https://leetcode.com/problems/solve-the-equation
// Medium 39.4%
// 177.3420532302302
// Submission: https://leetcode.com/submissions/detail/111482737/
// Runtime: 232 ms
// Your runtime beats 0.00 % of csharp submissions.

using System.Text.RegularExpressions;
public class Solution {
    public string SolveEquation(string equation) {
                var tokens = Regex.Matches(equation, @"\d+|\S").Cast<Match>().Select(x=>x.Value).ToArray();
        int left = 1;
        int sign = 1;
        long constant = 0;
        long term = 0;
        var prev = "+";
        for(int i=0; i<tokens.Length; prev = tokens[i++])
        {
            var t = tokens[i];
            if (t == "=" )
            {
                left = -1;
                sign = left;
                continue;
            }
                        if (t == "-")
            {
                sign = -sign;
                continue;
            }
                        if (t == "+")
                continue;
                        if (t == "x")
            {
                term += sign;
                sign = left;
                continue;
            }
                        long v = int.Parse(t);
            if (i+1<tokens.Length && tokens[i+1] == "x")
            {
                term += sign * v;
                sign = left;
                i++;
                continue;
            }
                        constant += sign * v;
            sign = left;
        }
                if ( term == 0 ) return constant==0 ? "Infinite solutions" : "No solution";
        Console.WriteLine($"constant={constant} term={term}");
        return $"x={-constant/ term}";
    }
}
