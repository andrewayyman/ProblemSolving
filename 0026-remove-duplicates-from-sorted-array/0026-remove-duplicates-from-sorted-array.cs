public class Solution {
    public int RemoveDuplicates(int[] nums)
{
    int count = 0;
    foreach (int element in nums) {
        if (element != nums[count]) 
            { nums[++count] = element;}
    }
    return ++count;
}
}