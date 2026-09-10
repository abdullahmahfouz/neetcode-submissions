class Solution:
    def twoSum(self, nums: List[int], target: int) -> List[int]:
      nummap = {} # val -> index

      for i, num in enumerate(nums):
        diff = target - num

        if diff in nummap:
            return [nummap[diff] , i]
        
        nummap[num] = i 
