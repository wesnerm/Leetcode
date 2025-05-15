// 454. 4Sum II   
// https://leetcode.com/problems/4sum-ii
// Medium 45.9%
// 407.35872261194555
// Submission: https://leetcode.com/submissions/detail/101885262/
// Runtime: 795 ms
// Your runtime beats 0.00 % of csharp submissions.

public class Solution {
    public int FourSumCount(int[] a, int[] b, int[] c, int[] d) {
        int[] nums1 = new int[a.Length*b.Length];
        int[] nums2 = new int[c.Length*d.Length];
                int index = 0;
        for (int aa=0; aa<a.Length; aa++)
            for (int bb=0; bb<b.Length; bb++)
            {
                nums1[index] = a[aa] + b[bb];
                nums2[index] = c[aa] + d[bb];
                index++;
            }
        Array.Sort(nums1);
        Array.Sort(nums2);
                int count = 0;
        for (int i=0; i<nums1.Length; i++)
        {
            int target = nums1[i];
            int t1 = BinSearch(nums2, -target);
            int t2 = BinSearch(nums2, 1-target);
            count += t2-t1;
        }
        return count;
    }
        public int BinSearch(int[] array, int target)
    {
        int left =0;
        int right=array.Length-1;
        while (left<=right)
        {
            int mid = left +(right-left)/2;
            if (target > array[mid])
                left = mid + 1;
            else
                right = mid - 1;
        }
        return left;
    }
        public int BinSearch2(int[] array, int target)
    {
        int left =0;
        int right=array.Length-1;
        while (left<=right)
        {
            int mid = left +(right-left)/2;
            if (target >= array[mid])
                left = mid + 1;
            else
                right = mid - 1;
        }
        return left;
    }
}
