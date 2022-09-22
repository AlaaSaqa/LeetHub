public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        List<int> arr = new List<int>();
        foreach(var num in nums){
           if (arr.Contains(num))
                return true;
            else 
                arr.Add(num);
       }
        return false;
    }
}