# Find Closest Person

This is the solution for find the closest person 

```cpp
class Solution {
public:
    int findClosest(int x, int y, int z) 
    {
        if(abs(z-x) < abs(z-y))
        {
            return 1;
        }
        else if (abs(z-y) < abs(z-x))
        {
            return 2;
        }
        else
        {
            return 0;
        }
        

        
    }
};
```