// 362. Design Hit Counter   
// https://leetcode.com/problems/design-hit-counter
// Medium 53.7%
// 517.8405496013377
// Submission: https://leetcode.com/submissions/detail/69537714/
// Runtime: 0 ms
// Your runtime beats 97.63 % of cpp submissions.

class HitCounter {
public:
    int hits[300] = {};
    int times[300] = {};
    /** Initialize your data structure here. */
    HitCounter() {
    }
        /** Record a hit.
        @param timestamp - The current timestamp (in seconds granularity). */
    void hit(int timestamp) {
        int bucket = timestamp % 300;
        if (times[bucket] != timestamp)
        {
            hits[bucket] = 0;
            times[bucket] = timestamp;
        }
        hits[bucket]++;
    }
        /** Return the number of hits in the past 5 minutes.
        @param timestamp - The current timestamp (in seconds granularity). */
    int getHits(int timestamp) {
        int h=0;
        for (int i=0; i<300; i++)
            if (times[i] > timestamp-300)
                h += hits[i];
        return h;
    }
};
/**
 * Your HitCounter object will be instantiated and called as such:
 * HitCounter obj = new HitCounter();
 * obj.hit(timestamp);
 * int param_2 = obj.getHits(timestamp);
 */
