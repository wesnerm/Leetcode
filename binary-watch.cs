// 401. Binary Watch   
// https://leetcode.com/problems/binary-watch
// Easy 44.8%
// 547.490702650873
// Submission: https://leetcode.com/submissions/detail/74818744/
// Runtime: 322 ms
// Your runtime beats 100.00 % of csharp submissions.

public class Solution {
    public IList<string> ReadBinaryWatch(int num)
    {
        var hourList = Enumerable.Range(0,12).ToLookup(i=>CountBits(i));
        var minList = Enumerable.Range(0,60).ToLookup(i=>CountBits(i));
            var result = new List<string>();
        for (int i = 0; i < 4; i++)
        {
            int j = num - i;
            if (j>=0 && j<6)
                result.AddRange(
                    from hr in hourList[i]
                    from mn in minList[j]
                    select string.Format("{0}:{1:00}", hr, mn));
        }
        return result;
    }
        public int CountBits(int n)
    {
        int bits = 0;
        while (n != 0)
        {
            n &= n - 1;
            bits++;
        }
        return bits;
    }
}
