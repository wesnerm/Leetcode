// 406. Queue Reconstruction by Height   
// https://leetcode.com/problems/queue-reconstruction-by-height
// Medium 55.0%
// 689.6821286007887
// Submission: https://leetcode.com/submissions/detail/76292635/
// Runtime: 179 ms
// Your runtime beats 74.51 % of csharp submissions.

public class Solution {
    public int[,] ReconstructQueue2(int[,] people) {
         int m = people.GetLength(0);
                  var list = new List<People>(m);
         for (int i=0; i<m; i++)
            list.Add(new People { h=people[i,0], k=people[i,1] });
                  list.Sort((a,b)=>
         {
            int cmp = b.h - a.h;
            if (cmp == 0) return a.k - b.k;
            return cmp;
         } );
                 var newList = new List<People>(m);
        foreach(var p in list)
            newList.Insert(p.k, p);
        int[,] result = new int[m, 2];
        for(int i=0; i<m; i++)
        {
            result[i,0] = newList[i].h;
            result[i,1] = newList[i].k;
        }
        return result;
    }
        public int[,] ReconstructQueue(int[,] people)
    {
         int m = people.GetLength(0);
         var list = new List<People>(m);
         for (int i=0; i<m; i++)
            list.Add(new People { h=people[i,0], k=people[i,1] });
                  list.Sort((a,b)=>
         {
            int cmp = a.h - b.h;
            if (cmp == 0) return b.k - a.k;
            return cmp;
         } );
                 var bit = new Bit(m);
        for (int i=m-1; i>=0; i--)
            bit.Update(i+1, 1);
        int[,] result = new int[m, 2];
        foreach( var p in list)
        {
            // Both work! Why?
            var j = bit.GetIndex(p.k);
            result[j,0] = p.h;
            result[j,1] = p.k;
            //var j = bit.GetIndex(p.k+1);
            //result[j-1,0] = p.h;
            //result[j-1,1] = p.k;
            bit.Update(j+1, -1);
        }
        return result;
    }
        public class People
    {
        public int h;
        public int k;
    }
        public class Bit
    {
        int [] array;  
                public Bit(int n)
        {
            array= new int[n+1];
        }
                public void Update(int x, int v)
        {
            for (; x<array.Length; x += x&-x)
                array[x] += v;
        }
         public int Query(int x)
        {
            int sum = 0;
            for (; x>0; x -= x&-x)
                sum += array[x];
            return sum;
        }
                public int GetIndex(int x)
        {
            int idx = 0;
            int n = array.Length-1;
            int mask = n;
            while ((mask&mask-1) != 0)
                mask &= mask-1;
                        while (mask != 0)
            {
                int t = idx + mask;
                if (t<=n && x >= array[t])
                {
                    idx = t;
                    x -= array[t];
                }
                mask >>= 1;
            }
            return idx;
        }
    }
}
