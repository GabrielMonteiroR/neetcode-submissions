public class Solution {
    public bool hasDuplicate(int[] nums) {
    HashSet<int> noDup = new(nums);
    return noDup.Count() != nums.Count();    
    }
}