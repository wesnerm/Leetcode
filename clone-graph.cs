// 133. Clone Graph   
// https://leetcode.com/problems/clone-graph
// Medium 25.1%
// 700.6979911609031
// Submission: https://leetcode.com/submissions/detail/68172068/
// Runtime: 108 ms
// Your runtime beats 36.46 % of csharp submissions.

/**
 * Definition for undirected graph.
 * public class UndirectedGraphNode {
 *     public int label;
 *     public IList<UndirectedGraphNode> neighbors;
 *     public UndirectedGraphNode(int x) { label = x; neighbors = new List<UndirectedGraphNode>(); }
 * };
 */
public class Solution {
    Dictionary<int, UndirectedGraphNode> dict;
    public UndirectedGraphNode CloneGraph(UndirectedGraphNode node) {
        // var queue = UndirectedGraphNode();
        dict = new Dictionary<int, UndirectedGraphNode>();        
        return CloneCore(node);        
    }
        public UndirectedGraphNode CloneCore(UndirectedGraphNode node) {
        if (node == null)
            return null;
                if (dict.ContainsKey(node.label))
            return dict[node.label];    
                var clone = dict[node.label] = new UndirectedGraphNode(node.label);
        foreach(var n in node.neighbors)
            clone.neighbors.Add(CloneCore(n));
                return clone;
    }
}
