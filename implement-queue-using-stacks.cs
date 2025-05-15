// 232. Implement Queue using Stacks   
// https://leetcode.com/problems/implement-queue-using-stacks
// Easy 36.2%
// 794.8001938492547
// Submission: https://leetcode.com/submissions/detail/70142461/
// Runtime: 492 ms
// 

public class Queue {
        Stack<int> forward = new Stack<int>();
    Stack<int> reverse = new Stack<int>();
        // Push element x to the back of queue.
    public void Push(int x) {
        reverse.Push(x);
    }
    // Removes the element from front of queue.
    public void Pop() {
        Peek();
        forward.Pop();
    }
    // Get the front element.
    public int Peek() {
        if (forward.Count == 0)
        {
            while (reverse.Count > 0)
                forward.Push(reverse.Pop());
        }
        return forward.Peek();
    }
    // Return whether the queue is empty.
    public bool Empty() {
        return forward.Count == 0 && reverse.Count==0;
    }
}
