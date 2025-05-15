// 621. Task Scheduler   
// https://leetcode.com/problems/task-scheduler
// Medium 41.5%
// 583.6794662788693
// Submission: https://leetcode.com/submissions/detail/108663523/
// Runtime: 795 ms
// Your runtime beats 3.22 % of csharp submissions.

using System.Collections.Generic;
public class Solution {
    public int LeastInterval(char[] tasks, int n) {
             var counts = new int[26];
        foreach(var ch in tasks)
            counts[ch-'A']++;
        var set = new SortedSet<Tuple<int,char>>();
                for (int i=0; i<26; i++)
            if (counts[i] > 0)
                set.Add(new Tuple<int,char>(-counts[i],(char)('A'+i)));
                int time = 0;
        var wait = new List<Tuple<int, char>>();
        while (set.Count > 0)
        {
            int c = n+1;
            foreach(var v in set)
            {
                wait.Add(v);
                if (--c<=0) break;
            }
            foreach(var v in wait)
            {
                set.Remove(v);
                if (v.Item1 + 1 < 0)
                    set.Add(new Tuple<int, char>(v.Item1+1, v.Item2));
            }
            if (set.Count > 0) time += n+1;
            else time += wait.Count;
            wait.Clear();
        }
                return time;
    }
                }
