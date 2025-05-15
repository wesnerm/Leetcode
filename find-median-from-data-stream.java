// 295. Find Median from Data Stream   
// https://leetcode.com/problems/find-median-from-data-stream
// Hard 25.5%
// 705.9141629466372
// Submission: https://leetcode.com/submissions/detail/68416722/
// Runtime: 59 ms
// Your runtime beats 100.00 % of java submissions.

class MedianFinder {
    // max queue is always larger or equal to min queue
    PriorityQueue<Integer> min = new PriorityQueue();
    PriorityQueue<Integer> max = new PriorityQueue(1000, Collections.reverseOrder());
    // Adds a number into the data structure.
    public void addNum(int num) {
        max.offer(num);
        min.offer(max.poll());
        if (max.size() < min.size()){
            max.offer(min.poll());
        }
    }
    // Returns the median of current data stream
    public double findMedian() {
        if (max.size() == min.size()) return (max.peek() + min.peek()) /  2.0;
        else return max.peek();
    }
};
