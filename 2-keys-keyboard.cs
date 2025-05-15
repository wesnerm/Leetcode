// 650. 2 Keys Keyboard   New
// https://leetcode.com/problems/2-keys-keyboard
// Medium 39.8%
// 91.42930913743068
// Submission: https://leetcode.com/submissions/detail/112120307/
// Runtime: 59 ms
// Your runtime beats 80.49 % of csharp submissions.

public class Solution {
    int[] save = new int[1001];
        public int MinSteps(int n) {
        if (n==1) return 0;
        if (save[n] != 0) return save[n];
                int min = n;
        for (int i=2; i*i<=n; i++)
        {
            if (n%i!=0) continue;
            int tmp = i + MinSteps(n/i);
            if (tmp<min) min = tmp;
        }
                save[n] = min;
        return min;
    }
}
