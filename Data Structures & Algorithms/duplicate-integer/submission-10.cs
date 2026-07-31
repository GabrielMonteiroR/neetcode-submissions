public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int> mySet = new();
        
        foreach(int number in nums) {
            if(!mySet.Add(number)) return true;
            
        }

        return false;
    }
}