// 282. Expression Add Operators   
// https://leetcode.com/problems/expression-add-operators
// Hard 29.4%
// 758.8761828289668
// Submission: https://leetcode.com/submissions/detail/69789651/
// Runtime: 1316 ms
// Your runtime beats 16.00 % of csharp submissions.

public class Solution {
    public IList<string> AddOperators(string num, int target) {
        var list = new List<string>();
        Dfs(list, num, 1, target);
        return list;
    }
        public void Dfs(List<string> results, string num, int index, int target)
    {
        if (index>=num.Length)
        {
            if (Evaluate(num) == target)
                results.Add(num);
            return;
        }
                Dfs(results, num, index+1, target);
        Dfs(results, num.Insert(index,"+"), index+2, target);
        Dfs(results, num.Insert(index,"-"), index+2, target);
        Dfs(results, num.Insert(index,"*"), index+2, target);
    }
        public int? Evaluate(string s)
    {
        var numStack = new Stack<int>();
        var opStack = new Stack<char>();
        char prevCh = '\0';
        for (int i=0; i<s.Length; i++)
        {
            var ch = s[i];
            switch(ch)
            {
                case '*':
                case '+':
                case '-':
                    if (ProcessStack(numStack, opStack, ch) == null)
                        return null;
                    opStack.Push(ch);
                    break;
                default:
                    if (ch>'9' || ch <'0')
                        return null;
                                            long num = ch-'0';
                    while (i+1 < s.Length && (ch=s[i+1]) >='0' && ch <='9')
                    {
                        if (num == 0) return null;
                        num = num * 10 + ch - '0';
                        if (num > int.MaxValue) return null;
                        i++;
                    }
                                        numStack.Push((int)num);
                    break;
            }
        }
                return ProcessStack(numStack, opStack);
    }
        public int? ProcessStack(Stack<int> numStack, Stack<char> opStack, char chPrec = '\0')
    {
        int num1, num2;
        int prec = Prec(chPrec);
        if (numStack.Count <= opStack.Count)
            return null;
                while (opStack.Count > 0 && Prec(opStack.Peek()) >= prec)
        {
            num2 = numStack.Pop();
            num1 = numStack.Pop();
            var pop = opStack.Pop();
            switch(pop)
            {
                case '*':
                    numStack.Push(num1 * num2);
                    break;
                case '-':
                    numStack.Push(num1 - num2);
                    break;
                case '+':
                    numStack.Push(num1 + num2);
                    break;
            }
        }
                return numStack.Peek();
    }
        public int Prec(char ch)
    {
        switch(ch)
        {
            case '+':
            case '-':
                return 1;
            case '*':
                return 2;
        }
                return 0;
    }
            }
