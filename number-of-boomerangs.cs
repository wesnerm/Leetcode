// 447. Number of Boomerangs   
// https://leetcode.com/problems/number-of-boomerangs
// Easy 44.3%
// 430.5040455972108
// Submission: https://leetcode.com/submissions/detail/101885097/
// Runtime: 652 ms
// Your runtime beats 22.50 % of csharp submissions.

public class Solution {
    public int NumberOfBoomerangs(int[,] points) 
    {
        int rows = points.GetLength(0);
        var dict = new Dictionary<int,int>[rows];
                for (int i=0; i<rows; i++)
            dict[i] = new Dictionary<int, int>();
        for (int i=0; i<rows; i++)
        for (int j=i+1; j<rows; j++)
        {
            int dx = points[i,0] - points[j,0];
            int dy = points[i,1] - points[j,1];
            int dist = dx*dx + dy*dy;
            Add(dict[i], dist, j);
            Add(dict[j], dist, i);
        }
                int count = 0;
        for (int i=0; i<rows; i++)
            foreach(var p in dict[i])
                count += p.Value * (p.Value-1);
        return count;
    }
        public void Add(Dictionary<int, int> dict, int k, int v)
    {
        if (!dict.ContainsKey(k))
            dict[k] = 0;
        dict[k]++;;
    }
}
