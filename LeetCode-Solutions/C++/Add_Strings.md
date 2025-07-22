# two Sum

This is the solution for add strings

```cpp
class Solution {
public:
    string addStrings(string num1, string num2)
    {
        int i = num1.size() - 1;
        int j = num2.size() - 1;
        string result = "";
        int carry = 0;

        while( i>=0 || j>=0 || carry)
        {
            int n1 = 0, n2 = 0;
            if(i>=0)
            {
               n1 = num1[i] - '0';
               i--;
            }

            if(j>=0)
            {
                n2 = num2[j] - '0';
                j--;
            }

            int sum = n1+n2+carry;
            carry = sum/10;
            result += (sum%10) + '0';
        }
        reverse(result.begin(), result.end());
        return result;
    }
};
```