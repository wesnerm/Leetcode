// 632. Smallest Range   
// https://leetcode.com/problems/smallest-range
// Hard 42.5%
// 466.4217413631498
// Submission: https://leetcode.com/submissions/detail/111482455/
// Runtime: 769 ms
// Your runtime beats 33.33 % of csharp submissions.

public class Solution {
    public int[] SmallestRange(IList<IList<int>> nums) {
                int totalSize = 0;
        for (int i=0; i<nums.Count; i++)
            totalSize += nums[i].Count;
                int[][] list = new int[totalSize][];
        for (int i=0; i<list.Length; i++)
            list[i] = new int[2];
                int k = 0;
        for (int i=0; i<nums.Count; i++)
        {
            for (int j=0; j<nums[i].Count; j++)
            {
                list[k][0] = nums[i][j];
                list[k][1] = i;
                k++;
            }            
        }
        Array.Sort(list, (a,b)=>{
               int cmp = a[0].CompareTo(b[0]);
               if (cmp != 0) return cmp;
               return a[1].CompareTo(b[1]);
           });
                        int[] table = new int[nums.Count];
        int left = 0;
        int right = -1;
        int start = list[0][0];
        int end = list[list.Length-1][0];
        k = 0;
        while (left < list.Length)
        {
            while (right+1<list.Length && k<nums.Count)
            {
                int[] cur = list[++right];
                if (table[cur[1]]++ == 0) k++;
            }
            if (k == nums.Count)
            {
                int best = end-start;
                int trial = list[right][0]-list[left][0];
                if (trial<best)
                {
                    start = list[left][0];
                    end = list[right][0];
                }
            }
                        {
                int[] cur = list[left++];
                if (--table[cur[1]] == 0) k--;
            }
        }
                int[] result = new int[2];
        result[0] = start;
        result[1] = end;
        return result;
    }
}
