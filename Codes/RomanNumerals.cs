public class Solution {
    public int RomanToInt(string s) {

        // Define roman numerals, Note: They go in ascending order, which is useful for solving
        Dictionary<char, int> symbolTable = new Dictionary<char, int>();
        symbolTable['I'] = 1;
        symbolTable['V'] = 5;
        symbolTable['X'] = 10;
        symbolTable['L'] = 50;
        symbolTable['C'] = 100;
        symbolTable['D'] = 500;
        symbolTable['M'] = 1000;

        int output = 0;
        for (int i=0;i<s.Length - 1;i++){ // Only iterate until second to the last value
            if (symbolTable.ContainsKey(s[i]) && symbolTable.ContainsKey(s[i+1])){
                int val1 = symbolTable[s[i]];
                int val2 = symbolTable[s[i+1]];

                if (val1<val2) output -= val1; // If current roman numeral is lesser than the next numeral, subtract the current upcoming numeral value.
                else output += val1; // Normal addition if its not lesser than
            }
        }

        output += symbolTable[s[s.Length-1]]; // Add the last value to complete the loop and roman numeral
        return output;
    }
}
