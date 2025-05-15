// 493. Reverse Pairs   
// https://leetcode.com/problems/reverse-pairs
// Hard 20.0%
// 244.3626259807512
// Submission: https://leetcode.com/submissions/detail/111572083/
// Runtime: 382 ms
// Your runtime beats 92.00 % of csharp submissions.

public class Solution {
    public int ReversePairs(int[] nums) {
             int[] ind = new int[nums.Length];
        for (int i=0; i<ind.Length; i++)
            ind[i] = i;
                Array.Sort(nums, ind);
                var ft = new FenwickTree(nums.Length);
        long sum = 0;
        int count = 0;
        //Console.WriteLine(string.Join(" ", nums));
        //Console.WriteLine(string.Join(" ", ind));
                int left = 0;
        for (int right = 0; right < nums.Length; right++)
        {
            while (left<nums.Length && nums[left]*2L<nums[right])
            {                
                ft.Add(ind[left++], 1);
                count++;
            }
                        var add = count - ft.SumInclusive(ind[right]);
            //Console.WriteLine($"{nums[left]}/{ind[left]} at {left} {nums[right]}/{ind[right]} at {right} -> {add}");
            sum += add;
        }
        return (int)sum;
    }
          public class FenwickTree
    {
        public readonly long[] Array;
        public FenwickTree(long size)
        {
            Array = new long[size + 1];
        }
        public void Add(int i, long val)
        {
            if (val == 0) return;
            for (i++; i < Array.Length; i += (i & -i)) Array[i] += val;
        }
        // Sum from [0 ... i]
        public long SumInclusive(int i)
        {
            long sum = 0;
            for (i++; i > 0; i -= (i & -i)) sum += Array[i];
            return sum;
        }
        public long SumInclusive(int i, int j)
        {
            return SumInclusive(j) - SumInclusive(i - 1);
        }
    }
}
