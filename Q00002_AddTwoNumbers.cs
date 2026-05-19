namespace LeetCode
{
    public sealed class Q00002_AddTwoNumbers
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode dummy = new ListNode(0);
            ListNode current = dummy;
            int carry = 0;

            while (l1 != null || l2 != null)
            {
                int x = (l1 != null) ? l1.val : 0;
                int y = (l2 != null) ? l2.val : 0;

                int sum = x + y + carry;
                carry = sum / 10;

                current.next = new ListNode(sum % 10);
                current = current.next;

                if (l1 != null) l1 = l1.next;
                if (l2 != null) l2 = l2.next;
            }


            if (carry > 0)
            {
                current.next = new ListNode(carry);
            }

            return dummy.next;
        }

        public void Test()
        {
            ListNode l1 = new(2, new(4, new(3)));
            ListNode l2 = new(5, new(6, new(4)));
            ListNode l3 = new(9, new(9, new(9, new(9, new(9, new(9, new(9)))))));
            ListNode l4 = new(9, new(9, new(9, new(9))));

            Q00002_AddTwoNumbers solution = new();
            //Console.WriteLine(solution.AddTwoNumbers(l1,l2));

            var data = solution.AddTwoNumbers(l3, l4);

            while (data != null)
            {
                Console.Write(data.val + " ");
                data = data.next;
            }
        }
    }
    public sealed class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
}
