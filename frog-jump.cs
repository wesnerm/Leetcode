// 403. Frog Jump   
// https://leetcode.com/problems/frog-jump
// Hard 31.7%
// 439.07396939127335
// Submission: https://leetcode.com/submissions/detail/74865750/
// Runtime: 85 ms
// Your runtime beats 100.00 % of csharp submissions.

public class Solution {
        public bool CanCross(int[] stones)
        {
            if (stones.Length>1 && stones[1]!=1)
                return false;
                        return Dfs(stones, 0, 1);
        }
        public bool Dfs(int[] stones, int index, int jump)
        {
            if (index == stones.Length - 1)
                return true;
            if (index > stones.Length)
                return false;
            int stone = stones[index];
            for (int i = index + 1; i < stones.Length; i++)
            {
                int dist = stones[i] - stone;
                if (dist > jump + 1)
                    break;
                if (dist >= jump - 1 && Dfs(stones, i, dist))
                return true;
            }
            return false;
        }
                // Other approaches: 
        // priority queue
        // hashmap of positions to k
}
