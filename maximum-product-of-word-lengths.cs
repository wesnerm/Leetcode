// 318. Maximum Product of Word Lengths   
// https://leetcode.com/problems/maximum-product-of-word-lengths
// Medium 43.6%
// 721.7983330250923
// Submission: https://leetcode.com/submissions/detail/68513495/
// Runtime: 216 ms
// Your runtime beats 43.48 % of csharp submissions.

public class Solution {
    public int MaxProduct(string[] words) {
        Array.Sort(words, (a,b)=>b.Length-a.Length);
        var bits = new int[words.Length];
        for (int i=0; i<words.Length; i++)
            foreach(var ch in words[i])
                bits[i] |= 1<<(ch&0x1f);
                        int maxlen = 0;
        for (int i=0; i<words.Length-1; i++)
        {
            if (words[i].Length * words[i].Length <= maxlen)
                break;
                        for (int j=i+1; j<words.Length; j++)
            {
                var length = words[i].Length * words[j].Length;
                if (length <= maxlen)
                    break;
                                    if ((bits[i] & bits[j])==0)
                    maxlen = Math.Max(maxlen, length);
            }
        }
                return maxlen;
    }
}
