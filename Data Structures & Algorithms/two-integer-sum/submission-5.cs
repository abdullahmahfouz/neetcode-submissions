public class Solution {
    public int[] TwoSum(int[] nums, int target) {

        var map = new Dictionary<int, int>();

        for(int i = 0; i < nums.Length; i ++){
            map[nums[i]] = i;
            
        }

        for(int i = 0; i < nums.Length; i ++){
            int diff = target - nums[i];

            if(map.ContainsKey(diff) && map[diff] != i){
                return new int[]{i, map[diff]};
            }
        }

        return new int[0];
       

    }
}
