// 3. Longest Substring Without Repeating Characters   
// https://leetcode.com/problems/longest-substring-without-repeating-characters
// Medium 24.3%
// 1616.625037794153
// Submission: https://leetcode.com/submissions/detail/69979787/
// Runtime: 164 ms
// Your runtime beats 45.95 % of csharp submissions.

public class Solution {
    public int LengthOfLongestSubstring(string s) {
        int[] pos = new int[256];
        int bestLength = 0;
        int runLength = 0;
        for (int i=0; i<s.Length; i++)
        {
            char ch = s[i];
            if ((pos[ch]-1) >= i - runLength)
                runLength = (i+1)-pos[ch];            
            else
                runLength++;
            pos[ch] = i+1;
                    if (runLength > bestLength)
                bestLength = runLength;
        }
                return bestLength;
    }
}
