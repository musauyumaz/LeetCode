


using _2_AddTwoNumbers;

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
ListNode l1 = new (2, new (4, new (3)));
ListNode l2 = new (5, new (6, new (4)));
ListNode l3 = new (9, new (9, new(9, new(9, new(9, new(9, new(9)))))));
ListNode l4 = new (9, new (9, new(9, new(9))));

AddTwoNumbersSolution solution = new();
//Console.WriteLine(solution.AddTwoNumbers(l1,l2));

var data = solution.AddTwoNumbers(l3, l4);

while (data != null)
{
    Console.Write(data.val + " ");
    data = data.next;
}


// 2 4 3
// 5 6 4
// 