// 30. Substring with Concatenation of All Words   
// https://leetcode.com/problems/substring-with-concatenation-of-all-words
// Hard 21.8%
// 682.0489825677633
// Submission: https://leetcode.com/submissions/detail/71451870/
// Runtime: 532 ms
// Your runtime beats 60.00 % of csharp submissions.

public class Solution 
{
    public IList<int> FindSubstring(string s, string[] words) {
        var list = new List<int>();
        if (words.Length==0)
            return list;
                    int k = words[0].Length;
        var counts = new Dictionary<string, int>();
        foreach(var w in words)
        {
            if (counts.ContainsKey(w)) counts[w]++;
            else counts[w]=1;
        }
        int adjust = words.Length*k;        
        for (int offset=0; offset<k; offset++)
        {
            //Console.WriteLine("\n Round #{0}", offset);
            int goodCount=0;
            int badCount=0;
            var counts2 = new Dictionary<string, int>(counts);
            for (int i=offset; i<=s.Length-k; i+=k)
            {
                var s2 = s.Substring(i,k);
                if (counts2.ContainsKey(s2))
                {
                    var v = --counts2[s2];
                    if (v>=0) goodCount++;
                    else badCount++;
                }
                else
                    badCount++;
                                string s3 = null;
                if (i>=adjust)
                {
                    s3 = s.Substring(i-adjust,k);
                    if (counts2.ContainsKey(s3))
                    {
                        var v = ++counts2[s3];
                        if (v<=0) badCount--;
                        else goodCount--;
                    }
                    else
                        badCount--;
                }
                                //Console.WriteLine("s2={0} gc={1} bc={2} i={3} adjust={4}", s2, goodCount, badCount, i, s3);
                if (i-adjust+k>=0 && badCount==0 && goodCount==words.Length)
                    list.Add(i-adjust+k);
            }
        }
                return list;
    }
}
