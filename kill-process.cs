// 582. Kill Process   
// https://leetcode.com/problems/kill-process
// Medium 46.7%
// 285.7472029472634
// Submission: https://leetcode.com/submissions/detail/105458683/
// Runtime: 639 ms
// Your runtime beats 77.12 % of csharp submissions.

using System.Linq;
using System.Collections.Generic;
public class Solution {
    public IList<int> KillProcess(IList<int> pid, IList<int> ppid, int kill) {
        var dict = new Dictionary<int, HashSet<int>>();
                for(int i=0; i<pid.Count; i++)
        {
            if (!dict.ContainsKey(ppid[i])) dict[ppid[i]] = new HashSet<int>();
            dict[ppid[i]].Add(pid[i]);
        }
                var queue = new Queue<int>();
        queue.Enqueue(kill);
        var set = new HashSet<int>();
                while (queue.Count>0)
        {
            var pop = queue.Dequeue();
            if (set.Contains(pop)) continue;
            set.Add(pop);
                        if (dict.ContainsKey(pop))
            {
                foreach(var child in dict[pop])
                    queue.Enqueue(child);
            }
        }
                return set.ToList();
    }
}
