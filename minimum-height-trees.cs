// 310. Minimum Height Trees   
// https://leetcode.com/problems/minimum-height-trees
// Medium 28.7%
// 373.02407068048365
// Submission: https://leetcode.com/submissions/detail/68525783/
// Runtime: 960 ms
// 

public class Solution {
    public IList<int> FindMinHeightTrees(int n, int[,] edges) {
        var g = new Dictionary<int, HashSet<int>>();
                for (int i=0; i<n; i++)
            g[i] = new HashSet<int>();
                int edgeCount = edges.GetLength(0);
        for (int i=0; i<edgeCount; i++)
        {
            AddEdge(g, edges[i,0], edges[i,1]);
            AddEdge(g, edges[i,1], edges[i,0]);
        }
        var removeList = new List<int>();
        while (g.Count > 2)
        {
            removeList.Clear();
            foreach(var k in g.Keys)
                if (g[k].Count==1)
                    removeList.Add(k);
                        foreach(var k in removeList)
                g[g[k].First()].Remove(k);
            foreach(var k in removeList)
                g.Remove(k);
        }
        return g.Keys.ToList();
    }
        private void AddEdge(Dictionary<int, HashSet<int>> g, int e1, int e2)
    {
        g[e1].Add(e2);
    }
                }
