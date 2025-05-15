// 106. Construct Binary Tree from Inorder and Postorder Traversal   
// https://leetcode.com/problems/construct-binary-tree-from-inorder-and-postorder-traversal
// Medium 31.7%
// 591.6688165435683
// Submission: https://leetcode.com/submissions/detail/70740234/
// Runtime: 180 ms
// Your runtime beats 27.69 % of csharp submissions.

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
    Dictionary<int, int> positions = new Dictionary<int,int>();
        public TreeNode BuildTree2(int[] inorder, int[] postorder) {
        if (inorder.Length != postorder.Length)
            return null;
                    int n = inorder.Length;
        for (int i=0; i<n; i++)
            positions[inorder[i]] = i;
                    return Core(inorder, 0, postorder, 0, n);
    }
        TreeNode Core(int[] inorder, int istart, int[] postorder, int pstart, int n)
    {
        if (n<=0)
            return null;
                    int val = postorder[pstart+n-1];
        int pos = positions[val];
        int ilen = pos-istart;
                return new TreeNode(val)
        {
            left = Core(inorder, istart, postorder, pstart, ilen),
            right = Core(inorder, pos+1, postorder, pstart+ilen, n-ilen-1)
        };
    }
        public TreeNode BuildTree(int[] inorder, int[] postorder) {
        if (inorder.Length == 0) return null;
        int ip = inorder.Length - 1;
        int pp = postorder.Length - 1;
                var stack = new Stack<TreeNode>();
        TreeNode root = new TreeNode(postorder[pp--]);
        stack.Push(root);
        while (pp >= 0) 
        {
            TreeNode prev = null;
            while (stack.Count>0 && stack.Peek().val == inorder[ip]) {
                prev = stack.Pop();
                ip--;
            }
                        var newNode = new TreeNode(postorder[pp--]);
            if (prev != null) 
                prev.left = newNode;
            else if (stack.Count>0) 
                stack.Peek().right = newNode;
            stack.Push(newNode);
        }
                return root;
    }
}
