public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int> set = new(nums);
        return set.Count() != nums.Count();
    }
}