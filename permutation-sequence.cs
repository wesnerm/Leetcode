// 60. Permutation Sequence   
// https://leetcode.com/problems/permutation-sequence
// Medium 28.0%
// 630.3014136454176
// Submission: https://leetcode.com/submissions/detail/70825092/
// Runtime: 52 ms
// Your runtime beats 100.00 % of csharp submissions.

public class Solution {
    public string GetPermutation(int n, int k) {
        var list = new StringBuilder(n);
        for (int i=0; i<n; i++) list.Append(i+1);
                int perm = 1;
        for (int i=1; i<=n; i++) perm *= i;
                k--;
        k %= perm;
        int start = 0;
        for (; k > 0 && start < n; start++)
        {
            perm /= n-start;
                        // if (k<perm) continue;
                            int i = (int)(k/perm);
            k %= perm;
                        var x = list[start+i];
            list.Remove(start+i,1);
            list.Insert(start, x);
        }
                return list.ToString();
    }
}
