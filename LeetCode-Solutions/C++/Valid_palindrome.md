# two Sum

This is the solution for valid parentheses

```cpp
class Solution {
public:
    bool isPalindrome(string s) 
    {
        string result;
        for( char c : s)
        {
           if(isalnum(c))
           result += tolower(c);
        }

        int left = 0;
        int right = result.size()-1;

        while(left < right)
        {
            if(result[left] != result[right])
            return false;

            left++;
            right--;
        }
        return true;
    }
};
```