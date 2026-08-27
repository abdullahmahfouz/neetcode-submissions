class Solution:
    def groupAnagrams(self, strs: List[str]) -> List[List[str]]:
       group_anagrams = defaultdict(list)

       for s in strs:
           count = [0] * 26
           
           # Inner loop: ONLY builds the count
           for char in s: 
               count[ord(char) - ord('a')] += 1
           
           # OUTSIDE inner loop: Append the result once per word
           group_anagrams[tuple(count)].append(s) 
       
       return list(group_anagrams.values())

