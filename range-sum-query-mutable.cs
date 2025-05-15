// 307. Range Sum Query - Mutable   
// https://leetcode.com/problems/range-sum-query-mutable
// Medium 19.9%
// 445.4199137424702
// Submission: https://leetcode.com/submissions/detail/67761531/
// Runtime: 572 ms
// Your runtime beats 100.00 % of csharp submissions.

public class NumArray {
    int[] mat;
    int[] tree;
    int rows;
        public NumArray(int[] nums) {
        rows = nums.Length;
        mat = new int[rows];
        tree = new int[rows+1];
        for (int r=0; r<rows; r++)
                Update(r,nums[r]);        
    }
    public void Update(int row, int val) {
        int delta = val - mat[row];
        mat[row] = val;
        for (int i=row+1; i<=rows; i+= (i&-i))
                tree[i] += delta;
    }
    public int SumRange(int i, int j) {
        return Sum(j+1)-Sum(i);
    }
        public int Sum(int row)
    {
        int sum=0;
        for (int i=row; i>0; i -= i&-i)
                sum += tree[i];
        return sum;
    }
}
// Your NumArray object will be instantiated and called as such:
// NumArray numArray = new NumArray(nums);
// numArray.SumRange(0, 1);
// numArray.Update(1, 10);
// numArray.SumRange(1, 2);
