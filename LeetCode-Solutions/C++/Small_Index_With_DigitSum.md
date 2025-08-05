# Small index with Digit Sum

This is the solution for small index with digit sum

```cpp
class Solution {
public:
    int sumOfNumber(int n)
        {
            int sum = 0;
            while(n>0)
            {
                sum += n%10;
                n /=10;
            }
            return sum;
        }

    int smallestIndex(vector<int>& nums)
    {
        for(int i = 0; i <nums.size(); i++)
        {
            if(i == sumOfNumber(nums[i]))
            return i;
        }    
        return -1;
    }
};
```