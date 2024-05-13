public class Solution {
    public int MaxAscendingSum(int[] nums) {
        int max = 0;
        int max2 = 0;
        int sum = 0;
        for(int i=0;i< nums.Length; i++){
            if(max < nums[i]){
                max = nums[i];
                sum += max;
            }
            else{
                max2 = Math.Max(sum,max2);
                max = nums[i];
                sum = nums[i];
            }

        }
        return Math.Max(max2,sum);
    }
}