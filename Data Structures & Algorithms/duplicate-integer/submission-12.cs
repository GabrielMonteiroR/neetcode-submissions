public class Solution {
    public bool hasDuplicate(int[] nums) {
       HashSet<int> notRepeatedNumbers = new (nums);
       return  notRepeatedNumbers.Count() != nums.Count();
    }
}