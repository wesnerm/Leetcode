// 351. Android Unlock Patterns   
// https://leetcode.com/problems/android-unlock-patterns
// Medium 43.3%
// 376.5015500858154
// Submission: https://leetcode.com/submissions/detail/69590936/
// Runtime: 64 ms
// Your runtime beats 87.50 % of csharp submissions.

public class Solution {
    public int NumberOfPatterns(int m, int n) {
       // Skip array represents number to skip between two pairs
        var skip = new int[10,10];
                        skip[1,3] = skip[3,1] = 2;
        skip[1,7] = skip[7,1] = 4;
        skip[3,9] = skip[9,3] = 6;
        skip[7,9] = skip[9,7] = 8;
        skip[1,9] = skip[9,1] = skip[2,8] = skip[8,2] = skip[3,7] = skip[7,3] = skip[4,6] = skip[6,4] = 5;
        var vis= new bool[10];
        int rst = 0;
        // DFS search each length from m to n
        for(int i = m; i <= n; ++i) {
            rst += DFS(vis, skip, 1, i - 1) * 4;    // 1, 3, 7, 9 are symmetric
            rst += DFS(vis, skip, 2, i - 1) * 4;    // 2, 4, 6, 8 are symmetric
            rst += DFS(vis, skip, 5, i - 1);        // 5
        }
        return rst;        
    }
         int DFS(bool[] vis, int[,] skip, int cur, int remain) 
     {
        if(remain < 0) return 0;
        if(remain == 0) return 1;
        vis[cur] = true;
        int rst = 0;
        for(int i = 1; i <= 9; ++i) {
            // If vis[i] is not visited and (two numbers are adjacent or skip number is already visited)
            if(!vis[i] && (skip[cur,i] == 0 || (vis[skip[cur,i]]))) {
                rst += DFS(vis, skip, i, remain - 1);
            }
        }
        vis[cur] = false;
        return rst;
    }
}
