// 105. Construct Binary Tree from Preorder and Inorder Traversal   
// https://leetcode.com/problems/construct-binary-tree-from-preorder-and-inorder-traversal
// Medium 31.7%
// 733.9574534067904
// Submission: https://leetcode.com/submissions/detail/70739520/
// Runtime: 164 ms
// Your runtime beats 49.50 % of csharp submissions.

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
    public TreeNode BuildTree2(int[] preorder, int[] inorder) {
        if (inorder.Length != preorder.Length)
            return null;
                    int n = inorder.Length;
        for (int i=0; i<n; i++)
            positions[inorder[i]] = i;
                    return Core(inorder, 0, preorder, 0, n);
    }
        TreeNode Core(int[] inorder, int istart, int[] preorder, int pstart, int n)
    {
        if (n<=0)
            return null;
                    int val = preorder[pstart];
        int pos = positions[val];
        int ilen = pos-istart;
                return new TreeNode(val)
        {
            left = Core(inorder, istart, preorder, pstart+1, ilen),
            right = Core(inorder, pos+1, preorder, pstart+1+ilen, n-ilen-1)
        };
    }
        public TreeNode BuildTree(int[] preorder, int[] inorder)
    {
        if (preorder.Length==0) return null;    
        int i=0, j=0;
        var root = new TreeNode(preorder[i++]);
        var stack = new Stack<TreeNode>();
        stack.Push( root );
                while (true)
        {
            if (stack.Peek().val!=inorder[j])
                stack.Push(stack.Peek().left = new TreeNode(preorder[i++]));
            else
            {
                if (++j == inorder.Length) break;
                var p = stack.Pop();
                if (stack.Count == 0 || inorder[j] != stack.Peek().val) 
                    stack.Push(p.right = new TreeNode(preorder[i++]));
            }
        }
                return root;
   }
}
