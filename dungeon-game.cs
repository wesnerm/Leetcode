// 174. Dungeon Game   
// https://leetcode.com/problems/dungeon-game
// Hard 23.5%
// 615.5036930100799
// Submission: https://leetcode.com/submissions/detail/70734443/
// Runtime: 164 ms
// Your runtime beats 24.24 % of csharp submissions.

public class Solution {
    public int CalculateMinimumHP(int[,] dungeon) {
        int m = dungeon.GetLength(0);
        int n = dungeon.GetLength(1);
                int[] v = new int[n+1];
        for (int i = 0; i<=n; i++)
            v[i] = int.MaxValue;
        v[n-1] = 1;
        for (int i=m-1; i>=0; i--)
            for (int j=n-1; j>=0; j--)
                v[j] = (Math.Max(1, Math.Min(v[j], v[j+1]) - dungeon[i,j]));
        return v[0];        
    }
}
