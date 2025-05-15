// 245. Shortest Word Distance III   
// https://leetcode.com/problems/shortest-word-distance-iii
// Medium 50.0%
// 281.2655768001437
// Submission: https://leetcode.com/submissions/detail/70093565/
// Runtime: 164 ms
// Your runtime beats 58.33 % of csharp submissions.

public class Solution {
    public int ShortestWordDistance(string[] words, string word1, string word2) {
        int iword1 = -1;
        int iword2 = -1;
        int min = int.MaxValue;
        bool same = word1==word2;
                for (int i =0; i<words.Length; i++)
        {
            var w = words[i];
            if (same)
            {
                if (w==word1)
                {
                    if (iword1 < iword2)
                        iword1 = i;
                    else
                        iword2 = i;
                }
            }
            else
            {
                if (w==word1) iword1 = i;
                if (w==word2) iword2 = i;
            }
            if (iword1>=0 && iword2>=0)
                min = Math.Min(min, Math.Abs(iword1-iword2));
        }
                        return min;        
    }
}
