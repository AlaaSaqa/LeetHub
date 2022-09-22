public class Solution {
    public int MaxSubArray(int[] nums) {
        int sum1=nums[0],sum2=0;
        for (var i=0 ; i<nums.Length ; i++){
            sum2+=nums[i];
            if (sum2>sum1){
                sum1=sum2;
            }
            if (sum2<0)sum2=0;
        }
        return sum1;
    }
}