public class Solution {
    public long MaximumHappinessSum(int[] happiness, int k) {
        long sum = 0;
        int rounds = 0;
        Array.Sort(happiness, (a,b) => b-a);
        for(int i=0; i<k && i< happiness.Length;i++){
            int sel = happiness[i] - rounds;
            if(sel > 0){
                sum += sel;
                rounds++;
            }
        }
        return sum;
    }
}