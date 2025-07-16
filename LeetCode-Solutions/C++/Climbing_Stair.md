# two Sum

This is the solution for climbing stairs

```cpp
class Solution {
public:
    int climbStairs(int n) 
    {
        if(n <= 3) 
        return n;

        int previousElement = 3;
        int previousElement1 = 2;
        int currentElement = 0;

        for(int i =3; i<n; i++)
        {
          currentElement = previousElement + previousElement1;
          previousElement1 = previousElement;
          previousElement = currentElement;  
        }
        return currentElement;
    }
};
```