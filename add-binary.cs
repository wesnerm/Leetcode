// 67. Add Binary   
// https://leetcode.com/problems/add-binary
// Easy 31.8%
// 1064.5189151656537
// Submission: https://leetcode.com/submissions/detail/70454686/
// Runtime: 128 ms
// Your runtime beats 68.64 % of csharp submissions.

public class Solution {
    public string AddBinary(string a, string b) {
        if (string.IsNullOrEmpty(a)) return b;
        if (string.IsNullOrEmpty(b)) return a;
                if (a.Length < b.Length)
            return AddBinary(b,a);
        var sb = new StringBuilder();
        int carry = 0;
        for (int i=1; i<=a.Length; i++)
        {
            int adig = a[a.Length-i]=='1' ? 1 : 0;
            int bdig = b.Length>=i && b[b.Length-i]=='1' ? 1 : 0;
            int sum = adig + bdig + carry;
            int cdig = sum & 1;
            carry = sum >> 1;
            sb.Append(cdig);
        }
                if (carry != 0) sb.Append(carry);
                int left =0;
        int right = sb.Length-1;
        while (left<right)
        {
            char tmp = sb[left];
            sb[left++] = sb[right];
            sb[right--] = tmp;
        }
                return sb.ToString();
    }
}
