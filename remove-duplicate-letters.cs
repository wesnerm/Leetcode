// 316. Remove Duplicate Letters    
// https://leetcode.com/problems/remove-duplicate-letters
// Hard 29.1%
// 903.1471903467316
// Submission: https://leetcode.com/submissions/detail/73347110/
// Runtime: 112 ms
// Your runtime beats 100.00 % of csharp submissions.

public class Solution {
    public string RemoveDuplicateLetters(string s) {
/*        if (s.Length<2) return s;
                var try1 = s[0] + RemoveDuplicateLetters(s.Replace(s[0].ToString(), ""));
        var try2 = s.IndexOf(s[0], 1) >= 0
            ? RemoveDuplicateLetters(s.Substring(1))
            : null;
                    return (try2 == null || try1.CompareTo(try2) <= 0)
            ? try1 
            : try2;
*/
        var result = new StringBuilder();
        int[] counts = new int[256];
        bool[] visited = new bool[256];
                foreach(var ch in s)
            counts[ch]++;
                    foreach(var ch in s)
        {
            char prev;
            counts[ch]--;
            if (visited[ch])
                continue;
                        while (result.Length>0 && ch<(prev=result[result.Length-1]) && counts[prev]>0)
            {
                result.Length--;
                visited[prev] = false;
            }
            result.Append(ch);            
            visited[ch]=true;
        }
        return result.ToString();
    }
 }
