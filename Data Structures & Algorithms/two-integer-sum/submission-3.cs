public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> map = new();

        for(int i=0; i < nums.Length; i++) {
            var aux = target - nums[i];
            if(map.ContainsKey(aux)) {
                return new int[] {map[aux], i };
            }

            map[nums[i]] = i;
        }

        return Array.Empty<int>();
    }
}