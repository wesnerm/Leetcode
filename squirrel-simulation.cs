// 573. Squirrel Simulation   
// https://leetcode.com/problems/squirrel-simulation
// Medium 49.8%
// 0
// Submission: https://leetcode.com/submissions/detail/105459191/
// Runtime: 175 ms
// Your runtime beats 84.21 % of csharp submissions.

using static System.Math;
public class Solution {
    public int MinDistance(int height, int width, int[] tree, int[] squirrel, int[,] nuts) {
        int dist = 0;
        int length = nuts.GetLength(0);
        for (int i=0; i<length; i++)
        {
            var nd = Abs(nuts[i,0]-tree[0]) + Abs(nuts[i,1]-tree[1]); 
            dist += nd;
        }
        int sdist = int.MaxValue;
        for (int i=0; i<length; i++)
        {
            var nd = Abs(nuts[i,0]-tree[0]) + Abs(nuts[i,1]-tree[1]); 
            var sd = Abs(nuts[i,0]-squirrel[0]) + Abs(nuts[i,1]-squirrel[1]);
            var d = dist * 2 - nd + sd;            
                        if (d < sdist)
                sdist = d;
        }
                return sdist;
    }
}
