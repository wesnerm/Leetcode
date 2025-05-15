// 332. Reconstruct Itinerary    
// https://leetcode.com/problems/reconstruct-itinerary
// Medium 28.8%
// 580.8615546002579
// Submission: https://leetcode.com/submissions/detail/68510283/
// Runtime: 524 ms
// Your runtime beats 66.67 % of csharp submissions.

public class Solution {
    Dictionary<string, List<int>> dict = new Dictionary<string, List<int>>();
    HashSet<int> visited = new HashSet<int>();
    string[,] tickets;
    List<string> list = new List<string>();
            public IList<string> FindItinerary(string[,] tickets) {
        this.tickets = tickets;
        int length = tickets.GetLength(0);
        for (int i =0; i<length; i++)
        {
            var src = tickets[i,0];
            var dst = tickets[i,1];
            if (!dict.ContainsKey(src))
                dict[src] = new List<int>();
            dict[src].Add(i);
        }
                foreach(var v in dict.Values)
            v.Sort((a,b)=>tickets[a,1].CompareTo(tickets[b,1]));
                    DFS("JFK");
        list.Reverse();
        return list;
    }
        bool DFS(string name, int depth=0)
    {
        if (depth == tickets.GetLength(0))
        {
            list.Add(name);
            return true;
        }
        if (!dict.ContainsKey(name))
            return false;
                    foreach(var v in dict[name])
            if (!visited.Contains(v))
            {
                visited.Add(v);
                var dst = tickets[v,1];
                var result = DFS(dst, depth+1);
                visited.Remove(v);
                                if (result)
                {
                    list.Add(name);
                    return true;
                }
            }
                return false;
    }
        }
