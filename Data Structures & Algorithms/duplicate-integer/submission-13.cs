public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int> noDuplicated = new();

        for (int i = 0; i < nums.Count(); i++) {
            if (noDuplicated.Contains(nums[i])) {
                return true;
            }
            noDuplicated.Add(nums[i]);
        }
        return false;
    }
}