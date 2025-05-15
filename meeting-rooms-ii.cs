// 253. Meeting Rooms II   
// https://leetcode.com/problems/meeting-rooms-ii
// Medium 38.7%
// 653.1542091002256
// Submission: https://leetcode.com/submissions/detail/73264930/
// Runtime: 196 ms
// Your runtime beats 67.50 % of csharp submissions.

/**
 * Definition for an interval.
 * public class Interval {
 *     public int start;
 *     public int end;
 *     public Interval() { start = 0; end = 0; }
 *     public Interval(int s, int e) { start = s; end = e; }
 * }
 */
public class Solution {
    public int MinMeetingRooms1(Interval[] intervals) 
    {
        int[] starts = new int[intervals.Length];
        int[] ends = new int[intervals.Length];
                for (int i=0; i<intervals.Length; i++)
        {
            starts[i] = intervals[i].start;
            ends[i] = intervals[i].end;
        }
                Array.Sort(starts);
        Array.Sort(ends);
                int rooms = 0;
        int endsItr = 0;
                for (int i=0; i<starts.Length; i++)
        {
//            if (starts[i]<ends[endsItr])
//                rooms++;
//            else
//                endsItr++;
            if (starts[i]>=ends[endsItr])
                endsItr++;
        }
                // return rooms;
        return starts.Length - endsItr;
    }
    public int MinMeetingRooms2(Interval[] intervals)
    {
        if (intervals == null || intervals.Length == 0)
            return 0;
        Array.Sort(intervals, (a, b) => a.start - b.start);
        var heap = new Heap<Interval>((a, b) => a.end - b.end);
        heap.Enqueue(intervals[0]);
        for (int i = 1; i < intervals.Length; i++)
        {
            if (intervals[i].start >= heap.FindMin().end)
                heap.Dequeue();
            heap.Enqueue(intervals[i]);
        }
        return heap.Count;
    }
        public int MinMeetingRooms3(Interval[] intervals)
    {
        if (intervals == null || intervals.Length == 0)
            return 0;
        Array.Sort(intervals, (a, b) => a.start - b.start);
        var heap = new Heap<Interval>((a, b) => a.end - b.end);
        int minRooms = 0;
        for (int i = 0; i < intervals.Length; i++)
        {
            while(heap.Count>0 && intervals[i].start >= heap.FindMin().end)
                heap.Dequeue();
            heap.Enqueue(intervals[i]);                
            minRooms= Math.Max(heap.Count, minRooms);
        }
        return minRooms;
    }
        public int MinMeetingRooms(Interval[] intervals)
    {
        if (intervals == null || intervals.Length == 0)
            return 0;
        var list = new List<int>();
        foreach(var ival in intervals)
        {
            list.Add(ival.start << 1 | 1);
            list.Add(ival.end << 1);
        }
        list.Sort();
        int minRooms = 0;
        int count = 0;
        foreach(var m in list)
        {
            count += ((m & 1) == 1) ? 1 : -1;
            if (minRooms < count) minRooms = count;
        }
        return minRooms;
    }
    public class Heap<T>
    {
        Comparison<T> comparison;
        List<T> list = new List<T>();
                public Heap(Comparison<T> comparison=null)
        {
            this.comparison = comparison ?? Comparer<T>.Default.Compare;
        }
            public int Count { get { return list.Count; } }
                public T FindMin() { return list[0]; }
            public T Dequeue()
        {
            var pop = list[0];
            list[0] = list[list.Count-1];
            list.RemoveAt(list.Count-1);
                        if (list.Count>0)
            {
                int i=0;
                while (true)
                {
                    int child = 2*i+1;
                    if (child >=list.Count)
                        break;
                            if (child+1 < list.Count && comparison(list[child], list[child+1]) > 0)
                        child++;
                                        if (comparison(list[child], list[i]) >= 0)
                        break;
                                        Swap(i, child);
                    i = child;
                }
            }
                        return pop;
        }
                public void Enqueue(T push)
        {
            list.Add(push);
            int i = list.Count - 1;
            while (i>0)
            {
                int parent = (i-1)/2;
                if (comparison(list[parent], push) <= 0)
                    break;
                Swap(i, parent);
                i = parent;
            }
        }
                void Swap(int t1, int t2)
        {
            T tmp = list[t1];
            list[t1] = list[t2];
            list[t2] = tmp;
        }
    }
}
