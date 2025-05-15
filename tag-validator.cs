// 591. Tag Validator   New
// https://leetcode.com/problems/tag-validator
// Hard 23.0%
// 98.99752414962376
// Submission: https://leetcode.com/submissions/detail/105458239/
// Runtime: 132 ms
// Your runtime beats 72.00 % of csharp submissions.

public class Solution {
        string code;
    public bool IsValid(string code) {
        this.code = code;
        int i=0;
        return ParseTag(ref i) && i==code.Length;
    }
        public bool ParseTag(ref int i)
    {
        Console.WriteLine($"ParseTag({i})");
        var ch = Parse(ref i);
        if (ch != "<") return false;
        string name = ParseName(ref i);
        if (name == null || Parse(ref i) != ">") return false;
        if (!ParseStream(ref i)) return false;
        return Parse(ref i) == "<" && Parse(ref i) =="/" && ParseName(ref i) == name && Parse(ref i)==">";
    }
        public bool ParseStream(ref int i)
    {
        Console.WriteLine($"ParseStream({i})");
        while (true)
        {
            var start = i;
            var ch = Parse(ref i);
                        if (ch == "") return false;
                    if (ch == "<")
            {
                if (Parse(ref i) == "/")
                {
                    i = start;
                    break;
                }
                i = start;
                if (!ParseTag(ref i))
                    return false;
                                continue;
            }
                        if (ch == cdata)
            {
                if (!ParseCData(ref i))
                    return false;
                continue;
                            }
        }
                return true;
    }
    const string cdata = "<![CDATA[";
    const string cdata2 = "]]>";
    public bool ParseCData(ref int i)
    {
        Console.WriteLine($"ParseCData({i})");
        int index = code.IndexOf(cdata2, i);
        if (index<0)
            return false;
        i = index+cdata2.Length;
        return true;
    }
    public string ParseName(ref int i)
    {
        Console.WriteLine($"ParseName({i})");
        int start = i;
        while (i<code.Length && char.IsUpper(code[i])) i++;
                int len = i-start;
                if (len<1 || len>9) return null;
        return code.Substring(start, len);
    }
            public string Parse(ref int i)
    {
        if (i==code.Length) return "";
                var ch = code[i++];
        switch(ch)
        {
            case '<': 
                if (i-1+cdata.Length<=code.Length && code[i]=='!' && code.Substring(i-1, cdata.Length)==cdata)
                {
                    i += cdata.Length-1;
                    return cdata;
                }
                return "<";
            case '>': return ">";
            default: return ch.ToString();
        }
    }
    }
