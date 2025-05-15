// 247. Strobogrammatic Number II   
// https://leetcode.com/problems/strobogrammatic-number-ii
// Medium 39.2%
// 336.0590909844823
// Submission: https://leetcode.com/submissions/detail/68118000/
// Runtime: 420 ms
// Your runtime beats 100.00 % of csharp submissions.

public class Solution {
    public IList<string> FindStrobogrammatic(int n, bool zeros=false) {
        if (n==0) return new [] { "" };
        if (n==1) return new [] { "0", "1", "8" };
                var list = new List<string>();
        foreach(var item in FindStrobogrammatic(n-2, true))
        {
            if (zeros) list.Add("0"+item+"0");
            list.Add("1"+item+"1");
            list.Add("6"+item+"9");
            list.Add("8"+item+"8");
            list.Add("9"+item+"6");
        }
        return list;
    }
    }
