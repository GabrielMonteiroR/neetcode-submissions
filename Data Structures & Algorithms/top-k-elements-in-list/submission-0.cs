public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int,int> map = new();

        foreach(var n in nums) {
            if(!map.ContainsKey(n)) {
                map[n] = 1;
            } else {
                map[n]++;
            }
        }

        return map
            .OrderByDescending(x => x.Value)
            .Take(k)
            .Select(x => x.Key)
            .ToArray();

    }
}
