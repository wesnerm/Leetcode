// 411. Minimum Unique Word Abbreviation   
// https://leetcode.com/problems/minimum-unique-word-abbreviation
// Hard 32.6%
// 289.70530532951517
// Submission: https://leetcode.com/submissions/detail/111774217/
// Runtime: 219 ms
// Your runtime beats 33.33 % of csharp submissions.

public class Solution {
        string min;
    public string MinAbbreviation(string target, string[] dictionary) {
                if (dictionary.Length==0)
            return target.Length.ToString();
                var trie = new SimpleTrie();
        foreach (var w in dictionary)
            if (w.Length == target.Length)
                trie.Insert(w);
                min = target;
                for (int i=0; i<(1<<target.Length); i++)
        {
            var countBits = CountBits(i, target.Length);                 
            //Console.WriteLine($"{i} -> {countBits} {compress} {search}");
            if (countBits >= min.Length) continue;
            var search = Search(trie, target, 0, i);
            if (search == null)
            {
                //Console.WriteLine($"min become {compress}");
                var compress = Compress(target, i);
                min = compress;
            }
        }
        return min;
    }
        int CountBits(int mask, int length)
    {
        int newLen = length;
        for (int i=length-2; i>=0; i--)
        {
            if (((mask>>i) & 3) == 0)
                newLen--;
        }
        return newLen;
    }
        string Compress(string target, int mask)
    {
        int count=0;
        var sb = new StringBuilder();
        for (int i=0; i<target.Length; i++)
        {
            if (mask<<~i >= 0)
            {
                count++;
                continue;
            }
            if (count > 0) sb.Append(count);
            count = 0;
            sb.Append(target[i]);
        }
                if (count > 0) sb.Append(count);
        return sb.ToString();
    }
        string Search(SimpleTrie trie, string target, int index, int mask)
    {
        if (trie == null) return null;
        if (index>=target.Length) return trie.word;
                if ( (mask & 1<<index) != 0 )
        {
            var next = trie.MoveNext(target[index]);
            return Search(next, target, index+1, mask);
        }
                for (var child = trie.FirstChild; child != null; child = child.NextSibling)
        {
            var next = Search(child, target, index+1, mask);
            if (next != null) return next;
        }
        return null;
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
