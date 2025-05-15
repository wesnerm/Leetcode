// 261. Graph Valid Tree   
// https://leetcode.com/problems/graph-valid-tree
// Medium 37.4%
// 281.9113534207577
// Submission: https://leetcode.com/submissions/detail/68216253/
// Runtime: 186 ms
// Your runtime beats 39.22 % of csharp submissions.

public class Solution {
    public bool ValidTree(int n, int[,] edges) {
        int edgeCount = edges.GetLength(0);
        if (edgeCount != n-1)
            return false;
                int[] s = new int[n];
        for (int i=0; i<n; i++)
            s[i] = i;
                    for (int i=0; i<edgeCount; i++)
        {
            int v1 = edges[i,0];
            int v2 = edges[i,1];
            if (v2<v1) { int tmp = v2; v2 = v1; v1 = tmp; }
                        var r1 = v1;
            var r2 = v2;
            while (s[r1] != r1) r1 = s[r1];
            while (s[r2] != r2) r2 = s[r2];
            if (r1 == r2) return false;
                        s[r1]=r2;
        }
                return true;
    }
}
