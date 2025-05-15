// 418. Sentence Screen Fitting   
// https://leetcode.com/problems/sentence-screen-fitting
// Medium 27.3%
// 365.04392891818634
// Submission: https://leetcode.com/submissions/detail/101881625/
// Runtime: 172 ms
// Your runtime beats 40.00 % of csharp submissions.

public class Solution {
    public int WordsTyping(string[] sentence, int rows, int cols) {
        if (sentence.Length==0) return 0;
                int r = 0;
        int c = 0;
        var dict = new Dictionary<int, int>();        
                int totalLen = Math.Max(0, sentence.Sum(x=>x.Length+1)-1);
        for (int count=0; ; count++)
        {
            if ( totalLen < cols-c )
            {
                int scnt=(cols-c)/(totalLen+1);
                count += scnt;
                c += scnt * (totalLen+1);
            }
            for (int i=0; i<sentence.Length; i++)
            {
                int wordlen = sentence[i].Length;
                if (wordlen > cols)
                    return 0;
                                    c+=wordlen;
                if (c>cols)
                {
                    r++;
                    c=wordlen;
                }
                c++;
            }
            if (r>=rows)
                return count;
        }
    }
        }
