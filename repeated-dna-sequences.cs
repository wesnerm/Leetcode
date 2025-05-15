// 187. Repeated DNA Sequences   
// https://leetcode.com/problems/repeated-dna-sequences
// Medium 30.8%
// 907.1890474008992
// Submission: https://leetcode.com/submissions/detail/71328945/
// Runtime: 548 ms
// Your runtime beats 14.89 % of csharp submissions.

public class Solution {
    public IList<string> FindRepeatedDnaSequences(string s) {
        long code = 0;
                var seen = new HashSet<long>();
        var results = new HashSet<string>();
                int i=0;
        foreach(var c in s)
        {
            code = ((code << 4) & 0xffffffffffL) | (c & 0xf);
            bool seenCode = seen.Contains(code);
            if (seenCode)
                results.Add(s.Substring(i-9,10));
            i++;
            if (i>=10) 
                seen.Add(code);
                            //Console.WriteLine("Code={0:x10} Seen={1} Char={2}-{3} SeenCount={4}", code, seenCode, i-1, c, seen.Count);
        }
                return results.ToList();
    }
}
