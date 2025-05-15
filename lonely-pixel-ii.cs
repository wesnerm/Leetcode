// 533. Lonely Pixel II   
// https://leetcode.com/problems/lonely-pixel-ii
// Medium 42.3%
// 156.56918671393248
// Submission: https://leetcode.com/submissions/detail/111763892/
// Runtime: 249 ms
// Your runtime beats 33.33 % of csharp submissions.

public class Solution {
    public int FindBlackPixel(char[,] picture, int N) {
        int n = picture.GetLength(0);
        int m = picture.GetLength(1);
        var rows = new int[n];
        var rowText = new string[n];
        var cols = new int[m];
        var col2row = new int[m];
                for (int i=0; i<n; i++)
        for (int j=0; j<m; j++)
        {
            if (picture[i,j]=='B')
            {
                rows[i]++;
                cols[j]++;
                col2row[j] = col2row[j] == 0 ? i+1 : col2row[j];
                if (picture[col2row[j]-1,j] != 'B')
                    cols[j] = int.MinValue;
            }
        }
                var dict = new Dictionary<string, int>();
        var sb = new StringBuilder();
        for (int i=0; i<n; i++)
        {
            sb.Clear();
            for (int j=0; j<m; j++)
                sb.Append(picture[i,j]);
            var row = sb.ToString();
            if (dict.ContainsKey(row)==false) dict[row] = 0;
            dict[row]++;
            rowText[i] = row;
        }
                int count = 0;
        for (int i=0; i<n; i++)
            for (int j=0; j<m; j++)
            {
                var ch = picture[i,j];
                //Console.WriteLine($"[{i},{j}] '{ch}'-> rows={rows[i]} cols={cols[j]}");
                if (picture[i,j]=='B' && rows[i] == N && cols[j] == N && dict[rowText[i]]==N)
                    count++;
            }
                //for (int i=0; i<n; i++) Console.WriteLine(rows[i]);
        //for (int i=0; i<m; i++) Console.WriteLine(cols[i]);
                        return count;
            }
}
