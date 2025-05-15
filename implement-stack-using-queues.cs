// 225. Implement Stack using Queues   
// https://leetcode.com/problems/implement-stack-using-queues
// Easy 32.4%
// 585.5364338442868
// Submission: https://leetcode.com/submissions/detail/70143337/
// Runtime: 480 ms
// 

public class Stack {
    Queue<int> queue = new Queue<int>();
        // Push element x onto stack.
    public void Push(int x) {
        int c = queue.Count;
        queue.Enqueue(x);
        while (c-- > 0)
            queue.Enqueue(queue.Dequeue());
    }
    // Removes the element on top of the stack.
    public void Pop() {
        queue.Dequeue();
    }
    // Get the top element.
    public int Top() {
        return queue.Peek();
    }
    // Return whether the stack is empty.
    public bool Empty() {
        return queue.Count==0;
    }
}
