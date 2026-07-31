public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int> values = new (nums);
        return values.Count() != nums.Count();
    }
}