// 218. The Skyline Problem   
// https://leetcode.com/problems/the-skyline-problem
// Hard 26.7%
// 928.4102159809646
// Submission: https://leetcode.com/submissions/detail/69474096/
// Runtime: 652 ms
// Your runtime beats 41.67 % of csharp submissions.

public class Solution {
    public IList<int[]> GetSkyline2(int[,] buildings) {
        int n = buildings.GetLength(0);
        var xset = new HashSet<int>();
        var blist = new Building[n];
                for (int i=0; i<n; i++)
        {
            var b = new Building {
                left = buildings[i,0],
                right = buildings[i,1],
                height = buildings[i,2],
            };
            xset.Add(b.left);
            xset.Add(b.right);
            blist[i] = b;
        }
        var xlist = xset.OrderBy(x=>x).ToList();
        var result = new List<int[]>();
        int height = 0;        
        foreach(var x in xlist)
        {
            int newHeight = 0;
            for (int i=0; i<n; i++)
            {
                if (x>=blist[i].left && x<blist[i].right)
                    newHeight = Math.Max(newHeight, blist[i].height);
            }
            if (newHeight == height)
                continue;
            height = newHeight;
            result.Add( new[] {x, newHeight });
        }
                return result;
    }
        public IList<int[]> GetSkyline(int[,] buildings) {
        int n = buildings.GetLength(0);
        var xset = new HashSet<int>();
        var blist = new Building[n];
        var rsorted = new int[n];
        var pq = new SortedSet<int>(new HeightComparer { blist = blist });
        for (int i=0; i<n; i++)
        {
            var b = new Building {
                left = buildings[i,0],
                right = buildings[i,1],
                height = buildings[i,2],
            };
            xset.Add(b.left);
            xset.Add(b.right);
            blist[i] = b;
            rsorted[i]=i;
        }
        Array.Sort(rsorted, (a,b)=>blist[a].right-blist[b].right);
        var result = new List<int[]>();
        int height = 0;        
        int li=0;
        int ri=0;
                foreach(var x in xset.OrderBy(x=>x))
        {
            // for (int i=0; i<n; i++)
            // {
            //    if (x>=blist[i].left && x<blist[i].right)
            //        newHeight = Math.Max(newHeight, blist[i].height);
            // }
                        // Add heights
            while (li<n && blist[li].left<=x)
                pq.Add(li++);
            // Remove heights
            while (ri<n && blist[rsorted[ri]].right<=x)
                pq.Remove(rsorted[ri++]);
            int newHeight = pq.Count>0 ? blist[pq.Max].height : 0;
            if (newHeight == height)
                continue;
            height = newHeight;
            result.Add( new[] {x, newHeight });
        }
        return result;
    }
        class Building
    {
        public int left;
        public int right;
        public int height;
    }
    class HeightComparer : IComparer<int>
    {
        public Building[] blist;
        public int Compare(int a, int b)
        {
            int cmp = blist[a].height - blist[b].height;
            if (cmp == 0)
                cmp = a-b;
            return cmp;
        }
    }
    }
