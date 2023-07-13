using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_Order_Tracking
{
    public class Node
    {
        public int customerID;
        public string customerName;
        public string foodName;
        public string BeverageName;
        public Node next;

        public Node(int cusId, string cusName, string fdName, string bevName, Node n)
        {
            customerID = cusId;
            customerName = cusName;
            foodName = fdName;
            BeverageName = bevName;
            next = n;
        }
        public class QLinkedList
        {
            private Node head;
            private Node tail;
            private int size;

            public QLinkedList()
            {
                head = null;
                tail = null;
                size = 0;
            }

            public int Length()
            {
                return size;
            }
            public bool IsEmpty()
            {
                return size == 0;
            }
            public void addFirst(int cusId, string cusName, string fdName, string bevName)
            {
                Node newest = new Node(cusId, cusName, fdName, bevName, null);
                if (IsEmpty())
                {
                    head = newest;
                    tail = newest;
                }
                else
                {
                    tail.next = newest;
                    tail = newest;
                }
                size++;
            }
            public void addLast(int cusId, string cusName, string fdName, string bevName)
            {
                Node newest = new Node(cusId, cusName, fdName, bevName, null);
                if (IsEmpty())
                    head = newest;
                else
                    tail.next = newest;

                tail = newest;
                size++;
            }
            public void removeFirst()
            {
                if (IsEmpty())
                {
                    MessageBox.Show("The list is empty!");
                }
                else
                {
                    head = head.next;
                }
                size--;
                if (IsEmpty())
                    tail = null;
            }
            public int showCustomerIdFirst()
            {
                return head.customerID;
            }
            public string showCustomerNameFirst()
            {
                return head.customerName;
            }
        }
    }
}
