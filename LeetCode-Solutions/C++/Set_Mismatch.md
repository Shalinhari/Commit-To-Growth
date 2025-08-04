# Set Mismatch

This is the solution for Set Mismatch

```cpp


class Solution {
public:
    std::vector<int> findErrorNums(std::vector<int>& nums) 
    {
        int n = nums.size();
        vector<int> missNum(n+1, 0);
        int missing = 0, duplicate = 0;

        for(int i =0; i<n;i++)
        {
            missNum[nums[i]]++;
        }

        for(int i = 1; i<missNum.size(); i++)
        {
            if(missNum[i]==2) duplicate = i;
            if(missNum[i]==0) missing = i;
        }
        return {duplicate, missing};
    }
};


```