# Power of two

This is the solution for power of two

```cpp
class Solution {
public:
    bool isPowerOfTwo(int n) 
    {
        if(n==0) return false;
        while(n % 2 == 0) n = n/2;
        return n==1;
        
    }
};
```