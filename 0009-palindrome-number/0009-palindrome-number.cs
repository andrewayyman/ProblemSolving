public class Solution {
    public bool IsPalindrome(int x) {
         if (x < 0 || ((x % 10) == 0 && x > 10 ) ) return false; //not palindrome
         if (x < 10) return true;                    //single digit is palindrome

         int OriginalX = x;
         int NumReversed = 0;
         while (x > 0)
         {
             // Assume x = 121 
            int LastDigit = x % 10; 
             // 1 .... 2  .... 1
            NumReversed = NumReversed * 10 + LastDigit;
             // 0 * 10 + 1 = 1...... 1 * 10 + 2 = 12.... 12 * 10 + 1 = 121
             x /= 10; 
             // 12.... 1.... 0
         }   

             return OriginalX == NumReversed; // 121 == 121 true
            }
}