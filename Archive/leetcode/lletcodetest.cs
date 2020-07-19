using System;
using System.IO;
using Xunit;
using System.Collections.Generic;

namespace leetcode
{
    public class LeetCodeTests
    {
        [Fact]
        public void test()
        {
            var node1 = new ListNode(4);
            var node2 = new ListNode(5);
            var node3 = new ListNode(1);
            var node4 = new ListNode(9);

            node1.next = node2;
            node2.next = node3;
            node3.next = node4;

            Assert.Equal(1, node3.val);
            Assert.Equal(node4, node3.next);

            var s = new Solution();
            s.DeleteNode(node3);

            Assert.Equal(9, node3.val);
            Assert.Null(node3.next);
        }

        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x) { val = x; }
        }

        public class Solution
        {
            public void DeleteNode(ListNode node)
            {
                node.val = node.next.val;
                node.next = node.next.next;
            }
        }


    }
}



