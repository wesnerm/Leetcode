// 321. Create Maximum Number   
// https://leetcode.com/problems/create-maximum-number
// Hard 24.3%
// 550.3572589174679
// Submission: https://leetcode.com/submissions/detail/69146046/
// Runtime: 508 ms
// Your runtime beats 42.86 % of csharp submissions.

using System.Numerics;
public class Solution {
        public int[] MaxNumber(int[] nums1, int[] nums2, int k)
        {
            int[] result = new int[k];
            for (int i = Math.Max(0, k - nums2.Length);
                    i <= Math.Min(nums1.Length, k);
                    i++)
            {
                result = Max(result,
                            Merge(MaxSubarray(nums1, i),
                                    MaxSubarray(nums2, k - i)));
            }
            return result;
        }
        public int[] MaxSubarray(int[] array, int k)
        {
            int[] result = new int[k];
            int len = 0;
            for (int i = 0; i < array.Length; i++)
            {
                while (array.Length - i + len > k && len > 0 && result[len - 1] < array[i])
                    len--;
                if (len < k)
                    result[len++] = array[i];
            }
            return result;
        }
        public int[] Max(int[] array1, int[] array2, int start1 = 0, int start2 = 0)
        {
            while (start1 < array1.Length && start2 < array2.Length && array1[start1] == array2[start2])
            {
                start1++;
                start2++;
            }
            int cmp = (start1<array1.Length && start2<array2.Length)
                ? array1[start1].CompareTo(array2[start2])
                : (array1.Length - start1).CompareTo(array2.Length - start2);
            return cmp >= 0 ? array1 : array2;
        }
        public int[] Merge(int[] array1, int[] array2)
        {
            int[] result = new int[array1.Length + array2.Length];
            int i = 0, j = 0;
            for (int r = 0; r < result.Length; r++)
                result[r] = Max(array1, array2, i, j) == array1 ? array1[i++] : array2[j++];
            return result;
        }
}
