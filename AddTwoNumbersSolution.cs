using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions.LeetCodeProblems
{
    public class AddTwoNumbersSolution
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode dummy = new ListNode(0);
            ListNode l3 = dummy;

            int carry = 0;

            while (l1 != null || l2 != null)
            {
                int val_l1 = l1 == null ? 0 : l1.val;
                int val_l2 = l2 == null ? 0 : l2.val;

                int sum = val_l1 + val_l2 + carry;

                carry = sum / 10;
                int LastDigit = sum % 10;

                ListNode newNode = new ListNode(LastDigit);
                l3.next = newNode;

                if (l1 != null) l1 = l1.next;
                if (l2 != null) l2 = l2.next;
                l3 = l3.next;

            }

            if (carry > 0)
            {
                ListNode newNode = new ListNode(carry);
                l3.next = newNode;
                l3 = l3.next;
            }

            return dummy.next;
        }
    }
}
