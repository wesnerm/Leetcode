// 208. Implement Trie (Prefix Tree)   
// https://leetcode.com/problems/implement-trie-prefix-tree
// Medium 27.4%
// 713.3178908764445
// Submission: https://leetcode.com/submissions/detail/68504633/
// Runtime: 580 ms
// Your runtime beats 11.36 % of csharp submissions.

class TrieNode {
    // Initialize your data structure here.
    public TrieNode[] array;
    public bool isEnd;
        public TrieNode() {
            }
    public TrieNode Fetch(char ch, bool create)
    {
        if (array == null)
        {
            if (!create)
                return null;
            array = new TrieNode[26];
        }
        if (array[ch-'a']==null && create)
            array[ch-'a'] = new TrieNode();
        return array[ch-'a'];
    }
    }
public class Trie {
    private TrieNode root;
    private bool hasEmpty;
    public Trie() {
        root = new TrieNode();
    }
    // Inserts a word into the trie.
    public void Insert(String word) {
        var node = root;
        int index = 0;
        while (index<word.Length)
        {
            node = node.Fetch(word[index], true);
            index++;
        }
        node.isEnd = true;
    }
    // Returns if the word is in the trie.
    public bool Search(string word) {
        var node = root;
        int index = 0;
        while (index < word.Length)
        {
            node = node.Fetch(word[index], false);
            if (node == null) return false;
            index++;
        }
        return node.isEnd;
    }
    // Returns if there is any word in the trie
    // that starts with the given prefix.
    public bool StartsWith(string word) {
        var node = root;
        int index = 0;
        while (index < word.Length)
        {
            node = node.Fetch(word[index], false);
            if (node == null) return false;
            index++;
        }
        return true;
    }
        }
// Your Trie object will be instantiated and called as such:
// Trie trie = new Trie();
// trie.Insert("somestring");
// trie.Search("key");
