// 140. Word Break II   
// https://leetcode.com/problems/word-break-ii
// Hard 22.9%
// 831.1808853257598
// Submission: https://leetcode.com/submissions/detail/69484976/
// Runtime: 544 ms
// Your runtime beats 48.00 % of csharp submissions.

public class Solution {
        public Dictionary<int, List<string>> dict;
        public ISet<string> set;
        int maxlen = 0;
        List<string> results;
        Trie trie;
        public int slen;
        bool[] failed;
        public IList<string> WordBreak(string s, ISet<string> wordDict)
        {
            dict = new Dictionary<int, List<string>>();
            set = wordDict;
            slen = s.Length;
            failed = new bool[slen+1];
            trie = new Trie();
            trie.Insert(wordDict);
            results = new List<string>();
            Dfs(s, "", 0);
            return results;
        }
        bool Dfs(string s, string prefix, int index)
        {
            if (index >= s.Length)
            {
                results.Add(prefix);
                return true;
            }
            if (failed[index])
                return false;
            var t = trie;
            bool foundAny = false;
            for (int i = index; i < s.Length; i++)
            {
                t = t.MoveNext(s[i]);
                if (t == null)
                    break;
                string word = t.word;
                if (word != null)
                {
                    var newPrefix = (prefix.Length > 0) ? prefix + " " + word : word;
                    foundAny |= Dfs(s, newPrefix, i + 1);
                }
            }
                        if (!foundAny)
                failed[index] = true;
            return foundAny;
        }
        public class Trie
        {
            public Trie[] next = new Trie[26];
            public string word;
            public void Insert(string word)
            {
                var p = FindPrefix(word, true);
                p.word = word;
            }
            public void Insert(IEnumerable<string> words)
            {
                foreach (var w in words)
                    Insert(w);
            }
            public bool StartsWith(string word)
            {
                return FindPrefix(word) != null;
            }
            public bool Search(string word)
            {
                var p = FindPrefix(word);
                return p != null && p.word != null;
            }
            public Trie FindPrefix(string word, bool create = false)
            {
                var p = this;
                foreach (var c in word)
                {
                    p = p.MoveNext(c, create);
                    if (p == null)
                        break;
                }
                return p;
            }
            public Trie MoveNext(char ch, bool create = false)
            {
                int i = char.ToLower(ch) - 'a';
                if (next[i] == null)
                {
                    if (!create) return null;
                    next[i] = new Trie();
                }
                return next[i];
            }
        }    
}
