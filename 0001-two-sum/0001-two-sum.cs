public class Solution {
    public int[] TwoSum(int[] nums, int target) {

     Dictionary<int, int> ourDict = new Dictionary<int, int>();

     for ( int i = 0; i < nums.Length; i++ )
     {
         int diff = target - nums[i];

         if ( ourDict.ContainsKey(diff) )
         {
             return new int[] { ourDict[diff], i };
         }

         if ( !ourDict.ContainsKey(nums[i]) )
         {
             ourDict[nums[i]] = i;
         }
     
 }

 return new int[0];
    }
}
