public class Solution {
    public bool IsValid(string s) {
        var chars = s.ToCharArray();
            var stack = new Stack<char>();
            foreach (var c in chars)
            {
                var top = !stack.Any() ? '\0' : stack.Peek();

                switch (top)
                {   
                    case '(' when c == ')':
                    case '{' when c == '}':
                    case '[' when c == ']':
                        stack.Pop();
                        break;
                    default:
                        stack.Push(c);
                        break;
                }
            }
            return !stack.Any();
    }
}