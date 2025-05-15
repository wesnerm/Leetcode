// 150. Evaluate Reverse Polish Notation   
// https://leetcode.com/problems/evaluate-reverse-polish-notation
// Medium 26.8%
// 1087.3167390816795
// Submission: https://leetcode.com/submissions/detail/70559255/
// Runtime: 176 ms
// Your runtime beats 8.82 % of csharp submissions.

public class Solution {
    public int EvalRPN(string[] tokens) {
        var stack = new Stack<int>();
                foreach(var s in tokens)
        {
            switch(s)
            {
                case "+":
                    stack.Push(stack.Pop() + stack.Pop());
                    break;
                case "*":
                    stack.Push(stack.Pop() * stack.Pop());
                    break;
                case "-":
                    int v2 = stack.Pop();
                    stack.Push(stack.Pop()-v2);
                    break;
                case "/":
                    v2 = stack.Pop();
                    stack.Push(stack.Pop()/v2);
                    break;
                default:
                    stack.Push(int.Parse(s));
                    break;
            }
        }
                return stack.Pop();
    }
}
