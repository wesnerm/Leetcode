// 331. Verify Preorder Serialization of a Binary Tree    
// https://leetcode.com/problems/verify-preorder-serialization-of-a-binary-tree
// Medium 35.8%
// 411.2290692794971
// Submission: https://leetcode.com/submissions/detail/68589136/
// Runtime: 140 ms
// Your runtime beats 2.94 % of csharp submissions.

public class Solution {
    public bool IsValidSerialization(string preorder) {
        int degree = 1;
        foreach (var s in preorder.Split(','))
        {
            degree--;
            if (degree < 0)
                return false;
            if (s!="#") degree += 2;
        }
        return degree == 0;
    }
}
