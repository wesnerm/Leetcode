// 312. Burst Balloons    
// https://leetcode.com/problems/burst-balloons
// Hard 42.3%
// 815.0014767806626
// Submission: https://leetcode.com/submissions/detail/69530659/
// Runtime: 180 ms
// Your runtime beats 26.32 % of csharp submissions.

public class Solution {
    public int MaxCoinsRecursive(int[] nums) {
        var list = new List<int>();
        list.Add(1);
        list.AddRange(nums.Where(n=>n>0));
        list.Add(1);
        var chart = new int[list.Count, list.Count];
        return MaxCoins(list, 0, list.Count-1, chart);
    }
        public int MaxCoins(List<int> list, int left, int right, int[,] chart)
    {
        if (chart[left,right]!=0)
            return chart[left,right];
        int max = 0;
        for (int i = left+1; i<right; i++)
        {
            int tmp = MaxCoins(list,left,i,chart)
                    + MaxCoins(list,i,right, chart)
                    + list[left]*list[i]*list[right];
            max = Math.Max(tmp, max);
        }
        chart[left,right]=max;
        return max;
    }
        public int MaxCoins(int[] nums) {
        var list = new List<int>();
        list.Add(1);
        list.AddRange(nums.Where(n=>n>0));
        list.Add(1);
        var chart = new int[list.Count, list.Count];
        for(int step=2; step<list.Count; step++)
        for (int left=0; left<list.Count-step;left++)
        {
            int right = left+step;
            for (int i = left+1; i<right; i++)
            {
                int tmp = chart[left,i]
                        + chart[i,right]
                        + list[left]*list[i]*list[right];
                chart[left,right] = Math.Max(chart[left,right], tmp);
            }
        }
        return chart[0, list.Count-1];
    }
}
