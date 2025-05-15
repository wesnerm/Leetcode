// 514. Freedom Trail   
// https://leetcode.com/problems/freedom-trail
// Hard 36.5%
// 221.73238509346092
// Submission: https://leetcode.com/submissions/detail/105460439/
// Runtime: 122 ms
// Your runtime beats 100.00 % of csharp submissions.

using System;
public class Solution {
        int[,] min;
    string ring;
    string key;
        public int FindRotateSteps(string ring, string key) {
        this.ring = ring;
        this.key = key;
        min = new int[ring.Length, key.Length];
        return FindRotateSteps(0, 0);
    }
    int FindRotateSteps(int rpos, int kpos)
    {
        if (kpos>=key.Length)
            return 0;
                if (min[rpos, kpos]>0) 
            return min[rpos, kpos]-1;
                    int c = key[kpos];
        int m = int.MaxValue/2;
        for (int i=0; i<ring.Length; i++)
        {
            if (ring[i] == c)
            {
                int rot = Math.Min( Math.Abs(i-rpos), (rpos+ring.Length - i));
                rot = Math.Min( rot, i+ring.Length - rpos);
                int tr = FindRotateSteps(i, kpos+1) + rot + 1;
                if (tr < m)
                    m = tr;
            }
        }
                min[rpos, kpos] = m+1;
        return m;
    }
        }
