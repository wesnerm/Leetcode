// 93. Restore IP Addresses   
// https://leetcode.com/problems/restore-ip-addresses
// Medium 26.8%
// 676.4741275575058
// Submission: https://leetcode.com/submissions/detail/71287216/
// Runtime: 420 ms
// Your runtime beats 74.14 % of csharp submissions.

public class Solution {
    public IList<string> RestoreIpAddresses(string s) {
        List<string> list = new List<string>();
        Dfs(list,s,new StringBuilder(), 4,0);
        return list;
    }
        void Dfs(List<string> list, string s, StringBuilder sb, int k, int pos)
    {
        if (pos == s.Length)
        {
            if (k==0)
                list.Add(sb.ToString()); 
            return ;
        }
                if (k==0)
            return;
        int len = sb.Length;
        for (int i=pos+1; i<=pos+3 && i<= s.Length; i++)
        {
            var triple =s.Substring(pos, i-pos);
            if (triple[0]=='0' && triple.Length>1) break;
            if (int.Parse(triple) > 255) break;
            sb.Append(triple);
            if (k > 1) sb.Append('.');
            Dfs(list, s, sb, k-1, i);
            sb.Length = len;
        }
    }
}
