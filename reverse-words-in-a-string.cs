// 151. Reverse Words in a String   
// https://leetcode.com/problems/reverse-words-in-a-string
// Medium 15.7%
// 1479.739909698991
// Submission: https://leetcode.com/submissions/detail/68813820/
// Runtime: 79 ms
// Your runtime beats 100.00 % of csharp submissions.

public class Solution {
    public string ReverseWords(string s) {
        var sb = new StringBuilder();
        int end = s.Length;
        for (int i=s.Length-1; i>=-1; i--)
        {
            if (i>=0 && !char.IsWhiteSpace(s[i]))
                continue;
                    int start = i+1;                
            if (start < end)
            {
                if (sb.Length>0)
                    sb.Append(' ');
                sb.Append(s, start, end-start);
            }
            end = i;
        }
                return sb.ToString();
    }
        void Reverse(StringBuilder sb, int left, int right)
    {
        while (left < right)
        {
            char tmp = sb[left];
            sb[left++] = sb[right];
            sb[right--] = tmp;
        }
    }
}
