# two Sum

This is the solution for removing duplicates from the sorted array

```cpp
/**
 * Definition for singly-linked list.
 * struct ListNode {
 *     int val;
 *     ListNode *next;
 *     ListNode() : val(0), next(nullptr) {}
 *     ListNode(int x) : val(x), next(nullptr) {}
 *     ListNode(int x, ListNode *next) : val(x), next(next) {}
 * };
 */
class Solution {
public:
    ListNode* deleteDuplicates(ListNode* head)
     {
        if( head == NULL || head-> next == NULL)
        return head;

        ListNode* current = head;

        while( current != NULL && current-> next != NULL)
        {
            if(current->val == current->next->val)
            {
            current->next = current->next->next;
            }
            else
            {
            current = current->next;
            }
        }

        return head;
    }
};
```