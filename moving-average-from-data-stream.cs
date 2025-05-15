// 346. Moving Average from Data Stream   
// https://leetcode.com/problems/moving-average-from-data-stream
// Easy 58.2%
// 604.5910406774664
// Submission: https://leetcode.com/submissions/detail/68172780/
// Runtime: 183 ms
// Your runtime beats 23.02 % of java submissions.

public class MovingAverage {
    Queue<Integer> queue = new LinkedList<Integer>();
    int size;
    double sum;
    /** Initialize your data structure here. */
    public MovingAverage(int size) {
        this.size = size;
    }
        public double next(int val) {
        queue.offer(val);
        sum += val;
                if (queue.size()>size)
        {
            int pop = queue.poll();
            sum -= pop;
        }
                return sum / queue.size(); 
    }
}
/**
 * Your MovingAverage object will be instantiated and called as such:
 * MovingAverage obj = new MovingAverage(size);
 * double param_1 = obj.next(val);
 */
