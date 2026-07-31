public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int> numbers = new(nums);
        return numbers.Count() != nums.Count();
    }
}