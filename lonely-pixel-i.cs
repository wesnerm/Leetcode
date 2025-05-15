// 531. Lonely Pixel I   
// https://leetcode.com/problems/lonely-pixel-i
// Medium 52.7%
// 113.80773691542524
// Submission: https://leetcode.com/submissions/detail/105460375/
// Runtime: 222 ms
// Your runtime beats 70.00 % of csharp submissions.

public class Solution {
    public int FindLonelyPixel(char[,] picture) {
        int n = picture.GetLength(0);
        int m = picture.GetLength(1);
        var rows = new int[n];
        var cols = new int[m];
        for (int i=0; i<n; i++)
        for (int j=0; j<m; j++)
        {
            if (picture[i,j]=='B')
            {
                rows[i]++;
                cols[j]++;
            }
        }
                int count = 0;
        for (int i=0; i<n; i++)
            if (rows[i]==1)
            for (int j=0; j<m; j++)
                if (picture[i,j]=='B' && cols[j] == 1)
                    count++;
        return count;
    }
}
