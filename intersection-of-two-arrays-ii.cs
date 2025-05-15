// 350. Intersection of Two Arrays II   
// https://leetcode.com/problems/intersection-of-two-arrays-ii
// Easy 44.3%
// 786.9305530095717
// Submission: https://leetcode.com/submissions/detail/70004102/
// Runtime: 532 ms
// Your runtime beats 3.19 % of csharp submissions.

public class Solution {
    public int[] Intersect(int[] nums1, int[] nums2) {
        if (nums1.Length>nums2.Length)
            return Intersect(nums2, nums1);
        var set = new Dictionary<int,int>();
        foreach(var n in nums1)
        {
            if (!set.ContainsKey(n)) set[n]=0;
            set[n]++;
        }
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
