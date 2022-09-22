public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        List<int> arr = new List<int>();
        for(var i = 0 ; i< nums.Length ; i++){
           if (arr.Contains(nums[i]))
                return true;
            else 
                arr.Add(nums[i]);
       }
        return false;
    }
}