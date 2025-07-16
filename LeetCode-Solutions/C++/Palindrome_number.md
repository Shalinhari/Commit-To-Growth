# Palindrome Number

This is the solution for palindrome Number

```cpp
class Solution {
public:
    bool isPalindrome(int x) 
    { 
        int num =x;
        long long reverse=0;
        while(x>0)
        {
            int rem = x%10;
            reverse = reverse * 10 + rem;
            x = x/10;
        }
        if(num==reverse) return true;

        return false;
    }
};
```