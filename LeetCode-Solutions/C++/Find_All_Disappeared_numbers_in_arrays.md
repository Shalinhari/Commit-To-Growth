# Find all the disappeared numbers in the arrays

This is the solution to find all the disappeared numbers in the arrays

```cpp
class Solution {
public:
    vector<int> findDisappearedNumbers(vector<int>& nums) {
       unordered_set<int> result(nums.begin(), nums.end());
       int n = nums.size();
       vector<int> ans;
       for( int i = 1; i<=n; i++)
       {
        if(result.find(i)==result.end()){
            ans.push_back(i);
        }
       }
       return ans;
    }

};
```