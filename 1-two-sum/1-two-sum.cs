public class Solution {
    public int[] TwoSum(int[] nums, int target) {
         int [] x = new int[2];
        for (int i =0;i<nums.Length;i++){
            for (int j =i+1 ; j<nums.Length;j++){
                if (nums[i]+nums[j]==target){
                    x[0]=i;
                    x[1]=j;
                    return x;
                }
            }
        }
        return null;
    }
}