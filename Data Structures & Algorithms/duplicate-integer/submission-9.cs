public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int> mySet = new();
        
        foreach(int number in nums) {
            if(mySet.Contains(number)) return true;
            mySet.Add(number);
        }

        return false;
    }
}