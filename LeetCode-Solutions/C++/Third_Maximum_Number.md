# two Sum

This is the solution for third maximum number

```cpp
class Solution {
public:
    int thirdMax(vector<int>& nums) {
        sort(nums.begin() , nums.end());
        int count  = 1;
        int max = nums[ nums.size() - 1];
        for( int i = nums.size() - 2;  i >= 0 ;i--){
            if( nums[i] != nums[i+1]){
                count++; }

            if( count == 3){
                int ans = nums[i];
                return ans;
            } 
        }
        return max;
        }
};
```