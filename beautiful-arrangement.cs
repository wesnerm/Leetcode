// 526. Beautiful Arrangement   
// https://leetcode.com/problems/beautiful-arrangement
// Medium 55.2%
// 439.0371416588606
// Submission: https://leetcode.com/submissions/detail/111577872/
// Runtime: 146 ms
// Your runtime beats 74.42 % of csharp submissions.

public class Solution {
        public int CountArrangement(int N) {
        var list = new List<int>(N);
        for (int i=1; i<=N; i++)
            list.Add(i);
                int count = Dfs(list, 0, N);
        return count;
    }
        int Dfs(List<int> list, int index, int n)
    {
        if (index==n) return 1;
                int count = 0;
        var save = list[index];
        for (int i=index; i<n; i++)
        {
            var save2 = list[i];                        
            if (save2 % (index+1) != 0 && (index+1) % save2 != 0 ) continue;
                        list[index] = save2;
            list[i] = save;
                        count += Dfs(list, index+1, n);
                        list[i] = save2;
        }
        list[index] = save;
                return count;
    }
}
