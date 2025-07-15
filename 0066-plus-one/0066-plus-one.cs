public class Solution {
    public int[] PlusOne(int[] digits) {
        // digits=[1,2,3] -->> 123 -->> 123+1 -->> 124 -->> answer = [1,2,4]

        var n = digits.Length;
        if ( n >= 1 && n <= 100 ) // Check the constraints
        {
            for ( int i = n - 1; i >= 0; i-- )
            {
                if ( digits[i] < 9 )
                {
                    digits[i]++;
                    return digits;
                }
                digits[i] = 0;
            }
            // If we reach here, it means all digits were 9
            var result = new int[n + 1];
            result[0] = 1;
            return result;
        }


        return new int[] { };
            }
}