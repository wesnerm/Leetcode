// 268. Missing Number   
// https://leetcode.com/problems/missing-number
// Easy 44.1%
// 929.9719841312839
// Submission: https://leetcode.com/submissions/detail/70702626/
// Runtime: 192 ms
// Your runtime beats 21.34 % of csharp submissions.

public class Solution {
    public int MissingNumber2(int[] nums) {
        for (int i=0; i<nums.Length; i++)
        {
            int j = i;
            var n = nums[j];
            while (n>=0 && n<nums.Length)
            {
                int tmp = nums[n];
                if (tmp == n)
                    break;
                                nums[j] = tmp;
                nums[n] = n;
                n = tmp;
            }
        }
                for (int i=0; i<nums.Length; i++)
            if (nums[i] != i)
                return i;
        return nums.Length;        
    }
        public int MissingNumber(int[] nums) {
        int result = nums.Length;
        int i=0;
                foreach(int num in nums){
            result ^= num;
            result ^= i;
            i++;
        }
                return result;
    }
}
