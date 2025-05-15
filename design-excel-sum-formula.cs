// 631. Design Excel Sum Formula   
// https://leetcode.com/problems/design-excel-sum-formula
// Hard 24.1%
// 241.2533998643538
// Submission: https://leetcode.com/submissions/detail/107384640/
// Runtime: 164 ms
// Your runtime beats 12.67 % of java submissions.

public class Excel {
    String[][][] grid;
    int[][] values;
    int[][] times;
        int time = 1;
    public int Letter(char c)
    {
        if (c>='A' && c <='Z') return c - 'A' + 1;
        if (c>='a' && c <='z') return c - 'a' + 1;
        return c;
    }
    public Excel(int H, char W) {
        int rows = H;
        int cols = Letter(W);
        grid = new String[rows+1][cols+1][];
        values = new int[rows+1][cols+1];
        times = new int[rows+1][cols+1];        
    }
        public void set(int r, char ch, int v) {
        time++;
        int c = Letter(ch);
        values[r][c] = v;
        grid[r][c] = null;
        times[r][c] = time;
    }
        public int get(int r, char ch) {
        int c = Letter(ch);
        return GetCore(r, c);        
    }
        public int GetCore(int r, int c) {
        if (times[r][c] == time)
            return values[r][c];
        String[] cell = grid[r][c];
        int result = cell==null ? values[r][c] : process(cell);
        values[r][c] = result;
        times[r][c] = time;
        return result;
    }
        int r1,r2,c1,c2;
    public int process(String[] strs)
    {
        int sum = 0;
        int[] results = new int[2];
        for(String range : strs)
        {
            int index = range.indexOf(':'); 
            int r1,r2,c1,c2;
            if (index<0)
            {
                ReadCoord(range, results);
                r2=r1 = results[0];
                c2=c1 = results[1];
            }
            else
            {
                int[] result = new int[2];
                ReadCoord(range.substring(0,index), result);
                r1 = result[0];
                c1 = result[1];
                ReadCoord(range.substring(index+1), result);
                r2 = result[0];
                c2 = result[1];
                            }
                        for (int rr=r1; rr<=r2; rr++)
                for (int cc=c1; cc<=c2; cc++)
                    sum += GetCore(rr, cc);
        }
                            return sum;
    }
        public int sum(int r, char ch, String[] strs) {
        int c = Letter(ch);
        time++;
        grid[r][c] = strs;
        return GetCore(r, c);        
    }
        public void ReadCoord(String s, int[] result)
    {
        result[0] = Integer.parseInt(s.substring(1));
        result[1] = Letter(s.charAt(0));
    }
}
/**
 * Your Excel object will be instantiated and called as such:
 * Excel obj = new Excel(H, W);
 * obj.set(r,c,v);
 * int param_2 = obj.get(r,c);
 * int param_3 = obj.sum(r,c,strs);
 */
