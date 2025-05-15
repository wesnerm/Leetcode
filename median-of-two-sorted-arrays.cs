// 4. Median of Two Sorted Arrays   
// https://leetcode.com/problems/median-of-two-sorted-arrays
// Hard 21.6%
// 2025.5995190965932
// Submission: https://leetcode.com/submissions/detail/106583574/
// Runtime: 202 ms
// Your runtime beats 80.13 % of csharp submissions.

    public class Solution
    {
        //// MAIN ROUTINE
                // Accepted: 168 100% 
        public double FindMedianSortedArrays(int[] nums1, int[] nums2) 
        {
            // We want the smaller element on the left side
            // -- it reduces chances of out of bounds errors and also lowers running time
            if (nums1.Length > nums2.Length)
                return FindMedianSortedArrays(nums2, nums1);
                        int k = (nums1.Length + nums2.Length - 1)/2;  // k is the index of the first median point
            int left = 0;
            int right = nums1.Length-1;
            while (left <= right)
            {
                int mid1 = (left + right)/2;
                int mid2 = k - mid1;
                if (nums1[mid1] < nums2[mid2])
                    left = mid1+1;
                else
                    right = mid1-1;
            }
                double median = Math.Max( right>=0? nums1[right] : int.MinValue, k-left>=0 ? nums2[k-left] : int.MinValue );
            if ( (nums1.Length+nums2.Length)%2 == 1 ) return median;
                        double median2 = Math.Min (left<nums1.Length ? nums1[left] : int.MaxValue,
                                k-right < nums2.Length ? nums2[k-right] : int.MaxValue);
            return (median + median2)/2;
        }
    // ===================================== Alternative ============================
                public double FindMedianSortedArrays2(int[] nums1, int[] nums2)
        {
            int len = nums1.Length + nums2.Length;
            int k = (len + 1) / 2;
            int v = FindKth(nums1, nums2, k);
            if (len % 2 == 1) return v;
            return (v + FindKth(nums1, nums2, k + 1)) * .5;
        }
                public int FindKth(int[] nums1, int[] nums2, int kth)
        {
            if (nums1.Length > nums2.Length)
                return FindKth(nums2, nums1, kth);
            int k = kth-1;
            if (k < 0) return int.MinValue;
            if (k >= nums1.Length + nums2.Length) return int.MaxValue;
                        int left = 0;
            int right = Math.Min(k, nums1.Length-1);
            while (left <= right)
            {
                int mid1 = left + (right-left)/2;
                int mid2 = k - mid1;
                int val2 = mid2<nums2.Length ? nums2[mid2] : int.MaxValue;
                if (nums1[mid1] < val2)
                    left = mid1+1;
                else
                    right = mid1-1;
            }
                return Math.Max( right>=0? nums1[right] : int.MinValue, k-left>=0 ? nums2[k-left] : int.MinValue );
        }
    }
