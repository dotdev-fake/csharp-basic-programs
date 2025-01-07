public class Solution {
    public string LongestCommonPrefix(string[] strs) {

        string commonPrefix=strs[0]; // Start with first string
        foreach(string str in strs){ // Iterate through each string in the string array
            while(!str.StartsWith(commonPrefix)){ // Checks if the given string is similar to the commonPrefix
                commonPrefix=commonPrefix.Substring(0, commonPrefix.Length-1); // If it doesnt match, keep reducing one chracter till it matches the prefix
                if(commonPrefix=="") return ""; // Simply return an empty string if it doesnt match the prefix
            }
        }

        return commonPrefix;
    }
}
