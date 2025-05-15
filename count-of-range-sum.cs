// 327. Count of Range Sum   
// https://leetcode.com/problems/count-of-range-sum
// Hard 29.4%
// 695.4093023764144
// Submission: https://leetcode.com/submissions/detail/71524745/
// Runtime: 184 ms
// Your runtime beats 64.29 % of csharp submissions.

public class Solution {
    public int CountRangeSum(int[] nums, int lower, int upper) {
        return CountRangeSum(nums, upper)-CountRangeSum(nums, lower-1);
    }
    public int CountRangeSum2(int[] nums, int upper)
    {
        return DAC(nums, 0, nums.Length, upper);    
    }
    public int DAC(int[] nums, int start, int count, int upper)
    {
        if (count == 0) return 0;
        if (count == 1) return (upper>=nums[start]?1:0);
                int mid = start + count/2;
        int leftSize = mid-start;
        int rightSize = count - leftSize;
        int leftCount=DAC(nums,start,leftSize,upper);
        int rightCount=DAC(nums,mid,rightSize,upper);
        long[] presum = new long[rightSize];
        long pre = 0;
        for (int i=0; i<rightSize; i++)
        {
            pre = unchecked(pre + nums[mid+i]);
            presum[i] = pre;
        }
                    Array.Sort(presum, 0, rightSize);
                long suf = 0;
        int midCount = 0;
        for (int i=mid-1;i>=start; i--)
        {
            suf = unchecked(suf + nums[i]);
            int index = BisectRight(presum, upper-suf);
            midCount += index;
        }
                return midCount + leftCount + rightCount;
    }
        int BisectRight(long[] array, long target)
    {
        int left=0;
        int right=array.Length-1;
        while (left<=right)
        {
            int mid = (left+right)/2;
            var val = array[mid];
            if (target>=val)
                left = mid+1;
            else
                right = mid-1;
        }
        return left;
    }
            int MergeSort(long[] sums, long[] buffer, int left, int right, long upper)
    {
        if (left>right) return 0;
        if (left==right) return sums[left]<=upper ? 1 : 0;
        int mid = left +(right-left)/2;
        int leftHalf = MergeSort(sums, buffer, left, mid, upper);
        int rightHalf = MergeSort(sums, buffer, mid+1, right, upper);
                int count = 0;
        // Count ranges
        for (int i=left,r=mid+1; i<=mid; i++)
        {
            while (r<=right && sums[r]-sums[i] <= upper) r++;
            count += r-(mid+1);
        }
        // Merge ranges
        int j=mid+1;
        for (int i=left, k=left; k<=right; k++)
            buffer[k]= sums[i<=mid && (j>right || sums[i]<sums[j]) ? i++ : j++];
        Array.Copy(buffer, left, sums, left, right-left+1);
        return leftHalf + rightHalf + count;
    }
         public int CountRangeSum(int[] nums, int upper)
    {
        long[] sums = new long[nums.Length+1];
        for (int i=1; i<sums.Length; i++)
            sums[i] = sums[i-1] + nums[i-1];
        long[] buffer = new long[sums.Length];
                // IMPORTANT: Use start index of 1 instead of 0
        return MergeSort(sums, buffer, 1, sums.Length-1, upper);
    }
     }
