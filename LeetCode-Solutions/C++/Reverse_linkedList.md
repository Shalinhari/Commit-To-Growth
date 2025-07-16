# two Sum

This is the solution for reverse linked List

```cpp
class Solution {
public:
    ListNode* reverseList(ListNode* head) {
        ListNode* prev = nullptr;
        ListNode* curr = head;
        while (curr != nullptr) {
            ListNode* temp = curr->next; 
            curr->next = prev;            
            prev = curr;                  
            curr = temp;                 
        }
        return prev; 
    }
};
```