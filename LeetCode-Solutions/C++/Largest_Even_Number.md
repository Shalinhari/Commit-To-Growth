# Largest Even Number

This is the solution for largest even number

```cpp
class Solution {
public:
    string largestEven(string s) {
        for (int i = s.size() - 1; i >= 0; i--) {
            if (s[i] == '2') {
                return s.substr(0, i + 1);
            }
        }
        return "";
    }
};
```