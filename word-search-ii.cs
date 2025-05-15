// 212. Word Search II   
// https://leetcode.com/problems/word-search-ii
// Hard 23.0%
// 639.253551817139
// Submission: https://leetcode.com/submissions/detail/68591557/
// Runtime: 528 ms
// Your runtime beats 74.36 % of csharp submissions.

public class Solution {
    public IList<string> FindWords(char[,] board, string[] words) {
                int m = board.GetLength(0);
        int n = board.GetLength(1);
                var res = new List<string>();
        var root = BuildTrie(words);
        for (int i=0; i<m; i++)
            for (int j=0; j<n; j++)
                Dfs(board, i,j, root, res);
        return res;
    }
        void Dfs(char[,] board, int i, int j, TrieNode p, List<string> res)
    {
        char c = board[i,j];
        if (c=='#' || p.next[c-'a'] == null) return;
        p = p.next[c-'a'];
        if (p.word != null)
        {
            res.Add(p.word);
            p.word = null;
        }
                board[i,j] ='#';
        if (i>0) Dfs(board, i-1, j, p, res);
        if (j>0) Dfs(board, i, j-1, p, res);
        if (i < board.GetLength(0) - 1) Dfs(board, i+1, j, p, res);
        if (j < board.GetLength(1) - 1) Dfs(board, i, j+1, p, res);
        board[i,j] = c;
    }
            public TrieNode BuildTrie(string [] words)
    {
        TrieNode root = new TrieNode();
        foreach(var w in words)
        {
            var p = root;
            foreach (var c in w)
            {
                int i=c-'a';
                if (p.next[i] == null) p.next[i] = new TrieNode();
                p = p.next[i];
            }
            p.word = w;
        }
        return root;
    }
            public class TrieNode
    {
        public TrieNode[] next = new TrieNode[26];
        public string word;
    }
}
