// 117. Populating Next Right Pointers in Each Node II   
// https://leetcode.com/problems/populating-next-right-pointers-in-each-node-ii
// Medium 33.7%
// 588.4466950090994
// Submission: https://leetcode.com/submissions/detail/70015061/
// Runtime: 40 ms
// Your runtime beats 12.29 % of cpp submissions.

/**
 * Definition for binary tree with next pointer.
 * struct TreeLinkNode {
 *  int val;
 *  TreeLinkNode *left, *right, *next;
 *  TreeLinkNode(int x) : val(x), left(NULL), right(NULL), next(NULL) {}
 * };
 */
class Solution {
public:
    void connect(TreeLinkNode *root) {
        connect(root, 0);
    }
        TreeLinkNode *connect(TreeLinkNode *node, TreeLinkNode *next)
    {
        if (!node)
            return next;
        node->next = next;
                TreeLinkNode *nextChild = 0;
        while(next)
        {
            nextChild = next->left ? next->left : next->right;
            if (nextChild)
                break;
            next = next->next;
        }
        nextChild = connect(node->right, nextChild);
        connect(node->left, nextChild);
        return node;
    }
};
