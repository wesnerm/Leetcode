// 75. Sort Colors   
// https://leetcode.com/problems/sort-colors
// Medium 37.5%
// 731.4148160080085
// Submission: https://leetcode.com/submissions/detail/70556690/
// Runtime: 512 ms
// Your runtime beats 5.30 % of csharp submissions.

public class Solution {
    public void SortColors(int[] nums) {
        int left = 0;
        int right = nums.Length-1;
                for (int i=0; i<=right; )
        {
            switch(nums[i])
            {
                case 0: Swap(ref nums[i++], ref nums[left++]); break;
                case 2: Swap(ref nums[i], ref nums[right--]); break;
                default: i++; break;
            }
        }
    }
        public void Swap(ref int a, ref int b)
    {
        int tmp = a;
        a = b;
        b = tmp;
    }
    }
