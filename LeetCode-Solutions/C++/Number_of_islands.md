# Number of Islands

This is the solution for number of Island using BFS

```cpp
class Solution {
public:
    int numIslands(vector<vector<char>>& grid) {
        if(grid.empty() || grid[0].empty()) 
        return 0;

        int count = 0;

        for(int i =0; i<grid.size();i++)
        {
            for(int j=0;j<grid[0].size(); j++)
            {
             if(grid[i][j]=='1')
             {
                dfs(grid,i,j);
                count++;
             }
            }
        }
        return count;
    }


    private:
     void dfs(vector<vector<char>>& grid, int i, int j)
    {
        if( i<0 || j<0 || i >= grid.size() || j>= grid[0].size() || grid[i][j]=='0')
        return ;
      
       // Marking this element as visited 
        grid[i][j]='0';

       // exploring all the possibilities 
       dfs(grid, i+1,j);
       dfs(grid, i-1,j);
       dfs(grid, i,j+1);
       dfs(grid, i,j-1);         

    }
};
```