// 647. Palindromic Substrings   
// https://leetcode.com/problems/palindromic-substrings
// Medium 56.6%
// 458.3434770984512
// Submission: https://leetcode.com/submissions/detail/111483610/
// Runtime: 132 ms
// Your runtime beats 73.17 % of csharp submissions.

public class Solution {
    public int CountSubstrings(string s) {
        var tree = new PalindromicTree("");
                int count = 0;
        foreach(var ch in s)
        {
            tree.Extend(ch);
                        for(var suffix=tree.Suffix; suffix.Length>0; suffix=suffix.SuffixLink)
                count++;
        }
                return count;
            }
        public class PalindromicTree
    {
        public StringBuilder Text;
        public List<Node> Nodes;
        public Node Root;
        public Node Empty;
        public Node Suffix;
        public PalindromicTree(string s)
        {
            Text = new StringBuilder(s.Length);
            Root = new Node { Length = -1 };
            Empty = new Node { Length = 0, SuffixLink = Root };
            Root.SuffixLink = Root;
            Suffix = Empty;
            Nodes = new List<Node>(s.Length)
            {
                Root,
                Empty,
            };
            foreach (var ch in s)
                Extend(ch);
        }
                public Node Extend(char ch)
        {
            int pos = Text.Length;
            Text.Append(ch);
            Node current;
            int pos2;
            for (current = Suffix; ; current = current.SuffixLink)
            {
                pos2 = pos - 1 - current.Length;
                if (pos2 >= 0 && Text[pos2] == ch)
                    break;
            }
            int let = ch - 'a';
            if (current.Next[let] != null)
            {
                // We found an existing palindrome
                Suffix = current.Next[let];
                return null;
            }
            var node = new Node
            {
                Length = current.Length + 2,
                InnerPalindrome = current,
                EarliestPosition = pos - current.Length - 1,
            };
            Suffix = node;
            current.Next[let] = node;
            Nodes.Add(node);
            if (node.Length == 1)
            {
                // Single character palindrome
                node.SuffixLink = Empty;
                node.Count = 1;
                return node;
            }
            do
            {
                current = current.SuffixLink;
                pos2 = pos - 1 - current.Length;
            }
            while (pos2 < 0 || Text[pos2] != ch);
            node.SuffixLink = current.Next[let];
            node.Count = 1 + node.SuffixLink.Count;
            return node;
        }
        public class Node
        {
            public Node[] Next = new Node[26];
            public Node SuffixLink;
            public Node InnerPalindrome;
            public int Length;
            public int Count;
            public int EarliestPosition;
        }
    }
}
