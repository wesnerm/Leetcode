// 438. Find All Anagrams in a String   
// https://leetcode.com/problems/find-all-anagrams-in-a-string
// Easy 33.5%
// 374.4212239477128
// Submission: https://leetcode.com/submissions/detail/92221672/
// Runtime: 418 ms
// Your runtime beats 91.51 % of csharp submissions.

public class Solution {
    public IList<int> FindAnagrams(string s, string p) 
    {
        var list = new List<int>();
        var letterCount = new int[26];
        foreach(var c in p)
            letterCount[c - 'a']++;
            int count = p.Length;
        for (int i=0; i<s.Length; i++)
        {
            int j = i-p.Length;
            int c;
            if (j>=0)
            {
                // Add back
                c = s[j] - 'a';
                if (letterCount[c]++ >= 0)
                    count++;
            }
                        // Add front
            c = s[i]-'a';
            if (letterCount[c]-- >=1)
                count--;
            if (count == 0)
                list.Add(j+1);
        }        
        return list;
    }
}
