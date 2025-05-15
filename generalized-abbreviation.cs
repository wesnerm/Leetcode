// 320. Generalized Abbreviation   
// https://leetcode.com/problems/generalized-abbreviation
// Medium 44.5%
// 496.1847036475816
// Submission: https://leetcode.com/submissions/detail/68502893/
// Runtime: 580 ms
// Your runtime beats 100.00 % of csharp submissions.

public class Solution {
    public IList<string> GenerateAbbreviations(string word) {
        int len = 1<<word.Length;
        var list = new List<string>();
        var sb = new StringBuilder();
        for (int i=0; i<len; i++)
        {
            sb.Clear();
            int last = -1;
            for (int j=0; j<word.Length; j++)
            {
                if ((i&(1<<j)) != 0)
                {
                    if (last != j-1)
                        sb.Append(j-1-last);
                    sb.Append(word[j]);
                    last=j;                    
                }
            }
            if (last != word.Length-1)
                sb.Append(word.Length-1 - last);
            list.Add(sb.ToString());
        }
        return list;
    }
}
