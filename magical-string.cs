// 481. Magical String   
// https://leetcode.com/problems/magical-string
// Medium 45.2%
// 528.6252710968768
// Submission: https://leetcode.com/submissions/detail/101987700/
// Runtime: 72 ms
// Your runtime beats 4.17 % of csharp submissions.

using System.Linq;
public class Solution {
    public int MagicalString(int n)
    {
        var queue = new Queue<int>();
        queue.Enqueue(1);
        queue.Enqueue(2);
        queue.Enqueue(2);
                int count = 0;
        int d = 1;
        int j = 1;
        while (true)
        {
            int c = queue.Dequeue();
            for (int i=0; i<c; i++)
            {
                if (j++ > n) return count;
                if (d==1) count++;
                if (j>4) queue.Enqueue(d);                                    
            }
            d=3-d;
        }
    }
/*
    public int MagicalString(int n) {
        return Magic().Take(n).Count(x=>x==1);
    }
        public IEnumerable<int> Magic()
    {
        yield return 1;
        yield return 2;
        yield return 2;
                int i=0;
        foreach(var x in Magic())
        {
            if (i>1)
            {
                for (int y=0; y<x; y++)
                    yield return i%2 + 1;
            }
            i++;
        }
    }
*/
}
