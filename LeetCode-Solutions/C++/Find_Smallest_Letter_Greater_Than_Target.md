# Find the smallest letter greater than target

This is the solution for finding the smallest letter greater than target

```cpp
class Solution {
public:
    char nextGreatestLetter(vector<char>& letters, char target) {
        for (int i = 0; i < letters.size(); i++) {
            if (target < letters[i]) {
                return letters[i];
            }
        }
        return letters[0]; // wrap-around case
    }
};
```