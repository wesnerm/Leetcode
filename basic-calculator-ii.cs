// 227. Basic Calculator II   
// https://leetcode.com/problems/basic-calculator-ii
// Medium 28.9%
// 672.0199979862872
// Submission: https://leetcode.com/submissions/detail/70747665/
// Runtime: 224 ms
// Your runtime beats 9.61 % of csharp submissions.

public class Solution {
    public int Calculate(string s) 
    {
        var parser= new Parser();
        return parser.Parse(s);
    }
    public class Parser
    {
        string s;
        int index;
                public int Parse(string s)
        {
            this.s = s;
            this.index = 0;
            return ParseExpression();
        }
                   public int ParseExpression()
        {
            var term1 = ParseFactor();
                while (true)
            {
                var oldIndex = index;
                var token = Peek();
                                if (token != "+" && token!="-")
                    break;
                                var op = ReadToken();
                var term2 = ParseFactor();
                                term1 = op=="+" ? term1 + term2 : term1 - term2;
                            }
                        return term1;
        }
                public int ParseFactor()
        {
            var term1 = ParseTerm();
                while (true)
            {
                var oldIndex = index;
                var token = Peek();
                                if (token != "*" && token!="/")
                    break;
                                var op = ReadToken();
                var term2 = ParseTerm();
                                term1 = op=="*" ? term1 * term2 : term1 / term2;
                            }
                        return term1;
        }
                public int ParseTerm()
        {
            var token = ReadToken();
            int result;
            switch(token)
            {
                case "(":
                    result = ParseExpression();
                    Require(")");
                    break;
                default:
                    result = int.Parse(token);
                    break;
            }
            return result;
        }
            public void Require(string token)
        {
            var t = ReadToken();
            if (t != token)
                throw new Exception();
        }
            public string Peek()
        {
            var oldindex = index;
            var result = ReadToken();
            index = oldindex;
            return result;
        }
        public string ReadToken()
        {
            while (index<s.Length && char.IsWhiteSpace(s[index]))
                index++;
                            if (index>=s.Length)
                return "";
                        int start = index;
            var ch = s[index++];
            if (ch>='0' && ch<='9')
            {
                while (index<s.Length)
                {
                    ch = s[index];
                    if (ch<'0' || ch>'9') break;
                    index++;
                }
                return s.Substring(start, index-start);
            }
                return ch.ToString();
        }   
    }
}
