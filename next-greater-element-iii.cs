// 556. Next Greater Element III   
// https://leetcode.com/problems/next-greater-element-iii
// Medium 28.0%
// 192.08661873469168
// Submission: https://leetcode.com/submissions/detail/102778392/
// Runtime: 65 ms
// Your runtime beats 13.79 % of csharp submissions.

using System.Text;
public class Solution {
    public int NextGreaterElement(int n) {
        var sb = new StringBuilder(n.ToString());
                int i=sb.Length-1;
        while (i>0 && sb[i-1]>=sb[i])
            i--;
        if (i==0) return -1;
                int j=i;
        while (j+1<sb.Length && sb[j+1]>sb[i-1])
            j++;
        if (sb[i-1] == sb[j]) return -1;
                var tmp = sb [i-1];
        sb[i-1] = sb[j];
        sb[j] = tmp;
                int left = i;
        int right = sb.Length-1;
        while (left < right)
        {
            var t = sb[left];
            sb[left++] = sb[right];
            sb[right--] = t;
        }
        int d;        
        var s = sb.ToString();
        return int.TryParse(s, out d) ? d : -1;
    }
}
