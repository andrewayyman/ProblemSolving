public class Solution {
    public int LengthOfLastWord(string s) {
        char delimiter = ' ';  // Space is the delimiter

        string[] words = s.Trim().Split(delimiter); // words [ "Hello", "World" ]
        string lastWord = words[words.Length - 1];
        Console.WriteLine(lastWord.Length);
        return lastWord.Length;
    }
}