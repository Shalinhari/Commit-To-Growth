# Score Validator

This is the solution for Score Validator

```cpp
class Solution {
public:
    vector<int> scoreValidator(vector<string>& events) {

        int score = 0, counter = 0;

        for (string &e : events) {

            if (e == "W") {
                counter++;

                if (counter == 10)
                    break;
            }
            else if (e == "WD" || e == "NB") {
                score++;
            }
            else {
                score += stoi(e);
            }
        }

        return {score, counter};
    }
};    
```