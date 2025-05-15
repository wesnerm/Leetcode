// 96. Unique Binary Search Trees   
// https://leetcode.com/problems/unique-binary-search-trees
// Medium 40.5%
// 1000.8964781246443
// Submission: https://leetcode.com/submissions/detail/70890538/
// Runtime: 48 ms
// Your runtime beats 63.79 % of csharp submissions.

public class Solution 
{
        int [,] cache;
        public int NumTrees(int n) {
        long count=1;
        long i;
        for (i=1;i<=n;i++)
            count = count * (i+n)/i;
        return (int)(count/i);
                //cache = new int[n+1,n+1];
        //return NumTrees(1, n);
    }
        public int NumTrees(int lo, int hi)
    {
        if (lo>=hi) 
            return 1;
        if (cache[lo,hi]>0)
            return cache[lo,hi];
                int count = 0;
                for (int mid=lo; mid <=hi; mid++)
            count += NumTrees(lo,mid-1) * NumTrees(mid+1,hi);
                cache[lo,hi] = count;
        return count;
    }
}
