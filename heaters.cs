// 475. Heaters   
// https://leetcode.com/problems/heaters
// Easy 29.5%
// 351.8843789884197
// Submission: https://leetcode.com/submissions/detail/102776494/
// Runtime: 279 ms
// Your runtime beats 4.55 % of csharp submissions.

public class Solution {
    public int FindRadius(int[] houses, int[] heaters) {
                Array.Sort(houses);
        Array.Sort(heaters);
        if (houses.Length==0 || heaters.Length==0) return 0;
            int iheater = 0;
        int mindist = 0;
        foreach(var h in houses)
        {
            int dist = Math.Abs(h - heaters[iheater]);
            while (iheater+1 < heaters.Length && Math.Abs(h-heaters[iheater+1]) <= dist)
            {
                iheater++;
                dist = Math.Abs(h-heaters[iheater]);
            }
            mindist = Math.Max(mindist, dist);            
        }
        return mindist;
    }
}
