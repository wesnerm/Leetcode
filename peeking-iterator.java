// 284. Peeking Iterator   
// https://leetcode.com/problems/peeking-iterator
// Medium 35.3%
// 611.0941360737855
// Submission: https://leetcode.com/submissions/detail/68027386/
// Runtime: 112 ms
// Your runtime beats 41.88 % of java submissions.

// Java Iterator interface reference:
// https://docs.oracle.com/javase/8/docs/api/java/util/Iterator.html
class PeekingIterator implements Iterator<Integer> {
    public static final int NOTPEEKED = 0;
    public static final int PEEKED = 1;
    public static final int FINISHED = 2;
    int state;
    Integer peekValue;
    Iterator<Integer> iter;
        public PeekingIterator(Iterator<Integer> iterator) {
        // initialize any member here.
        iter = iterator;
        state = NOTPEEKED;
    }
    // Returns the next element in the iteration without advancing the iterator.
    public Integer peek() {
        pull();
        return peekValue;
    }
    // hasNext() and next() should behave the same as in the Iterator interface.
    // Override them if needed.
    @Override
    public Integer next() {
        pull();
        if (state == FINISHED)
            return null;
        state = NOTPEEKED;
        return peekValue;
    }
    @Override
    public boolean hasNext() {
        pull();
        return state != FINISHED;
    }
        private void pull()
    {
        if (state == NOTPEEKED)
        {
            if (iter.hasNext())
            {
                peekValue = iter.next();
                state = PEEKED;
            }
            else
            {
                peekValue = null;
                state = FINISHED;
            }
        }
    }
}
