// 127. Word Ladder   
// https://leetcode.com/problems/word-ladder
// Medium 19.3%
// 840.0840110301942
// Submission: https://leetcode.com/submissions/detail/71112663/
// Runtime: 312 ms
// Your runtime beats 89.61 % of csharp submissions.

public class Solution {
    public int LadderLength(string beginWord, string endWord, ISet<string> wordList) {
        int count = wordList.Count;
                if (beginWord.Length != endWord.Length) return 0;
        if (beginWord == endWord) return 1;
                 var seen = new HashSet<string>();
        var q = new Queue<string>();
        q.Enqueue(beginWord);
        seen.Add(beginWord);
                int length = 1;
        while (q.Count > 0)
        {
            int c = q.Count;
            length++;
            for (int i=0; i<c; i++)
            {
                var pop = q.Dequeue();
                foreach(var cand in Candidates(pop))
                {
                    if (cand == endWord) return length;
                    if (!wordList.Contains(cand) || seen.Contains(cand)) continue;
                    q.Enqueue(cand);
                    seen.Add(cand);
                }
            }
        }
        return 0;         
    }
            public IEnumerable<string> Candidates(string word)
    {
        var sb = new StringBuilder(word);
                for (int i=0; i<word.Length; i++)
        {
            var orig = sb[i];
            for (char c='a'; c<='z'; c++)
            {
                if (c == orig) continue;
                sb[i] = c;
                yield return sb.ToString();
            }
            sb[i] = orig;
        }
    }
    }
