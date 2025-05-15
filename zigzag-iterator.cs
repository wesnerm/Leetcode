// 281. Zigzag Iterator   
// https://leetcode.com/problems/zigzag-iterator
// Medium 49.8%
// 604.1590654972971
// Submission: https://leetcode.com/submissions/detail/68025646/
// Runtime: 568 ms
// 

public class ZigzagIterator {
    int index = 0;
    IList<int>[] lists = new IList<int>[2];
    int listCount = 0;
    int offset = 0;
    public ZigzagIterator(IList<int> v1, IList<int> v2) 
    {
        lists[0] = v1;
        lists[1] = v2;
        listCount = 2;
        RemoveDead();
    }
    public bool HasNext() 
    {
        return listCount > 0;    
    }
    public int Next() {
        if (listCount == 0)
            throw new Exception();
        int next = lists[offset][index];
        offset++;
        if (offset >= listCount)
        {
            offset = 0;
            index++;
            RemoveDead();
        }
        return next;
    }
        void RemoveDead()
    {
        for (int read=0; read<listCount; read++)
            if (index>=lists[read].Count)
            {
                int write = read;
                for (; read<listCount; read++)
                {
                    if (index<lists[read].Count)
                        lists[write++] = lists[read];
                }
                // Memory Leak
                for (int j=write; j<listCount; j++)
                    lists[j] = null;
                                listCount = write;
                break;
            }
    }
    }
/**
 * Your ZigzagIterator will be called like this:
 * ZigzagIterator i = new ZigzagIterator(v1, v2);
 * while (i.HasNext()) v[f()] = i.Next();
 */
