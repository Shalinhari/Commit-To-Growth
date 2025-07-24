# two Sum

This is the solution to find the most frequent vowel and consonant

```cpp
class Solution {
public:
    int maxFreqSum(string s) 
    {
        unordered_map<char, int> freq;

        for(int i = 0; i<s.size(); i++)
        {
            char c = s[i];
            freq[c]++;
        }

        vector<int> vowels;
        vector<int> constants;
       
        for(int i =0; i< s.size(); i++)
        {
            char b = s[i];
            if(b == 'a' || b == 'e' || b == 'i' || b == 'o' || b == 'u')
            {
                vowels.push_back(freq[b]);
            }
            else
            {
                constants.push_back(freq[b]);
            }
            
        }

        int maxVowel = vowels.empty() ? 0 : *max_element(vowels.begin(), vowels.end());
        int maxConstants = constants.empty() ? 0 : *max_element(constants.begin(), constants.end());
        return maxVowel + maxConstants;

    }
};
```