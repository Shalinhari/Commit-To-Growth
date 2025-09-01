# Get Least Frequency Number

This is the solution for getting the least frequency number

```cpp
class Solution {
public:
    int getLeastFrequentDigit(int n)
    {
        map<int, int> mp;
        int digit = n;
        while(n>0)
        {
            digit = n%10;
            mp [digit]++;
            n = n/10;
        }

        int min = INT_MAX;
        int result = 0;

        for( auto it : mp)
        {
            if(it.second < min)
            {
                min = it.second;
                result = it.first;
            }
        }
        
        return result;
    }
};
```