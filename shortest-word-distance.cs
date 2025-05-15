// 243. Shortest Word Distance   
// https://leetcode.com/problems/shortest-word-distance
// Easy 51.8%
// 553.0384566805416
// Submission: https://leetcode.com/submissions/detail/70093213/
// Runtime: 161 ms
// Your runtime beats 18.92 % of csharp submissions.

public class Solution {
    public int ShortestDistance(string[] words, string word1, string word2) {
        int iword1 = -1;
        int iword2 = -1;
        int min = int.MaxValue;
        for (int i =0; i<words.Length; i++)
        {
            var w = words[i];
            if (w==word1) iword1 = i;
            if (w==word2) iword2 = i;
            if (iword1>=0 && iword2>=0)
                min = Math.Min(min, Math.Abs(iword1-iword2));
        }
        return min;
    }
}
