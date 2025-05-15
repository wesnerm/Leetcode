// 347. Top K Frequent Elements    
// https://leetcode.com/problems/top-k-frequent-elements
// Medium 47.5%
// 886.5273890656922
// Submission: https://leetcode.com/submissions/detail/70938690/
// Runtime: 556 ms
// Your runtime beats 14.64 % of csharp submissions.

public class Solution {
    public IList<int> TopKFrequent2(int[] nums, int k) {
        // bucket sort
        int maxFreq;
        var dict = BuildTable(nums, out maxFreq);
                var buckets = new List<int>[maxFreq+1];
        foreach (var pair in dict)
        {
            int num = pair.Key;
            int freq = pair.Value;
            var bucket = buckets[freq] ?? (buckets[freq] = new List<int>());
            bucket.Add(num);
        }
        var results = new List<int>();
        for (int i=buckets.Length-1; i>0 && results.Count<k; i--)
        {
            if (buckets[i] != null)
                results.AddRange(buckets[i]);
        } 
        return results;
        // selection
        // heap
    }
        public IList<int> TopKFrequent3(int[] nums, int k) {
        // heap
        int maxFreq;
        var dict = BuildTable(nums, out maxFreq);
        var set = new SortedSet<KeyValuePair<int,int>>(new BucketComparer());
                var buckets = new List<int>[maxFreq+1];
        foreach (var pair in dict)
        {
            set.Add(pair);
            if (set.Count > k)
                set.Remove(set.Min);
        }
        return set.Select(x=>x.Key).ToList();
        // heap
    }
        public class BucketComparer : IComparer<KeyValuePair<int,int>>
    {
        public int Compare(KeyValuePair<int,int> a, KeyValuePair<int,int> b)
        {
            int cmp = a.Value.CompareTo(b.Value);
            if (cmp != 0)
                return cmp;
            return a.Key.CompareTo(b.Key);
        }
    }
    public IList<int> TopKFrequent(int[] nums, int k) {
        // heap
        int maxFreq;
        var dict = BuildTable(nums, out maxFreq);
        var buckets = dict.ToList();
        Select(buckets, k, 0, buckets.Count-1);
        return buckets.Take(Math.Min(k,buckets.Count)).Select(x=>x.Key).ToList();
        // heap
    }
    void Select(List<KeyValuePair<int, int>> buckets, int k, int start, int end)
    {
        if (start>=end) return;
        int pv = start + (end-start)/2;
        int pvalue = buckets[pv].Value;
        Swap(buckets, pv, end);
                int i = start;
        int j = start;
        while (i<end)
        {
            if (buckets[i].Value > pvalue)
                Swap(buckets, i, j++);
            i++;
        }
                Swap(buckets, j, end);
                if (j==k)
            return;
                    if (j<k)
            Select(buckets, k, j+1, end);            
        else
            Select(buckets, k, start, j-1);
    }
    void Swap<T>(List<T> list, int a, int b)
    {
        var tmp = list[a];
        list[a] = list[b];
        list[b] = tmp;
    }
            public Dictionary<int, int> BuildTable(int[] nums, out int maxFreq)
    {
        var dict = new Dictionary<int, int>();
        maxFreq = 0;
        foreach(var n in nums)
        {
            int freq = dict.ContainsKey(n) ? dict[n]+1 : 1;
            dict[n] = freq;
            maxFreq = Math.Max(maxFreq, freq);
        }
        return dict;        
    }
}
