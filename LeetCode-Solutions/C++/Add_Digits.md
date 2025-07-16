# two Sum

This is the solution for Add Digits

```cpp
class Solution {
public:
    int addDigits(int num) {
        while(num>=10){
            int s=0;
            while(num>0){
            int d=num%10;
            s+=d;
            num/=10;
            }
        num=s;
        }
        return num;
    }
};
```