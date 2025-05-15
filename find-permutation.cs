// 484. Find Permutation   
// https://leetcode.com/problems/find-permutation
// Medium 53.1%
// 210.5984813311042
// Submission: https://leetcode.com/submissions/detail/101885837/
// Runtime: 532 ms
// Your runtime beats 33.33 % of csharp submissions.

using System;
public class Solution {
    public int[] FindPermutation(string s) {
        int j = 0;
        int cur = 1;
                var list = new List<int>();
        bool emit = true;
                while (j<s.Length)
        {
            int count = 0;
            var dir = s[j];
            while (j<s.Length && s[j]==dir)
            {
                j++;
                count++;
            }
                        if (emit) count++;
            if (dir == 'D')
            {
                for (int i=0; i<count; i++)
                    list.Add(cur+count-1 -i);
                cur += count;
                emit = false;
            }
            else
            {
                for (int i=0; i<count-1; i++)
                    list.Add(cur+i);
                cur += count-1;
                emit = true;
            }
        }
                if (emit)
            list.Add(cur);
                return list.ToArray();
    }
}
