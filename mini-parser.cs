// 385. Mini Parser   
// https://leetcode.com/problems/mini-parser
// Medium 30.1%
// 432.1485361719749
// Submission: https://leetcode.com/submissions/detail/71165762/
// Runtime: 508 ms
// Your runtime beats 9.09 % of csharp submissions.

/**
 * // This is the interface that allows for creating nested lists.
 * // You should not implement it, or speculate about its implementation
 * interface NestedInteger {
 *
 *     // Constructor initializes an empty nested list.
 *     public NestedInteger();
 *
 *     // Constructor initializes a single integer.
 *     public NestedInteger(int value);
 *
 *     // @return true if this NestedInteger holds a single integer, rather than a nested list.
 *     bool IsInteger();
 *
 *     // @return the single integer that this NestedInteger holds, if it holds a single integer
 *     // Return null if this NestedInteger holds a nested list
 *     int GetInteger();
 *
 *     // Set this NestedInteger to hold a single integer.
 *     public void SetInteger(int value);
 *
 *     // Set this NestedInteger to hold a nested list and adds a nested integer to it.
 *     public void Add(NestedInteger ni);
 *
 *     // @return the nested list that this NestedInteger holds, if it holds a nested list
 *     // Return null if this NestedInteger holds a single integer
 *     IList<NestedInteger> GetList();
 * }
 */
public class Solution {
        public NestedInteger Deserialize(string s) {
        int pos = 0;        
        return Read(s, ref pos);
    }
        NestedInteger Read(string s, ref int pos)
    {
        var token = ReadToken(s, ref pos);
        if (token=="[")
        {
            var ni = new NestedInteger();
                int pos2 = pos;
            if (ReadToken(s, ref pos2) != "]")
            {
                while(true)
                {
                    var elem = Read(s, ref pos);
                    ni.Add(elem);
                                        var v = ReadToken(s, ref pos);
                    if (v == "]")
                        break;
                                    // Assume ','
                }
            }
            else
            {
                // Read bracket
                ReadToken(s, ref pos);
            }
                        return ni;
        }
        else
        {
            return new NestedInteger(int.Parse(token));
        }
    }
        public string ReadToken(string s, ref int pos)
    {
        int start = pos;
        while (pos<s.Length && s[pos]==' ')
            pos++;
                if (pos>=s.Length) return null;
                char ch = s[pos++];
        if (ch >='0' && ch <='9' || ch=='-' )
            while (pos<s.Length && s[pos]>='0' && s[pos]<='9')
                pos++;
        return s.Substring(start, pos-start);
    }
}
