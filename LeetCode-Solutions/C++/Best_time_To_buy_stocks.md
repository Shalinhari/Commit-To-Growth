# Best time to buy stocks

This is the solution for best time to buy the stocks

```cpp
class Solution {
public:
    int maxProfit(vector<int>& prices) 
    {
        int current_stock = prices[0];
        int profit = 0;

        for( int i =0;i<prices.size(); i++)
        {
            if(prices[i]< current_stock)
            {
            current_stock = prices[i];
            }else
            {
             int current_profit = prices[i]-current_stock;
             profit =max(current_profit, profit);
            }
        }
        return profit;
    }
};
```