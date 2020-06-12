using System;

namespace HW1
{
    public class LinkedList
    {

        public static void Main(string[] args)
        {
            Console.ReadLine();
        }

        public Node head;

        public class Node
        {
            public int data;
            public Node next;
        }

        public bool IsEmpty()
        {
            return head == null;
        }

        public void AddToTail(int i)
        {
            Node node = new Node();
            node.data = i;
            if (IsEmpty())
                head = node;
            else
            {
                Node ptr = head;
                while (ptr.next != null)
                    ptr = ptr.next;
                ptr.next = node;
            }
        }

        public int Length()
        {
            Node ptr = head;
            int count = 0;

            if (IsEmpty())
                return 0;

            while (ptr != null)
            {
                ptr = ptr.next;
                count++;
            }

            return count;
        }

        public int Find(int i)
        {
            Node cycle = head;

            for (int index = 0; index < Length(); index++)
            {
                if (cycle.data == i)
                    return index;
            }

            return -1;
        }
    }
}
