// 41. First Missing Positive   
// https://leetcode.com/problems/first-missing-positive
// Hard 25.3%
// 871.0614842270282
// Submission: https://leetcode.com/submissions/detail/70577326/
// Runtime: 156 ms
// Your runtime beats 22.73 % of csharp submissions.

public class Solution {
    public int FirstMissingPositive(int[] nums) {
        for (int i=0; i<nums.Length; i++)
        {
            int j = i;
            var n = nums[j];
            while (n>=1 && n<=nums.Length)
            {
                int tmp = nums[n-1];
                if (tmp == n)
                    break;
                                nums[j] = tmp;
                nums[n-1] = n;
                n = tmp;
            }
        }
                for (int i=0; i<nums.Length; i++)
            if (nums[i] != i+1)
                return i+1;
        return nums.Length+1;
    }
}
