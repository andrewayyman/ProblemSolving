public class Solution {
    public int[] GetConcatenation(int[] nums) {
        var n = nums.Length;
        var newarr = new int[2*n];

        if ( n>= 1 && n<= 1000 )
        {
            Array.Copy(nums, newarr,n );
            for ( int i = 0; i <= nums.Length; i++ )
            {
                if ( i < n )
                {
                    newarr[i + n] = nums[i];
                }
                else
                {
                    break;
                }

            }
            return newarr;

        }
        return new int[] { };
            }
}