# First Bad Version

This is the solution for First Bad version

```cpp
class Solution {
public:
    int firstBadVersion(int n)
    {

        int start  = 1;
        int end = n;

        while( start < end )
        {
            int mid = start + (end - start) /2;

            if( isBadVersion(mid))
              end = mid;
            else
              start = mid + 1;
        }
        return start;
    }
};
```