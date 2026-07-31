public class Solution {
    public bool IsAnagram(string s, string t) {
        return s.OrderBy(s => s).SequenceEqual(t.OrderBy(t => t));
    }
}
