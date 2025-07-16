# Squares of the sorted arrays

This is the solution for the squares of the sorted arrays

```cpp
class Solution {
public:
    vector<int> sortedSquares(vector<int>& nums) 
    {
     for( int i = 0; i<nums.size();i++)
     { 
        int temp =0;
        temp = nums[i];
        nums[i] = temp * temp;
     }   
     sort(nums.begin(), nums.end());
     return nums;
    }
};
```