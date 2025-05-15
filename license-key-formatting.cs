// 482. License Key Formatting   
// https://leetcode.com/problems/license-key-formatting
// Medium 41.3%
// 495.0308271066128
// Submission: https://leetcode.com/submissions/detail/101903818/
// Runtime: 148 ms
// Your runtime beats 72.00 % of csharp submissions.

public class Solution {
    public string LicenseKeyFormatting(string S, int K) {
        var s = string.Join("", S.Split('-')).ToUpper();
                int groups = (s.Length+K-1)/K;
        int fgroup = s.Length % K;
        if (fgroup==0) fgroup = K;
                var sb = new StringBuilder();
        for (int i=0; i<s.Length; i++)
        {
            if (i>=fgroup && (i-fgroup)%K==0)
                sb.Append('-');
            sb.Append(s[i]);
        }
                return sb.ToString();
    }
}
