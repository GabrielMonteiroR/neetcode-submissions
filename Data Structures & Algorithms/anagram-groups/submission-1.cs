public class Solution
{
    public List<List<string>> GroupAnagrams(string[] strs)
    {
        Dictionary<string, List<string>> groups = new();

        foreach (var word in strs)
        {
            var key = new string(word.OrderBy(c => c).ToArray());

            if (!groups.ContainsKey(key))
                groups[key] = new List<string>();

            groups[key].Add(word);
        }

        return groups.Values.ToList();
}
}
