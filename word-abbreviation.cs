// 527. Word Abbreviation   
// https://leetcode.com/problems/word-abbreviation
// Hard 36.8%
// 0
// Submission: https://leetcode.com/submissions/detail/105460207/
// Runtime: 675 ms
// Your runtime beats 33.33 % of csharp submissions.

public class Solution {
    public IList<string> WordsAbbreviation(IList<string> dict) {
        var d = new Dictionary<int, SimpleTrie>();
        foreach(var s in dict)
        {
            var c= Code(s);
            if (!d.ContainsKey(c)) d[c] = new SimpleTrie();
            d[c].Insert(s);
        }
        return dict.Select(x=>Abbr(d[Code(x)], x)).ToArray();
    }
        public static int Code(string s)
    {
        return s[s.Length-1] * 1000 + s.Length;
    }
        public static string Reverse(string s)
    {
        var sb = new StringBuilder(s);
        int left = 0;
        int right = s.Length-1;
        while (left < right)
        {
            char tmp = sb[left];
            sb[left++] = sb[right];
            sb[right--] = tmp;
        }
        return sb.ToString();
    }
        public static string Abbr(SimpleTrie trie, string w)
    {
        var r = Reverse(w);
        var sb = new StringBuilder();
        int i=0;
        for (i=0; i<w.Length-1; i++)
        {
            sb.Append(w[i]);
            trie = trie.MoveNext(w[i]);
            if (trie.Size==1 /*|| Count(trie, w.Length-i-1, w[w.Length-1])<=1*/)
                break;
        }
        sb.Append(w.Length-i-2);
        sb.Append(w[w.Length-1]);
        var abbr = sb.ToString();
                if (abbr.Length >= w.Length) return w;
        return abbr;
    }
        public static int Count(SimpleTrie trie, int length, char end)
    {
        if (length==1)
        {
            var c = trie.MoveNext(end);
            return c != null && c.word != null ? 1 : 0;
        }
        int count=0;
        for (var cur=trie.FirstChild; cur != null; cur=cur.NextSibling)
            count+= Count(cur, length-1, end);
        return count;
    }
    }
public class SimpleTrie
{
    const char FirstChar = 'a';
    const int CharRange = 26;
        // alternative, I could use SimpleTrie nextSibling and SimpleTrie firstChild to save memory
    // normally, I would use bool isWord
    public char Ch;
    public bool EndOfWord;
    public int Size;
    public int WordCount;
    public SimpleTrie NextSibling;
    public SimpleTrie FirstChild;
    #region Aho Corasic
    public int Depth;
    public int counts;
    public string word;
    public List<string> matches = new List<string>();
    public SimpleTrie fail;
    public SimpleTrie Parent;
    #endregion
    public SimpleTrie Insert(string word)
    {
        var p = Find(word, true);
        p.word = word;
        var trie = this;
        foreach (var ch in word)
        {
            trie.Size++;
            trie = trie.MoveNext(ch, true);
        }
        trie.word = word;
        trie.WordCount++;
        trie.Size++;
        return trie;
    }
    public void Insert(IEnumerable<string> words)
    {
        foreach (var w in words)
            Insert(w);
    }
    public void Delete(string word)
    {
        if (!Contains(word))
            return;
        var trie = this;
        foreach (var ch in word)
        {
            trie.Size--;
            var child = trie.MoveNext(ch, false);
            if (child.Size == 1)
            {
                DeleteNext(ch);
                return;
            }
            trie = child;
        }
        if (--trie.WordCount == 0)
            trie.word = null;
        trie.Size--;
    }
    public bool StartsWith(string word)
    {
        return Find(word) != null;
    }
    public bool Contains(string word)
    {
        var trie = Find(word);
        return trie?.word != null;
    }
    public SimpleTrie Find(string word, bool create = false)
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
    public SimpleTrie MoveNext(char ch, bool create = false)
    {
        SimpleTrie prev = null;
        SimpleTrie newChild = null;
        SimpleTrie child = FirstChild;
        for (; child != null; prev = child, child = child.NextSibling)
        {
            if (child.Ch > ch) break;
            if (child.Ch == ch) return child;
        }
        if (create)
        {
            newChild = new SimpleTrie
            {
                Ch = ch,
                NextSibling = child
            };
            if (prev == null)
                FirstChild = newChild;
            else
                prev.NextSibling = newChild;
        }
        return newChild;
    }
    SimpleTrie DeleteNext(char ch)
    {
        SimpleTrie prev = null;
        for (SimpleTrie child = FirstChild; child != null; prev=child, child=child.NextSibling)
        {
            if (child.Ch < ch) continue;
            if (child.Ch > ch) break;
            if (prev == null)
                FirstChild = child.NextSibling;
            else
                prev.NextSibling = child.NextSibling;
            child.NextSibling = null;
            return child;
        }
        return null;
    }
    public override string ToString()
    {
        var kids = new StringBuilder();
        kids.Append('[');
        foreach (var child in GetChildren())
        {
            var ch = child.Ch;
            int len = kids.Length;
            if (len>=2 && kids[len-1] + 1 == ch)
            {
                if (kids[len - 2] + 1 == kids[len - 1])
                    // Case 1: abcd
                    kids[len - 1] = '-';
                else if (kids[len-2] == '-')
                    // Case 2: a-cd
                    kids.Length--; 
            }
            kids.Append(ch);
        }
        kids.Append(']');
        return PlainString() + kids;
    }
    public string PlainString()
    {
        var ps = Parent==null ? "^" : Parent.PlainString();
        return ps + Ch;
    }
    public IEnumerable<SimpleTrie> GetChildren()
    {
        for (var child = FirstChild; child != null; child = child.NextSibling)
            yield return child;
    }
    public IEnumerable<SimpleTrie> GetChildrenWords()
    {
        for (var child = FirstChild; child != null; child = child.NextSibling)
            yield return child;
    }
}
