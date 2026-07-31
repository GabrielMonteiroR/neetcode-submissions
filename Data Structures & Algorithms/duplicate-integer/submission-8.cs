public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int> mySet = new(nums);
        return mySet.Count != nums.Length;
    }
}