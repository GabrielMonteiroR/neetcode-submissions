public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int> hash = new(nums);
        return hash.Count() != nums.Count();
    }
}