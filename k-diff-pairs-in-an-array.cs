// 532. K-diff Pairs in an Array   
// https://leetcode.com/problems/k-diff-pairs-in-an-array
// Easy 27.9%
// 258.3158375414627
// Submission: https://leetcode.com/submissions/detail/105460318/
// Runtime: 169 ms
// Your runtime beats 86.75 % of csharp submissions.

using System;
using System.Linq;
public class Solution {
    public int FindPairs(int[] nums, int k) {
        if (k<0)
            return 0;
                var hashset = new HashSet<int>(nums);
        int count = 0;
        if (k==0)
        {
            var found = new HashSet<int>();
            foreach(var v in nums)
            {
                if (!hashset.Contains(v))
                    found.Add(v);
                hashset.Remove(v);
            }
            return found.Count;
        }
        foreach(var v in hashset)
        {
            if (hashset.Contains(v+k))
                count++;
        }
        return count;
    }
}
