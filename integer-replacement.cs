// 397. Integer Replacement   
// https://leetcode.com/problems/integer-replacement
// Medium 29.7%
// 332.12429530481853
// Submission: https://leetcode.com/submissions/detail/74815905/
// Runtime: 22 ms
// Your runtime beats 100.00 % of csharp submissions.

public class Solution {
    public int IntegerReplacement(int n) {
        if (n==1) 
            return 0;
                var seen = new HashSet<long>();
        var queue = new Queue<long>();
        var list = new List<long>();
        queue.Enqueue(n);
        seen.Add(n);
                int swaps = 0;
        while (queue.Count>0)
        {
            swaps++;
            for (int i=queue.Count; i>0; i--)
            {
                var pop = queue.Dequeue();
                                list.Clear();
                if (pop % 2 == 0)
                    list.Add(pop/2);
                else
                {
                    list.Add(pop+1);
                    list.Add(pop-1);
                }
                                foreach(var e in list)
                {
                    if (e==1) return swaps;
                    if (seen.Contains(e)) continue;
                    queue.Enqueue(e);
                    seen.Add(e);
                }
            }
        }
                return -1;
    }
    }
