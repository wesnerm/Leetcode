// 557. Reverse Words in a String III   
// https://leetcode.com/problems/reverse-words-in-a-string-iii
// Easy 60.2%
// 607.6596533011694
// Submission: https://leetcode.com/submissions/detail/101894100/
// Runtime: 205 ms
// Your runtime beats 17.50 % of csharp submissions.

public class Solution {
    public string ReverseWords(string s) {
        var sb = new StringBuilder(s+" ");
        var left = 0;
                for (int i=0; i<sb.Length; i++)
        {
            var ch = sb[i];
            if (char.IsWhiteSpace(ch))
            {
                int right = i-1;
                while (left <= right)
                {
                    var tmp = sb[left];
                    sb[left++] = sb[right];
                    sb[right--] = tmp;
                }
                left = i+1;                
            }
        }
                sb.Length --;
        return sb.ToString();
    }
}
