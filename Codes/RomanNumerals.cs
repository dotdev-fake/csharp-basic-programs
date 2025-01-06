public class Solution {
    public int RomanToInt(string s) {
        
        Dictionary<char, int> symbolTable = new Dictionary<char, int>();
        symbolTable['I'] = 1;
        symbolTable['V'] = 5;
        symbolTable['X'] = 10;
        symbolTable['L'] = 50;
        symbolTable['C'] = 100;
        symbolTable['D'] = 500;
        symbolTable['M'] = 1000;

        int output = 0;
        for (int i=0;i<s.Length - 1;i++){
            if (symbolTable.ContainsKey(s[i]) && symbolTable.ContainsKey(s[i+1])){
                int val1 = symbolTable[s[i]];
                int val2 = symbolTable[s[i+1]];

                if (val1<val2) output -= val1;
                else output += val1;
            }
        }

        output += symbolTable[s[s.Length-1]];
        return output;
    }
}
