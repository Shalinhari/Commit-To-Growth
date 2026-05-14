# Reverse String Prefix

This is the solution for Reverse String Prefix

```cpp
class Solution {
public:
    string reversePrefix(string s, int k) {
        reverse(s.begin(), s.begin() + k);
        return s;
    }
};
```