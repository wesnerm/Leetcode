// 276. Paint Fence   
// https://leetcode.com/problems/paint-fence
// Easy 34.2%
// 477.74706567638543
// Submission: https://leetcode.com/submissions/detail/68206644/
// Runtime: 52 ms
// Your runtime beats 27.27 % of csharp submissions.

public class Solution {
        public int NumWays(int n, int k) {
            if (n==0) return 0;
        if (n==1) return k;
        if (n==2) return k*k;
                int minus2 = k;
        int minus1 = k*k;
                int result = 0;
        for (int i=3; i<=n; i++)
        {
            result = (k-1)*(minus1 + minus2);
            minus2 = minus1;
            minus1 = result;
        }
        return result;
    }
    }
