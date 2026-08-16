public class Solution {
    public int MaxProfit(int[] prices) {
        int min = int.MaxValue;
        int max =0;
        foreach(int x in prices){
            if(x<min){
                min = x;
            }else{
                max = Math.Max(max,x-min);
            }
            //return max ;


        }
        return max;
        
    }
}