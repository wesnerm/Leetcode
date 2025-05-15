// 491. Increasing Subsequences   
// https://leetcode.com/problems/increasing-subsequences
// Medium 38.8%
// 181.1151390057661
// Submission: https://leetcode.com/submissions/detail/101885893/
// Runtime: 649 ms
// Your runtime beats 33.33 % of csharp submissions.

using System;
using System.Collections.Generic;
using System.Linq;
public class Solution {
    public IList<IList<int>> FindSubsequences(int[] nums) {
        var answers = new HashSet<IList<int>>(new Comparer());
        Dfs(new List<int>(), answers, nums, 0);
                return answers.ToList();
    }
        public void Dfs(List<int> buffer, HashSet<IList<int>> answers, int[] nums, int index)
    {
        if (index>=nums.Length)
        {
            if (buffer.Count>1)
                answers.Add(buffer.ToList());
            return;
        }
        Dfs(buffer, answers, nums, index+1);
                var v = nums[index];
        if (buffer.Count>0 && v<buffer[buffer.Count-1])
            return;
                buffer.Add(v);
        Dfs(buffer, answers, nums, index+1);
        buffer.RemoveAt(buffer.Count-1);
    }
        public class Comparer : IEqualityComparer<IList<int>>
    {
        public int GetHashCode(IList<int> list)
        {
            long hashcode = 0;
            foreach(var v in list)
                hashcode = unchecked(hashcode*31 + v.GetHashCode()); 
            return (int)(hashcode & int.MaxValue);
        }
                public bool Equals(IList<int> a, IList<int> b)
        {
            if (a.Count != b.Count) return false;
            for (int i=0; i<a.Count; i++)
                if (a[i] != b[i]) return false;
            return true;
        }
    }
    }
