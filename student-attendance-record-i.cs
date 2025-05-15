// 551. Student Attendance Record I   
// https://leetcode.com/problems/student-attendance-record-i
// Easy 43.7%
// 158.10673941027866
// Submission: https://leetcode.com/submissions/detail/101836355/
// Runtime: 6 ms
// Your runtime beats 5.66 % of cpp submissions.

class Solution {
public:
    bool checkRecord(string s) {
        int absent = 0;
        int late = 0;
                for (auto ch : s)
        {
            if (ch == 'A' && ++absent > 1)
                return false;
            if (ch == 'L')
            {
                if (++late > 2)
                    return false;
            }
            else
            {
                late = 0;
            }
        }
                return true;
    }
};
