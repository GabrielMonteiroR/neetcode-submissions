public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int,int> map = new();

         var freq = nums.GroupBy(x => x)
                       .ToDictionary(g => g.Key, g => g.Count());

        var heap = new PriorityQueue<int, int>();

        foreach (var kvp in freq)
        {
            heap.Enqueue(kvp.Key, kvp.Value);
            if (heap.Count > k)
                heap.Dequeue();
        }

        return heap.UnorderedItems.Select(x => x.Element).ToArray();

}
}