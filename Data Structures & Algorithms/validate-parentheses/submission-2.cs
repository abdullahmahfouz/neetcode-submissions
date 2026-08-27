public class Solution {
    public bool IsValid(string s) {
        Stack<char> stack = new Stack<char>();
        
        foreach (char c in s) {
            // If it's an opening bracket, push it
            if (c == '(' || c == '[' || c == '{') {
                stack.Push(c);
            }
            // If it's a closing bracket
            else if (c == ')' || c == ']' || c == '}') {
                // Check if stack is empty (no matching opening bracket)
                if (stack.Count == 0) {
                    return false;
                }
                
                char top = stack.Pop();
                
                // Check if the brackets match
                if ((c == ')' && top != '(') ||
                    (c == ']' && top != '[') ||
                    (c == '}' && top != '{')) {
                    return false;
                }
            }
        }
        
        return stack.Count == 0;
    }
}
