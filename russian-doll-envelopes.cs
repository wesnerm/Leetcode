// 354. Russian Doll Envelopes   
// https://leetcode.com/problems/russian-doll-envelopes
// Hard 32.0%
// 539.3590945834175
// Submission: https://leetcode.com/submissions/detail/69812502/
// Runtime: 240 ms
// Your runtime beats 87.50 % of csharp submissions.

public class Solution {
    public int MaxEnvelopes(int[,] envelopes) 
    {
        int n = envelopes.GetLength(0);
        var list = new Envelope[n];
        for(int i=0; i<n; i++)
            list[i] = new Envelope{ w=envelopes[i,0], h=envelopes[i,1] };
                Array.Sort(list, (a,b)=>{
            int cmp = a.w - b.w;
            if (cmp!=0) return cmp;
            return b.h - a.h;
        });
              int[] dp = new int[n];
        int best = 0;
                /*
        for (int i=0; i<n; i++)
        {
            int max = 0;
            for (int j=0; j<i; j++)
                if (list[i].w>list[j].w && list[i].h>list[j].h)
                    max = Math.Max(dp[j], max);
            dp[i] = max + 1;
        }
                for (int i=0; i<n; i++)
            best = Math.Max(dp[i], best);
        */
                        // The sequence is already sorted by width, so we can ignore width for the remainder
        // Any subsequence we pull out will be correctly sorted by width
        // We just need to find a longest increasing subsequence by height
                for (int i=0; i<n; i++)
        {
            int index = Array.BinarySearch(dp, 0, best, list[i].h);
            if (index<0) index=~index;
            if (index>=best) best++;
            dp[index] = list[i].h;
        }
            return best;
    }
        public class Envelope
    {
        public int w;
        public int h;
    }
}
