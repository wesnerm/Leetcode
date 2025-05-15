// 255. Verify Preorder Sequence in Binary Search Tree   
// https://leetcode.com/problems/verify-preorder-sequence-in-binary-search-tree
// Medium 39.8%
// 423.17134500037264
// Submission: https://leetcode.com/submissions/detail/70871503/
// Runtime: 224 ms
// Your runtime beats 41.67 % of csharp submissions.

public class Solution {
    public bool VerifyPreorder(int[] preorder) {
        int i = 0;
        i = VerifyPreorder(preorder, i, int.MinValue, int.MaxValue); 
        return i == preorder.Length;
    }
        public int VerifyPreorder(int[] preorder, int i, int min, int max) {
        if (i>=preorder.Length)
            return i;
                int val = preorder[i];
        if ( val >= min && val <= max)
        {
            i = VerifyPreorder(preorder, i+1, min, val);
            i = VerifyPreorder(preorder, i, val, max);
        }
                return i;
    }
}
