// 271. Encode and Decode Strings   
// https://leetcode.com/problems/encode-and-decode-strings
// Medium 26.1%
// 409.5946517607436
// Submission: https://leetcode.com/submissions/detail/68447400/
// Runtime: 532 ms
// Your runtime beats 46.15 % of csharp submissions.

public class Codec 
    {
        // Encodes a list of strings to a single string.
        public string encode(IList<string> strs)
        {
            var sb = new StringBuilder();
            foreach (var s in strs)
            {
                sb.Append((char)(s.Length % 256));
                sb.Append((char) ((s.Length >> 8)%256));
                sb.Append((char) ((s.Length >> 16)%256));
                sb.Append((char)((s.Length >> 24) % 256));
                sb.Append(s);
            }
            return sb.ToString();
        }
        // Decodes a single string to a list of strings.
        public IList<string> decode(string s)
        {
            int i = 0;
            var strings = new List<string>();
            while (i < s.Length)
            {
                int len = s[i] + (s[i + 1] << 8) + (s[i + 2] << 16) + (s[i + 3] << 24);
                i += 4;
                strings.Add(s.Substring(i, len));
                i += len;
            }
            return strings;
        }
    }
        // Your Codec object will be instantiated and called as such:
// Codec codec = new Codec();
// codec.decode(codec.encode(strs));
