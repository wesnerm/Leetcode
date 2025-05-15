// 95. Unique Binary Search Trees II   
// https://leetcode.com/problems/unique-binary-search-trees-ii
// Medium 31.1%
// 626.4529079807706
// Submission: https://leetcode.com/submissions/detail/70890220/
// Runtime: 448 ms
// Your runtime beats 4.88 % of csharp submissions.

/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Solution {
    public IList<TreeNode> GenerateTrees(int n) {
        if (n==0)
            return new TreeNode[0];
                    return NumTrees(1, n).ToList();
    }
        public IEnumerable<TreeNode> NumTrees(int lo, int hi)
    {
        if (lo>=hi) 
        {
            yield return lo==hi ? new TreeNode(lo) : null;
            yield break;
        }
        for (int mid=lo; mid <=hi; mid++)
            foreach(var left in NumTrees(lo, mid-1))
            foreach(var right in NumTrees(mid+1, hi))
                yield return new TreeNode(mid)
                { 
                    left = left,
                    right = right
                };
    }
}
