// 33. Search in Rotated Sorted Array   
// https://leetcode.com/problems/search-in-rotated-sorted-array
// Medium 32.1%
// 970.0965895015561
// Submission: https://leetcode.com/submissions/detail/69762725/
// Runtime: 168 ms
// Your runtime beats 8.75 % of csharp submissions.

public class Solution {
    public int Search(int[] nums, int target) {
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
                return (mid+minIndex)%nums.Length;
        }
        return -1;
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
                end--;
        }
                return end;
    }
}
