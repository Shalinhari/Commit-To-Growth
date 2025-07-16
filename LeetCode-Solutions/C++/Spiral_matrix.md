# Spiral Matrix

This is the solution for spiral Matrix

```cpp
class Solution {
public:
    vector<int> spiralOrder(vector<vector<int>>& matrix) {
        int rowbegin =0;
        int rowend = matrix.size()-1;
        int colbegin = 0;
        int colend = matrix[0].size()-1;
        vector<int> result;

        if(matrix.size()==0)
        return result;

        while(rowbegin <= rowend && colbegin <= colend)
        {
          // Towards right Direction
          for( int i= colbegin ; i<=colend; i++)
           result.push_back(matrix[rowbegin][i]);
           rowbegin++;

           // Towards down direction
           for( int i = rowbegin ; i<=rowend; i++)
           result.push_back(matrix[i][colend]);
           colend--;
           
           // Towards left direction
           if(rowbegin<=rowend){
           for( int i = colend; i>=colbegin; i--)
           result.push_back(matrix[rowend][i]);
           rowend--;
           }

           // Towards up direction
           if(colbegin <= colend){
           for(int i = rowend; i>=rowbegin; i--)
           result.push_back(matrix[i][colbegin]);
           colbegin++;
           }
        }
        return result;
    }
};
```