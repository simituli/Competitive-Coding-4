/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */

public class Solution {
    public bool IsPalindrome(ListNode head) {
        if(head==null || head.next==null) return true;
        
        ListNode slow = head;
        ListNode fast = head;
        while(fast.next!=null && fast.next.next!=null)
        {
            slow=slow.next;
            fast = fast.next.next;
        }
        //slow is at the middle
        //split it.
       
        ListNode head2 = reverse(slow.next);//1->2->3->1->2
        slow.next = null;
        bool result= isIdentical(head, head2);
        slow.next=reverse(head2);
        return result;
    }
    private bool isIdentical(ListNode n1, ListNode n2)
    {   
        while(n1!=null && n2!=null)
        {
            if(n1.val!=n2.val) return false;
            n1=n1.next;
            n2=n2.next;
        }
        return true;
    }
    private ListNode reverse(ListNode root)
    {
        ListNode prev = null;
        ListNode curr = root;
        while(curr!=null)
        {
            ListNode temp = curr.next;
            curr.next = prev;
            prev=curr;
            curr =temp;
        }
        return prev;
    }
    
}
