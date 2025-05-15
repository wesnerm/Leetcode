// 251. Flatten 2D Vector   
// https://leetcode.com/problems/flatten-2d-vector
// Medium 40.0%
// 586.222000464575
// Submission: https://leetcode.com/submissions/detail/68029072/
// Runtime: 548 ms
// 

public class Vector2D {
    int index;
    IList<IList<int>> queue;
    IList<int> list;
    int elemIndex;
    public Vector2D(IList<IList<int>> vec2d) {
        queue = vec2d;
        index=-1;
        Advance();
    }
    public bool HasNext() {
        return index<queue.Count;
    }
    public int Next() {
        int result = list[elemIndex++];
        Advance();
        return result;
    }
        private void Advance()
    {
        while (list == null || elemIndex >= list.Count)
        {
            ++index;
            if (index>=queue.Count)
            {
                list = null;
                return;
            }
            list = queue[index];
            elemIndex = 0;
        }
    }
}
/**
 * Your Vector2D will be called like this:
 * Vector2D i = new Vector2D(vec2d);
 * while (i.HasNext()) v[f()] = i.Next();
 */
