public class Solution {
    public int[] RunningSum(int[] nums) {
        // nums= [1,2,3,4] -> [1,3,6,10]

        int sum = 0;
        if ( nums.Length >= 1 && nums.Length <= 1000 )
        {
            sum = nums[0];
            for ( int i = 1; i < nums.Length; i++ )
            {
                nums[i] += sum;
                sum = nums[i];
            }
            return nums;


        }
        return new int[] { };
    }
}