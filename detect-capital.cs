// 520. Detect Capital   
// https://leetcode.com/problems/detect-capital
// Easy 52.2%
// 347.89222810195923
// Submission: https://leetcode.com/submissions/detail/101896002/
// Runtime: 99 ms
// Your runtime beats 97.16 % of csharp submissions.

public class Solution {
    public bool DetectCapitalUse(string word) {
        int upper = 0;
        int lower = 0;
                foreach(var c in word)
        {
            if (char.IsLower(c))
                lower++;
            else
                upper++;
        }
                if (upper>1) return lower == 0;
        if (upper==1) return char.IsUpper(word[0]);
        return true;
    }
}
