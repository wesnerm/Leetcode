// 373. Find K Pairs with Smallest Sums    
// https://leetcode.com/problems/find-k-pairs-with-smallest-sums
// Medium 30.5%
// 441.22630472220567
// Submission: https://leetcode.com/submissions/detail/66627135/
// Runtime: 876 ms
// 

public class Solution {
    public IList<int[]> KSmallestPairs(int[] nums1, int[] nums2, int k) 
    {
        var ksp = new KSP { nums1=nums1, nums2=nums2, k=k };
        ksp.Solve();
        return ksp.list;
    }
        private class KSP
    {
        public int[] nums1;
        public int[] nums2;
        public int k;
        public readonly List<int[]> list = new List<int[]>();
        int[] offsets;
        public void Solve()
        {
            offsets = new int[nums1.Length];
            Solve(0, long.MaxValue);
        }
                private void Solve(int i, long upperBound)
        {
            if (i>=nums1.Length)
                return;
                        int val1 = nums1[i];
            var lowerbound = LowerBound(i+1);
            for (int j = offsets[i]; j<nums2.Length; j++)
            {
                int val2 = nums2[j];
                int sum = val1 + val2;
                if (sum>=upperBound)
                    break;
                if (sum>lowerbound)
                {
                    Solve(i+1, sum);
                    lowerbound = LowerBound(i+1);
                }
                                if (list.Count >=k)
                    return;
                list.Add(new[] { nums1[i], nums2[j] });
                offsets[i] = j+1;
            }
            Solve(i+1, upperBound);
        }
                private long LowerBound(int i)
        {
            long min = long.MaxValue;
            for (; i<offsets.Length; i++)
                if (offsets[i] < nums2.Length)
                {
                    int val = nums1[i] + nums2[offsets[i]];
                    if (val < min)
                        min = val;
                }
            return min;
        }
    }
}
