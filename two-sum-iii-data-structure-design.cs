// 170. Two Sum III - Data structure design   
// https://leetcode.com/problems/two-sum-iii-data-structure-design
// Easy 23.9%
// 481.9185921608562
// Submission: https://leetcode.com/submissions/detail/70745703/
// Runtime: 980 ms
// Your runtime beats 13.04 % of csharp submissions.

public class TwoSum {
    Dictionary<int, int> numbers = new Dictionary<int, int>();
    // Add the number to an internal data structure.
    public void Add(int number) {
        if (!numbers.ContainsKey(number))
            numbers[number]=0;
         numbers[number]++;
    }
    // Find if there exists any pair of numbers which sum is equal to the value.
    public bool Find(int value) {
        foreach(var k in numbers.Keys)
        {
            var diff = value - k;
            if (numbers.ContainsKey(diff) && (diff != k || numbers[k]>1))
                return true;
        }
        return false;
    }
}
// Your TwoSum object will be instantiated and called as such:
// TwoSum twoSum = new TwoSum();
// twoSum.Add(number);
// twoSum.Find(value);
