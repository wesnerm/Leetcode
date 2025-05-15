// 616. Add Bold Tag in String   
// https://leetcode.com/problems/add-bold-tag-in-string
// Medium 37.3%
// 199.33664825552864
// Submission: https://leetcode.com/submissions/detail/111574519/
// Runtime: 212 ms
// Your runtime beats 84.62 % of csharp submissions.

public class Solution {
    public string AddBoldTag(string s, string[] dict) {
                var list = new List<int[]>();
                foreach(var w in dict)
        {
            int start = 0;
            while (true)
            {
                int index = s.IndexOf(w, start);
                if (index < 0) break;
                //Console.WriteLine($"Added {index}-{index+w.Length}");
                list.Add(new int[] {index, index+w.Length});
                start = index+1;
            }
        }
        if (list.Count==0)
            return s;
                list.Sort((a,b) => {
            int cmp = a[0].CompareTo(b[0]);
            if (cmp != 0) return cmp;
            return a[1].CompareTo(b[1]);
        });        
                    int write = 1;
        for (int read = 1; read<list.Count; read++)
        {
            var prev = list[write-1];
            var curr = list[read];
            if (curr[0] > prev[1])
                list[write++] = curr;
            else
                prev[1] = Math.Max(prev[1], curr[1]);
        }
        Console.WriteLine($"write = {write}");
        list.RemoveRange(write, list.Count-write);
                        var sb = new StringBuilder(s);
        for (int i=list.Count-1; i>=0; i--)
        {
            sb.Insert(list[i][1], "</b>");
            sb.Insert(list[i][0], "<b>");
        }
                return sb.ToString();
    }
                }
