public class Solution {
    public bool IsValid(string s) {
        Stack<char> stack = new Stack<char>(); // Initialize stack to keep track of patterns
        Dictionary<char, char> parentheses = new Dictionary<char, char>(); // Define pattern needed for the problem
        parentheses['('] = ')';
        parentheses['{'] = '}';
        parentheses['['] = ']';

        foreach(char ch in s){ // Loop through the string by character
            if (parentheses.ContainsKey(ch)) stack.Push(ch); // If the given character is an opening parentheses
            else { // If the given character is a closing parentheses
                if (stack.Count == 0) return false; // If the stack is empty, return false
                if (parentheses[stack.Peek()] == ch) stack.Pop(); // If the character matches with a value of any key, Pop it
                else return false;
            }
        }

        return stack.Count == 0; // If stack is empty, the string has a pattern
    }
}
