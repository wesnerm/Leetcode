// 241. Different Ways to Add Parentheses   
// https://leetcode.com/problems/different-ways-to-add-parentheses
// Medium 43.1%
// 826.919261603318
// Submission: https://leetcode.com/submissions/detail/71349180/
// Runtime: 526 ms
// 

public class Solution {
    public IList<int> DiffWaysToCompute(string input) {
        var nums = new List<int>();
        var ops = new List<string>();
                int pos = 0;
        while(true)
        {
            var data = Read(input, ref pos);
            if (data == null) break;
            if (ops.Count < nums.Count) ops.Add(data);
            else nums.Add(int.Parse(data));
        }
                return Evaluate(nums, ops, 0, nums.Count-1).ToList();
    }
        IEnumerable<int> Evaluate(List<int> nums, List<string> ops, int start, int end)
    {
        if (start == end)
        {
            yield return nums[start];
            yield break;
        }
                for (int i=start; i<end; i++)
        {
            var op = ops[i];
            foreach(var x1 in Evaluate(nums, ops, start, i))
            foreach(var x2 in Evaluate(nums, ops, i+1,end))
            {
                if (op == "+") yield return x1 + x2;
                else if (op == "-") yield return x1 - x2;
                else yield return x1 * x2;
            }
        }
    }
        public string Read(string s, ref int pos)
    {
        int start = pos;
        if (pos == s.Length) return null;
        if (char.IsDigit(s[pos]))
        {
            pos++;
            while (pos<s.Length && char.IsDigit(s[pos]))
                pos++;
            return s.Substring(start, pos-start);
        }
                return s[pos++].ToString();
    }
}
