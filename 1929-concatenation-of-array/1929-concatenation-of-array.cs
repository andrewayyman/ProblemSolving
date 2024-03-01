public class Solution {
    public int[] GetConcatenation(int[] nums) {
         int[] Ans = new int[nums.Length * 2];
         nums.CopyTo(Ans, 0); // Ans =[1,2,1]
         nums.CopyTo(Ans, nums.Length); // Ans = [1,2,1,1,2,1]
         return Ans;
    }
}