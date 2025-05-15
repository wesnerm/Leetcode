// 259. 3Sum Smaller   
// https://leetcode.com/problems/3sum-smaller
// Medium 41.2%
// 435.6799252832697
// Submission: https://leetcode.com/submissions/detail/67713040/
// Runtime: 144 ms
// Your runtime beats 44.44 % of csharp submissions.

public class Solution {
    public int ThreeSumSmaller(int[] nums, int target) {
        if (nums.Length<3) return 0;
        int count = 0;
        Array.Sort(nums);
        for (int i=0; i<nums.Length; i++)
        {
            int left = i+1;
            int right = nums.Length-1;
            int tmpTarget = target - nums[i];
            if (nums[i]*2 >= tmpTarget)
                break;
                            while (left < right)
            {
                if (nums[left]+nums[right] < tmpTarget)
                    count += right-left++;
                else
                    right--;
            }
        }
        return count;
    }
}
