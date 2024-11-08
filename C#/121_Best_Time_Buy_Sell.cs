public class Solution {
    public int MaxProfit(int[] prices) {
        int maxProfit = 0, minPrice = prices[0];
        
        for(var i=1; i<prices.Length; i++)
        {
            maxProfit = Math.max(maxProfit,prices[i] - minPrice);
            minPrice = Math.min(minPrice,prices[i]);
        }
    return maxProfit;
    }
}