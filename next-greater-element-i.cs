// 496. Next Greater Element I   
// https://leetcode.com/problems/next-greater-element-i
// Easy 57.5%
// 473.7546665053819
// Submission: https://leetcode.com/submissions/detail/105460622/
// Runtime: 402 ms
// Your runtime beats 95.56 % of csharp submissions.

public class Solution {
    public int[] NextGreaterElement(int[] findNums, int[] nums) {
        var result = new int[findNums.Length];
        var dict = new Dictionary<int, int>();
                for (int i=0; i<nums.Length; i++)
        {
            dict[nums[i]] = i;    
        }
                for (int i=0; i<findNums.Length; i++)
        {
            int f = findNums[i];
            var j = dict[f]+1;
            for (; j<nums.Length; j++)
                if (nums[j]>f)
                    break;
                                if (j<nums.Length)
                result[i] = nums[j];
            else
                result[i] = -1;
        }
                return result;
    }
}
