# Check Divisibility By Digit Sum and Product

This is the solution to check divisibility by digit sum and product

```cpp
#include <stack>
class Solution {
public:
    bool isValid(string s)
     {
        stack<char> st;

        for(char c : s)
        {
            if(c =='(')
            st.push(')');
            else if(c == '{')
            st.push('}');
            else if(c == '[')
            st.push(']');
            else {
            if(st.empty() || st.top()!=c)
            return false;
            st.pop();
            }
        }
        return st.empty();   
    }
};
```