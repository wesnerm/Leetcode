// 211. Add and Search Word - Data structure design   
// https://leetcode.com/problems/add-and-search-word-data-structure-design
// Medium 21.9%
// 401.22687094625064
// Submission: https://leetcode.com/submissions/detail/71394652/
// Runtime: 616 ms
// Your runtime beats 4.22 % of csharp submissions.

public class WordDictionary {
    TrieNode root = new TrieNode();
    // Adds a word into the data structure.
    public void AddWord(String word) {
        var p = root;
        foreach (var c in word)
        {
            int i=c-'a';
            if (p.next[i] == null) p.next[i] = new TrieNode();
            p = p.next[i];
        }
        p.word = word;
    }
    // Returns if the word is in the data structure. A word could
    // contain the dot character '.' to represent any one letter.
    public bool Search(string word) {
        return Search(root, word, 0);
    }
    bool Search(TrieNode node, string word, int index)
    {
        if (node == null)
            return false;
                if (index==word.Length)
            return node.word != null;
                    var ch = word[index];
        if (ch != '.')
            return Search(node.next[ch-'a'], word, index+1);
        for (int i=0; i<node.next.Length; i++)
            if (Search(node.next[i], word, index+1))
                return true;
        return false;
            }
    public class TrieNode
    {
        public TrieNode[] next = new TrieNode[26];
        public string word;
    }
}
// Your WordDictionary object will be instantiated and called as such:
// WordDictionary wordDictionary = new WordDictionary();
// wordDictionary.AddWord("word");
// wordDictionary.Search("pattern");
