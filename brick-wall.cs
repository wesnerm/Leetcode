// 554. Brick Wall   
// https://leetcode.com/problems/brick-wall
// Medium 43.4%
// 203.03304046521615
// Submission: https://leetcode.com/submissions/detail/104602152/
// Runtime: 232 ms
// Your runtime beats 31.51 % of csharp submissions.

public class Solution {
    public int LeastBricks(IList<IList<int>> wall) {
        var dict = new Dictionary<int, int>();
        foreach(var layer in wall)
        {
            int index = 0;
            foreach(var v in layer)
            {
                index+=v;
                if (!dict.ContainsKey(index)) dict[index] = 0;
                dict[index]++;
            }
            dict.Remove(index);
        }
                int min = wall.Count;
        //Console.WriteLine(string.Join(" ", dict.Select(x=>$"{x.Key}={x.Value}")));
        foreach(var v in dict.Values)
        {
            var b = wall.Count - v;
            if (min > b) min = b;
        }
        return min;
    }
}
