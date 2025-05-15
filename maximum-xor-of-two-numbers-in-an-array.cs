// 421. Maximum XOR of Two Numbers in an Array   
// https://leetcode.com/problems/maximum-xor-of-two-numbers-in-an-array
// Medium 45.6%
// 771.9393987482828
// Submission: https://leetcode.com/submissions/detail/111480168/
// Runtime: 239 ms
// Your runtime beats 30.00 % of csharp submissions.

public class Solution {
    public int FindMaximumXOR(int[] nums) {
        Array.Sort(nums);
                        int answer = 0;
        int mask = 0;   
        var hash = new HashSet<int>();
        for (int i=30; i>=0; i--)
        {
            int bit = 1<<i;
            mask |= bit;
                        hash.Clear();
                        foreach(var n in nums)
                hash.Add(n & mask);
                        foreach(var n in nums)
                if (hash.Contains(((answer | bit) ^ n) & mask))
                {
                    answer |= bit;
                    break;
                }
        }
                return answer;
    }
}
