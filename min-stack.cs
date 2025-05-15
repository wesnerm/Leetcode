// 155. Min Stack   
// https://leetcode.com/problems/min-stack
// Easy 28.5%
// 1553.2102581278614
// Submission: https://leetcode.com/submissions/detail/67654585/
// Runtime: 135 ms
// Your runtime beats 15.13 % of java submissions.

public class MinStack {
    Stack<Integer> stack;
    int min = Integer.MAX_VALUE;
    /** initialize your data structure here. */
    public MinStack() {
        stack = new Stack<Integer>();
    }
        public void push(int x) {
        if (x<=min)
        {
            stack.push(min);
            min = x;
        }
        stack.push(x);
    }
        public int pop() {
        int value = stack.pop();
        if (value == min)
            min=stack.pop();
        return value;
    }
        public int top() {
        return stack.peek();
    }
        public int getMin() {
        return min;
    }
}
/**
 * Your MinStack object will be instantiated and called as such:
 * MinStack obj = new MinStack();
 * obj.push(x);
 * obj.pop();
 * int param_3 = obj.top();
 * int param_4 = obj.getMin();
 */
