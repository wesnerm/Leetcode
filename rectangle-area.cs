// 223. Rectangle Area   
// https://leetcode.com/problems/rectangle-area
// Medium 32.6%
// 1078.6186200676862
// Submission: https://leetcode.com/submissions/detail/70447920/
// Runtime: 96 ms
// Your runtime beats 4.55 % of csharp submissions.

public class Solution {
    public int ComputeArea(int A, int B, int C, int D, int E, int F, int G, int H) {
        int area1 = (C-A)*(D-B);
        int area2 = (G-E)*(H-F);
        int x1=Math.Max(A,E);
        int y1=Math.Max(B,F);
        int x2=Math.Min(C,G);
        int y2=Math.Min(D,H);
                int area3 = 0;
        if (x1<x2 && y1<y2)
            area3 = (x2-x1)*(y2-y1);
                    return area1 + area2 - area3;
    }
}
