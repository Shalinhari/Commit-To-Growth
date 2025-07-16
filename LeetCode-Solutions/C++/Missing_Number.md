# Missing Number

This is the solution for checking the missing number in the given list.

```cpp
class Solution {
public:
    int missingNumber(vector<int>& nums) {
      sort(nums.begin(), nums.end());
       int n = nums.size();
       int temp = nums[0];
       if(nums[n-1]!= n) return n;
     for (int i =1; i<=nums.size(); i++)
     {
        if(temp != nums[i-1])
            return temp;
            temp++;       
     }
     return 0;
    }
};