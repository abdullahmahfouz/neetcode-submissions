public class MinStack {
    private Stack<int> stack;
    private Stack<int> minStack;  // Better name than 'tmp'
    
    public MinStack() {
        stack = new Stack<int>();
        minStack = new Stack<int>();
    }
    
    public void Push(int val) {
        stack.Push(val);
        
        // Push to minStack if it's empty or val is <= current min
        if (minStack.Count == 0 || val <= minStack.Peek()) {
            minStack.Push(val);
        }
    }
    
    public void Pop() {
        int popped = stack.Pop();
        
        // If we popped the current minimum, remove it from minStack too
        if (popped == minStack.Peek()) {
            minStack.Pop();
        }
    }
    
    public int Top() {
        return stack.Peek();
    }
    
    public int GetMin() {
        return minStack.Peek();
    }
}
    

