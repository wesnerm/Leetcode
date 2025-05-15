// 302. Smallest Rectangle Enclosing Black Pixels   
// https://leetcode.com/problems/smallest-rectangle-enclosing-black-pixels
// Hard 45.0%
// 282.82806246778364
// Submission: https://leetcode.com/submissions/detail/69658217/
// Runtime: 176 ms
// Your runtime beats 50.00 % of csharp submissions.

public class Solution {
        char[,] image;
    int xlen;
    int ylen;
    int xmax = 0;
    int ymax = 0;
    int xmin = int.MaxValue;
    int ymin = int.MaxValue;
        public int MinArea2(char[,] image, int x, int y) {
        if (image==null || image.Length==0) return 0;
        Dfs(image, x, y);
        return (xmax-xmin+1)*(ymax-ymin+1);
    }
        public void Dfs(char[,] image, int x, int y)
    {
        int xlen = image.GetLength(0);
        int ylen = image.GetLength(1);
        if (x<0||y<0||x>=xlen||y>=ylen||image[x,y]=='0') return;
        image[x,y]='0';
        xmax = Math.Max(xmax, x);
        xmin = Math.Min(xmin, x);
        ymax = Math.Max(ymax, y);
        ymin = Math.Min(ymin, y);
        Dfs(image, x+1, y+0);
        Dfs(image, x-1, y+0);
        Dfs(image, x+0, y+1);
        Dfs(image, x+0, y-1);
    }
        public int MinArea(char[,] image, int x, int y)
    {
        this.image = image;
        xlen = image.GetLength(0);
        ylen = image.GetLength(1);
        int left = SearchColumns(0, x, true);
        int right = SearchColumns(x, xlen-1, false);
        int top = SearchRows(0,y, true);
        int bottom = SearchRows(y,ylen-1, false);
        return (right-left+1) * (bottom-top+1);
    }
        int SearchColumns(int start, int end, bool before)
    {
        while (start<=end)
        {
            int mid = (start+end)/2;
            int i=0;
            while (i<ylen && image[mid,i]=='0') i++;
            if ((i == ylen) == before)
                start = mid+1;
            else
                end = mid-1;
        }
        return before ? start : end;
    }
    int SearchRows(int start, int end, bool before)
    {
        while (start<=end)
        {
            int mid = (start+end)/2;
            int i=0;
            while (i<xlen && image[i,mid]=='0') i++;
            if ((i == xlen) == before)
                start = mid+1;
            else
                end = mid-1;
        }
        return before ? start : end;
    }
}
