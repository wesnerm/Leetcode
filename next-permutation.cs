// 31. Next Permutation   
// https://leetcode.com/problems/next-permutation
// Medium 28.6%
// 795.6611954268525
// Submission: https://leetcode.com/submissions/detail/68237176/
// Runtime: 428 ms
// Your runtime beats 77.36 % of csharp submissions.

public class Solution {
    public void NextPermutation(int[] nums) {
        int len = nums.Length;
                int k;
        for (k=len-1; k>0; k--)
            if (nums[k-1]<nums[k])
                break;
                int lo=k;
        int hi=len-1;
        while (lo<hi)
            Swap(ref nums[lo++], ref nums[hi--]);
        if (k==0)
            return;
                lo=k;
        hi=len-1;
                int target = nums[k-1];
        while (lo<=hi)
        {
            int mid = lo + (hi-lo)/2;
            int v = nums[mid];
            if (target<v)
                hi = mid-1;
            else
                lo = mid+1;
        }
                Swap(ref nums[k-1], ref nums[lo]);
    }
        void Swap(ref int x, ref int y)
    {
        int tmp = x;
        x = y;
        y = tmp;
    }
            }
