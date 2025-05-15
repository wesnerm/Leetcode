// 391. Perfect Rectangle   
// https://leetcode.com/problems/perfect-rectangle
// Hard 25.7%
// 586.3522634449689
// Submission: https://leetcode.com/submissions/detail/72106788/
// Runtime: 444 ms
// Your runtime beats 44.44 % of csharp submissions.

public class Solution {
    public bool IsRectangleCover(int[,] rectangles) {
            int m = rectangles.GetLength(0);
            var yset = new SortedSet<Box>(new Comparer<Box>((a, b) =>
            {
                if (a.y2 <= b.y) return -1;
                if (b.y2 <= a.y) return 1;
                return 0;
            }));
            var boxes = new Box[m];
            int xmin = int.MaxValue, ymin = int.MaxValue, xmax = int.MinValue, ymax = int.MinValue;
            for (int i = 0; i < m; i++)
            {
                boxes[i] = new Box { x = rectangles[i, 0], y = rectangles[i, 1], x2 = rectangles[i, 2], y2 = rectangles[i, 3] };
                xmin = Math.Min(xmin, boxes[i].x);
                ymin = Math.Min(ymin, boxes[i].y);
                xmax = Math.Max(xmax, boxes[i].x2);
                ymax = Math.Max(ymax, boxes[i].y2);
            }
            Array.Sort(boxes, (a, b) => a.x - b.x);
            var rboxes = boxes.OrderBy(b => b.x2).ToArray();
            int bx = 0;
            int rbx = 0;
            int area = 0;
            while (bx < boxes.Length || rbx < boxes.Length)
            {
                int next = rboxes[rbx].x2;
                if (bx < boxes.Length) next = Math.Min(next, boxes[bx].x);
                while (rbx < rboxes.Length && rboxes[rbx].x2 <= next)
                {
                    area -= rboxes[rbx].y2 - rboxes[rbx].y;
                    yset.Remove(rboxes[rbx++]);
                }
                while (bx < boxes.Length && boxes[bx].x <= next)
                {
                    area += boxes[bx].y2 - boxes[bx].y;
                    if (!yset.Add(boxes[bx++])) return false;
                }
                if (area != ymax - ymin && next != xmax)
                    return false;
            }
        return true;
    }
        public class Box
    {
        public int x,y,x2,y2;
    }
        public class Comparer<T> : IComparer<T>
    {
        Comparison<T> compare;
        public Comparer(Comparison<T> compare)
        {
            this.compare = compare;
        }
        public int Compare(T a, T b)
        {
            return compare(a,b);
        }
    }    
}
