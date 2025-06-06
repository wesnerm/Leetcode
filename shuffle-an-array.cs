// 384. Shuffle an Array   
// https://leetcode.com/problems/shuffle-an-array
// Medium 46.4%
// 1093.614317290736
// Submission: https://leetcode.com/submissions/detail/71310004/
// Runtime: 358 ms
// Your runtime beats 5.66 % of java submissions.

import java.util.Random;
public class Solution {
    private int[] nums;
    private Random random;
    public Solution(int[] nums) {
        this.nums = nums;
        random = new Random();
    }
        /** Resets the array to its original configuration and return it. */
    public int[] reset() {
        return nums;
    }
        /** Returns a random shuffling of the array. */
    public int[] shuffle() {
        if(nums == null) return null;
        int[] a = nums.clone();
        for(int j = 1; j < a.length; j++) {
            int i = random.nextInt(j + 1);
            swap(a, i, j);
        }
        return a;
    }
        private void swap(int[] a, int i, int j) {
        int t = a[i];
        a[i] = a[j];
        a[j] = t;
    }
}
