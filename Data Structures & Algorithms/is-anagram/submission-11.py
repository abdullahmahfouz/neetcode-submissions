class Solution:
    def isAnagram(self, s: str, t: str) -> bool:
   # Step 1: Check Lengths
     if len(s) != len(t):
        return False

    # Step 2: Create Dictionaries
     countS = {}
     countT = {}

    # Step 3: Count the frequencies
     for i in range(len(s)):
        # Handle string s
         charS = s[i]
         if charS in countS:
             countS[charS] += 1
         else:
             countS[charS] = 1
            
        # Handle string t
         charT = t[i]
         if charT in countT:
             countT[charT] += 1
         else:
             countT[charT] = 1

    # Step 4: Compare
     return countS == countT
        
