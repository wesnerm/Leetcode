// 398. Random Pick Index   
// https://leetcode.com/problems/random-pick-index
// Medium 42.0%
// 344.3315038842249
// Submission: https://leetcode.com/submissions/detail/74816889/
// Runtime: 139 ms
// Your runtime beats 10.74 % of cpp submissions.

class Solution {
public:
    vector<int> array;
    Solution(vector<int> nums) {
        array = nums;
    }
        int pick(int target) {
        int found = 0;
        int index = -1;
        int r = rand();
        for (int i=0; i<array.size(); i++)
            if (array[i]==target && r% ++found == 0)
                index = i;
        return index;
    }
};
/**
 * Your Solution object will be instantiated and called as such:
 * Solution obj = new Solution(nums);
 * int param_1 = obj.pick(target);
 */
