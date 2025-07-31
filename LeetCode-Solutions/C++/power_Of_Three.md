# Power Of Three

This is the solution for Power of three

```cpp
class Solution {
public:
    bool isPowerOfThree(int n) 
    {
        if(n<=0) return false;

        while(n % 3 == 0)
        {
            n /= 3;
        }
        return n == 1;
        
    }
};
```