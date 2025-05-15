// 359. Logger Rate Limiter   
// https://leetcode.com/problems/logger-rate-limiter
// Easy 59.4%
// 338.8937184586567
// Submission: https://leetcode.com/submissions/detail/68202038/
// Runtime: 189 ms
// Your runtime beats 31.59 % of java submissions.

public class Logger {
    private Map<String, Integer> ok = new HashMap<>();
    /** Initialize your data structure here. */
    public Logger() {
            }
        /** Returns true if the message should be printed in the given timestamp, otherwise returns false.
        If this method returns false, the message will not be printed.
        The timestamp is in seconds granularity. */
    public boolean shouldPrintMessage(int timestamp, String message) {
        if (timestamp < ok.getOrDefault(message, 0))
            return false;
        ok.put(message, timestamp + 10);
        return true;
    }
}
/**
 * Your Logger object will be instantiated and called as such:
 * Logger obj = new Logger();
 * boolean param_1 = obj.shouldPrintMessage(timestamp,message);
 */
