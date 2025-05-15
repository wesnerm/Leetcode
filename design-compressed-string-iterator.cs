// 604. Design Compressed String Iterator   
// https://leetcode.com/problems/design-compressed-string-iterator
// Easy 30.6%
// 131.32936071105993
// Submission: https://leetcode.com/submissions/detail/111701821/
// Runtime: 205 ms
// Your runtime beats 25.00 % of csharp submissions.

public class StringIterator {
    string s;
    int rep;
    char ch;
    int i;
        public StringIterator(string compressedString) {
        s = compressedString;
    }
        public char Next() {
        if (rep != 0)
        {
            rep--;
            return ch;
        }
                if (i>=s.Length)
            return ' ';
                    while (true)
        {
            ch = s[i++];
            while (i<s.Length && s[i]>='0' && s[i]<='9')
            { rep = rep*10+ s[i++]-'0';  }
            if (rep > 0) rep--;
            return ch;
        }
            }
        public bool HasNext() {
        return rep>0 || i<s.Length;
    }
}
/**
 * Your StringIterator object will be instantiated and called as such:
 * StringIterator obj = new StringIterator(compressedString);
 * char param_1 = obj.Next();
 * bool param_2 = obj.HasNext();
 */
