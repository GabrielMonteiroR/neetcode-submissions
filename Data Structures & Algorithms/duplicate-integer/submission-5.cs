public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int> hashSet = new(nums);
        return hashSet.Count() != nums.Count();
    }
}