/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
            /** : Problem :  find where two ssl intersect
         *   
         *   
         *  : Constraints : 
         *   cant change their structure
         *  1 - 10^9
         *  : Assumptions :
         *   no cycles 
         *   
         *  : Inputs :
         *   Listnode head A / head bf
         *    
         *  : Outputs :
         *  Llistnode intersect
         *    
         *  : Tests : easy :
         *     
         *          
         *  Data Structures :
         *  list
         *                  
         *  Algorithm Design :
         *          
         *  Time : O(n)
         *  Space : O(1)
        */
    public ListNode GetIntersectionNode(ListNode headA, ListNode headB) {
        Dictionary<ListNode,int> nodes_in_B = new Dictionary<ListNode,int>();
        
        int value = 0;
        while (headB != null){
            nodes_in_B.Add(headB, value);
            headB = headB.next;
            value++;
        }
        
        //collected all nodes in list b
        
        while (headA != null){
            //if we find the same heads.. done
            if(nodes_in_B.ContainsKey(headA)){
                return headA;
            }
            headA = headA.next;
        }
        return null;
    }
}
