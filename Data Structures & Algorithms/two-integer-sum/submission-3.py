class Solution:
     def twoSum(self, nums: List[int], target: int) -> List[int]:
     
         prev_map = {}  # Starts empty

         for i, n in enumerate(nums):
             diff = target - n
        
        # 1. Look for the partner BEFORE adding yourself
             if diff in prev_map:
                 return [prev_map[diff], i]
        
        # 2. If partner not found, add yourself to the map for future numbers to find
             prev_map[n] = i