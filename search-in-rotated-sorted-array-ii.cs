// 81. Search in Rotated Sorted Array II   
// https://leetcode.com/problems/search-in-rotated-sorted-array-ii
// Medium 32.8%
// 679.4256614407777
// Submission: https://leetcode.com/submissions/detail/71409247/
// Runtime: 172 ms
// Your runtime beats 10.96 % of csharp submissions.

public class Solution {
    public bool Search2(int[] nums, int target) {
        int minIndex = FindMinIndex(nums);
        int left = 0;
        int right = nums.Length-1;
        while (left<=right)
        {
            int mid = (left+right)/2;
            int val = nums[(mid+minIndex)%nums.Length];
            if (target<val)
                right = mid-1;
            else if (target>val)
                left = mid+1;
            else
                return true;
        }
        return false;
    }
        public int FindMinIndex(int[] num) 
    {
        int start = 0;
        int end = num.Length-1;
                while (start < end)
        {
            int mid = (start+end)/2;
            if (num[mid] > num[end])
                start = mid +1;
            else if (num[mid] < num[end])
                end = mid;
            else
            {
                if (num[end-1]>num[end])
                    return end;
                end--;
            }
        }
        return end;
    }        
            public bool Search(int []nums, int target)
    {
        int left = 0;
        int right = nums.Length-1;
                while (left<=right)
        {
            int mid = (left+right)/2;
            int val = nums[mid];
            if (target == val)
                return true;
                        if (val > nums[right])
            {
                if (target<val && target>=nums[left]) right = mid-1;
                else left = mid+1;
            }
            else if (val < nums[right])
            {
                if (target>val && target<=nums[right]) left = mid+1;
                else right = mid-1;
            }
            else
            {
                right--;
            }
        }
        return false;
    }
    }
