// 349. Intersection of Two Arrays   
// https://leetcode.com/problems/intersection-of-two-arrays
// Easy 46.9%
// 884.6775320538851
// Submission: https://leetcode.com/submissions/detail/70004072/
// Runtime: 508 ms
// Your runtime beats 12.23 % of csharp submissions.

public class Solution {
    public int[] Intersection(int[] nums1, int[] nums2) {
        if (nums1.Length>nums2.Length)
            return Intersection(nums2, nums1);
        var set = new Dictionary<int,int>();
        foreach(var n in nums1)
            set[n] = 1;
        int size = 0;
        foreach(var n in nums2)
            if (set.ContainsKey(n) && set[n]-->0)
                size++;
        var list = new int[size];
        int i = 0;
        foreach(var n in nums2)
            if (set.ContainsKey(n) && ++set[n]>0)
                list[i++] = n;
        return list;
    }
}
