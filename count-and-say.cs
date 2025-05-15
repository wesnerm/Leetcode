// 38. Count and Say   
// https://leetcode.com/problems/count-and-say
// Easy 33.9%
// 1269.591235867761
// Submission: https://leetcode.com/submissions/detail/70448589/
// Runtime: 52 ms
// Your runtime beats 100.00 % of csharp submissions.

public class Solution {
    public string CountAndSay(int n) {
        if (n==1) return "1";
        var seq = CountAndSay(n-1);
                var sb = new StringBuilder();
        int i=0;
        while (i<seq.Length)
        {
            int j=i+1;
            while (j<seq.Length && seq[j]==seq[i]) j++;
            sb.Append(j-i);
            sb.Append(seq[i]);
            i=j;
        }
        return sb.ToString();
                            }
}
