// 487. Max Consecutive Ones II   
// https://leetcode.com/problems/max-consecutive-ones-ii
// Medium 44.6%
// 159.66201858521393
// Submission: https://leetcode.com/submissions/detail/101835802/
// Runtime: 219 ms
// Your runtime beats 75.00 % of csharp submissions.

public class Solution {
    public int FindMaxConsecutiveOnes(int[] nums) {
        int maxcnt = 0;
        int cnt = 0;
        int prevcnt = 0;
                for (int i=0; i<nums.Length;i++)
        {
            if (nums[i]!=1)
            {
                prevcnt = cnt+1;
                cnt = 0;
            }
            if (nums[i] == 1) cnt++;
            maxcnt = Math.Max(cnt+prevcnt, maxcnt);
        }
                return maxcnt;
    }
    }
