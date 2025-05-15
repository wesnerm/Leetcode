// 412. Fizz Buzz   
// https://leetcode.com/problems/fizz-buzz
// Easy 58.8%
// 1369.7113695423059
// Submission: https://leetcode.com/submissions/detail/101894761/
// Runtime: 372 ms
// Your runtime beats 98.55 % of csharp submissions.

public class Solution {
    public IList<string> FizzBuzz(int n) {
        var list = new List<string>();
                for (int i=1; i<=n; i++)
        {
            var s = "";
            if (i%3==0) s += "Fizz";
            if (i%5==0) s += "Buzz";
            list.Add(s=="" ? i.ToString() : s);
        }
                return list;
    }
}
