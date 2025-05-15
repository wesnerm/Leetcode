// 314. Binary Tree Vertical Order Traversal   
// https://leetcode.com/problems/binary-tree-vertical-order-traversal
// Medium 36.2%
// 425.3004805653251
// Submission: https://leetcode.com/submissions/detail/69814648/
// Runtime: 448 ms
// Your runtime beats 53.85 % of csharp submissions.

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
    public IList<IList<int>> VerticalOrder(TreeNode root) {
        var dict = new Dictionary<int, IList<int>>();
        var q = new Queue<Data>();
        q.Enqueue(new Data{root=root});
                while (q.Count>0)
        {
            var d = q.Dequeue();
            if (d.root == null)
                continue;
            if (!dict.ContainsKey(d.pos))
                dict[d.pos] = new List<int>();
            dict[d.pos].Add(d.root.val);
                            q.Enqueue(new Data{root=d.root.left, pos=d.pos-1});
            q.Enqueue(new Data{root=d.root.right, pos=d.pos+1});
        }
                return dict.OrderBy(x=>x.Key).Select(x=>x.Value).ToList();
    }
    public class Data
    {
        public TreeNode root;
        public int pos;
    }
    }
