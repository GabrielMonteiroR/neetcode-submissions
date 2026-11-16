public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Count() != t.Count()) return false;

        var arrayOne = s.ToCharArray();
        var arrayTwo = t.ToCharArray();

        Array.Sort(arrayOne);
        Array.Sort(arrayTwo);

        return arrayOne.SequenceEqual(arrayTwo);
    }
}
