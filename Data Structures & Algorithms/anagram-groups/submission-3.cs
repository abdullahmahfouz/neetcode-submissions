public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {

        var dict = new Dictionary<string, List<string>>();

        foreach(var s in strs){
            var count = new int[26];

            foreach(var c in s){
                count[c - 'a']++ ;
            }
            var key = string.Join(",", count);

            if (!dict.ContainsKey(key)){
                dict[key] = new List<string>();
            }

            dict[key].Add(s);

        }

        return dict.Values.ToList<List<string>>();
    } 
}
