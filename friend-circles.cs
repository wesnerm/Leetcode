// 547. Friend Circles   
// https://leetcode.com/problems/friend-circles
// Medium 48.8%
// 316.3491063200042
// Submission: https://leetcode.com/submissions/detail/105459830/
// Runtime: 192 ms
// Your runtime beats 70.91 % of csharp submissions.

public class Solution {
    public int FindCircleNum(int[,] M) {
        var ds = new DisjointSet(M.GetLength(0));
        for (int i=0; i<M.GetLength(0); i++)
            for (int j=0; j<M.GetLength(1); j++)
                if (M[i,j]==1) ds.Union(i,j);
                        return ds.Count;
    }
}
public class DisjointSet
    {
        private readonly int[] _ds;
        private readonly int[] _counts;
        private int _components;
        private bool _oneBased;
        public int Count => _components; 
        public DisjointSet(int size, bool onesBased=false)
        {
            _ds = new int[size+1];
            _counts = new int[size+1];
            _components = size;
            _oneBased = onesBased;
            for (int i = 0; i <= size; i++)
            {
                _ds[i] = i;
                _counts[i] = 1;
            }
            if (onesBased)
                _ds[0] = size;
            else
                _ds[size] = 0;
        }
        public int[] Array => _ds;
        public bool Union(int x, int y)
        {
            var rx = Find(x);
            var ry = Find(y);
            if (rx == ry) return false;
            if (_counts[ry] > _counts[rx])
            {
                _ds[rx] = ry;
                _counts[ry] += _counts[rx];
            }
            else
            {
                _ds[ry] = rx;
                _counts[rx] += _counts[ry];
            }
            _components--;
            return true;
        }
        public int Find(int x)
        {
            var root = _ds[x];
            return root == x 
                ? x 
                : (_ds[x] = Find(root));
        }
        public int GetCount(int x)
        {
            var root = Find(x);
            return _counts[root];
        }
        public IEnumerable<int> Components()
        {
            for (int i = 0; i < _ds.Length; i++)
            {
                if (_ds[i] == i)
                    yield return i;
            }
        }
        public IEnumerable<List<int>> GetComponents()
        {
            var comp = new Dictionary<int, List<int>>();
            foreach (var c in Components())
                comp[c] = new List<int>(GetCount(c));
            int start = _oneBased ? 1 : 0;
            int limit = _oneBased ? _ds.Length : _ds.Length - 1;
            for (int i = start; i < limit; i++)
                comp[Find(i)].Add(i);
            return comp.Values;
        }
    }
