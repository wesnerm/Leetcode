// 455. Assign Cookies   
// https://leetcode.com/problems/assign-cookies
// Easy 47.0%
// 449.93606443374307
// Submission: https://leetcode.com/submissions/detail/101885223/
// Runtime: 198 ms
// Your runtime beats 70.31 % of csharp submissions.

public class Solution {
    public int FindContentChildren(int[] g, int[] s) {
      Array.Sort(s);
      Array.Sort(g);
            int max = 0;
            int i = s.Length-1;
      int j = g.Length-1;
            while (j>=0 && i>=0)
      {
          if (s[i]>=g[j])
          {
              j--;
              i--;
              max++;
          }
          else
          {
              j--;
          }
      }
            return max;
    }
    }
