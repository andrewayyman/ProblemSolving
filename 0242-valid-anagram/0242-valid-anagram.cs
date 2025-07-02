public class Solution {
    public bool IsAnagram(string s, string t) {
         if ( s.Length != t.Length )
     return false;

 s = s.ToLower();
 t = t.ToLower();

 Dictionary<char, int> charCount = new Dictionary<char, int>();
 foreach ( char c in s )
 {
     if ( charCount.ContainsKey(c) )
         charCount[c]++;
     else
         charCount[c] = 1;
 }
 foreach ( char c in t )
 {
     if ( charCount.ContainsKey(c) )
     {
         charCount[c]--;
         if ( charCount[c] < 0 )
             return false;
     }
     else
     {
         return false;
     }
 }

 foreach ( var count in charCount.Values )
 {
     if ( count != 0 )
         return false;
 }
 return true;
    }
}