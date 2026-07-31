public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int> nonDuplicatedNums = new (nums);
        return nonDuplicatedNums.Count() != nums.Count();
    }
}