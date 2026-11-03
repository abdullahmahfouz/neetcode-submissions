from typing import List

class Solution:
    def evalRPN(self, tokens: List[str]) -> int:
        stack = []

        for token in tokens:
            if token == "+":
                # Order doesn't matter for addition, but conversion does
                b = int(stack.pop())
                a = int(stack.pop())
                stack.append(a + b)

            elif token == "-":
                # First pop is the right side, second pop is the left side
                b = int(stack.pop())
                a = int(stack.pop())
                stack.append(a - b)  # a is left, b is right (a - b)
            
            elif token == "*":
                b = int(stack.pop())
                a = int(stack.pop())
                stack.append(a * b)

            elif token == "/":
                b = int(stack.pop())
                a = int(stack.pop())
                # Python's int() truncates toward zero, matching LeetCode requirements
                stack.append(int(a / b))  # a is numerator, b is denominator (a / b)
            
            else:
                # Push the number token as an integer immediately to simplify things
                stack.append(int(token))
        
        return stack[-1]
