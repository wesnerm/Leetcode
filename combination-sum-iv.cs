// 377. Combination Sum IV   
// https://leetcode.com/problems/combination-sum-iv
// Medium 41.6%
// 540.0143385018106
// Submission: https://leetcode.com/submissions/detail/69517243/
// Runtime: 196 ms
// Your runtime beats 4.17 % of csharp submissions.

public class Solution {
    public int CombinationSum4(int[] nums, int target) {
        // Looks like this could be solved with combinatorics
        int[] combos = new int[target+1];
                Array.Sort(nums);
        combos[0]=1;
        for (int c=0; c<combos.Length; c++)
            foreach(var n in nums)
            {
                if (n>c) break;
                // combos[c] += c==n ? 1 : combos[c-n];
                combos[c] += combos[c-n];
            }
        return combos[combos.Length-1];
    }
}
