// 210. Course Schedule II   
// https://leetcode.com/problems/course-schedule-ii
// Medium 27.1%
// 434.12915471009654
// Submission: https://leetcode.com/submissions/detail/70897134/
// Runtime: 533 ms
// Your runtime beats 29.49 % of csharp submissions.

public class Solution {
        Dictionary<int,HashSet<int>> graph = new Dictionary<int, HashSet<int>>();
    List<int> results = new List<int>();
    bool[] visited;
    bool[] inuse;
    bool cycle;
        public int[] FindOrder(int numCourses, int[,] prerequisites)
    {
        for (int i=0; i<numCourses; i++)
            graph[i] = new HashSet<int>();
                    int plen = prerequisites.GetLength(0);
        for (int i=0; i<plen; i++)
            graph[prerequisites[i,0]].Add(prerequisites[i,1]);
        visited = new bool[numCourses];
        inuse = new bool[numCourses];
                for (int i=0; i<numCourses; i++)
            if (!visited[i])
                Visit(i);
                //results.Reverse();
        if (cycle)
            results.Clear();
                return results.ToArray();
    }
        void Visit(int v)
    {
        if (inuse[v])
            cycle = true;
                if (visited[v]) return;
                visited[v] = true;
        inuse[v] = true;
                foreach(var v2 in graph[v])
            Visit(v2);           
                    inuse[v] = false;
        results.Add(v);
    }
    }
