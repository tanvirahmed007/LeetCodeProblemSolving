public class Solution {
    public int MaxSubArray(int[] nums) {
        int currentSum = nums[0], maxSoFar = nums[0];
        
        for(var i=1; i<nums.Length; i++)
        {
            if(currentSum<0)
            {
                currentSum = 0;
                
            }
            currentSum += nums[i];
            if(currentSum>maxSoFar)
            {
                maxSoFar = currentSum;
            }
        }
    return maxSoFar;
    }
}