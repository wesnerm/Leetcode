// 361. Bomb Enemy   
// https://leetcode.com/problems/bomb-enemy
// Medium 38.7%
// 433.1626666478134
// Submission: https://leetcode.com/submissions/detail/69516054/
// Runtime: 224 ms
// Your runtime beats 77.27 % of csharp submissions.

public class Solution {
    public int MaxKilledEnemies(char[,] grid) {
        int rows = grid.GetLength(0);
        int cols = grid.GetLength(1);
        var ccounts = new int[cols];
        int rcounts = 0;
        int max = 0;
                // tally row counts
        for (int i=0; i<rows; i++)
        for (int j=0; j<cols; j++)
        {
            if (i==0 || grid[i-1,j]=='W')
            {
                ccounts[j] = 0;
                for (int k=i; k<rows && grid[k,j]!='W'; k++)
                    ccounts[j] += grid[k,j]=='E' ? 1 : 0;
            }
            if (j==0 || grid[i,j-1]=='W')            
            {
                rcounts = 0;
                for (int k=j; k<cols && grid[i,k]!='W'; k++)
                    rcounts += grid[i,k]=='E' ? 1 : 0;
            }
            if (grid[i,j]=='0')
                max = Math.Max(rcounts + ccounts[j], max);        
        }
        return max;
    }
    }
