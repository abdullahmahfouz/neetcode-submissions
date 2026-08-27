public class Solution
{
    public bool IsValid(string s)
    {
        // Optional micro-optimization: odd length can’t be valid
        if ((s?.Length ?? 0) % 2 == 1) return false;

        Stack<char> stack = new Stack<char>();

        foreach (char c in s)
        {
            // Push openings
            if (c == '(' || c == '[' || c == '{')
            {
                stack.Push(c);
            }
            // Handle closings
            else if (c == ')' || c == ']' || c == '}')
            {
                if (stack.Count == 0) return false; // no opener to match

                char top = stack.Pop();
                if (!IsMatchingPair(top, c)) return false;
            }
            // If inputs can include other characters, either ignore or return false.
            // For LeetCode "Valid Parentheses", input is only brackets, so no else needed.
        }

        return stack.Count == 0; // all openers matched and popped
    }

    private static bool IsMatchingPair(char opening, char closing)
    {
        return (opening == '(' && closing == ')')
            || (opening == '[' && closing == ']')
            || (opening == '{' && closing == '}');
    }
}