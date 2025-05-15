// 338. Counting Bits   
// https://leetcode.com/problems/counting-bits
// Medium 60.7%
// 1188.3694133782901
// Submission: https://leetcode.com/submissions/detail/71199441/
// Runtime: 432 ms
// Your runtime beats 18.28 % of csharp submissions.

public class Solution {
    public int[] CountBits(int num) {
        int [] results = new int[num+1];
        for (int i=1; i<results.Length; i++)
            // results[i] = results[i>>1] + (i&1);
            results[i] = results[i&i-1] + 1;
        return results;
    }
}
