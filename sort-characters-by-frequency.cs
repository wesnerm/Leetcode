// 451. Sort Characters By Frequency   
// https://leetcode.com/problems/sort-characters-by-frequency
// Medium 50.7%
// 559.6822106581919
// Submission: https://leetcode.com/submissions/detail/101909389/
// Runtime: 176 ms
// Your runtime beats 31.34 % of csharp submissions.

public class Solution {
    public string FrequencySort(string s) {
        var freq = new int[256];
        foreach (var ch in s)
            freq[ch]++;
/*          
        int offset = 0;
        var a = new char[s.Length];
                for (int i=0; i<freq.Length; i++)
        {
            for (int j=freq[i^32]; j>0; j--)
                a[offset++] = (char)(i^32);
        }
*/
        var a = s.ToCharArray();
        Array.Sort(a, (x,y) => 
        {
            int cmp = -freq[x].CompareTo(freq[y]);
            if (cmp != 0) return cmp;
            return x.CompareTo(y);
        });
        return new string(a);
                }
}
