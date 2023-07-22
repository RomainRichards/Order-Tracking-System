using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Restaurant_Order_Tracking
{
    /// <summary>
    /// Queue implemented using a custom Linked List.
    /// Implement a Custom Linked List and IEnumerable Interface Members.  
    /// </summary>
    public class QLinkedList<T> : IEnumerable<Node<T>>
    {
        // head represent the first node in the linked list and size represents the number of nodes in the linked list.
        public Node<T> head { get; set; }
        public int size { get; set; }

        // Method to get the size of the linked list. 
        public int Length()
        {
            return size;
        }

        // Method to check if linked list is empty. 
        public bool IsEmpty()
        {
            return size == 0;
        }

        // Method to show linked list size, takes the input of a richtextbox to display on any user control. 
        public void ShowOrderSize(RichTextBox sizeinput)
        {
            if (size != 0)
            {
                sizeinput.Text = size.ToString();
            }
            else
                sizeinput.Text = string.Empty;
        }

        // Method to show the order that is next (head), takes the input of a textbox to display on any user control. 
        public void ShowNextOrder(System.Windows.Forms.TextBox nxtOrd)
        { 
            if(head != null || IsEmpty())
            {
                nxtOrd.Text = ($"Order No :{head.orderNumber}  Items : {head.foodName} & {head.beverageName.ToString()}");
            }
            else
                nxtOrd.Text = "\t\tOrders Complete";
        }

        // Method to add to the front of the linked list (head).
        public void AddFirst(Node<T> nodeToAdd)
        {
            if (head == null)
            {
                head = nodeToAdd;
            }
            else
            {
                nodeToAdd.Next = head;
                head.Prev = nodeToAdd;

                head = nodeToAdd;
            }
            size++;
        }
        public void AddFirst( string cusName, string fdName, string bevName, int ordNum)
        {
            var node = new Node<T>( cusName, fdName, bevName, ordNum);
            AddFirst(node);
        }

        // Method to add to the end of the linked list. // ENQUEUE
        public void AddLast(Node<T> nodeToAdd)
        {
            var lastNode = GetLastNode();

            if(lastNode != null)
            {
                lastNode.Next = nodeToAdd;
                nodeToAdd.Prev = lastNode;

                size++;

                return;
            }
            AddFirst(nodeToAdd);
        }
        public void AddLast(string cusName, string fdName, string bevName, int ordNum)
        {
            var node = new Node<T>(cusName, fdName, bevName, ordNum);
            AddLast(node);
        }

        // Method to remove the first node in the linked list. // DEQUEUE    
        public void RemoveFirst()
        {
            if(head == null)
            {
                return;
            }

            var next = head.Next;

            if(next != null)
            {
                next.Prev = null;
                head = next;

                return;
            }
            head = null;
        }

        // Method to remove the last node in the linked list.
        public void RemoveLast()
        {
            var lastNode = GetLastNode();

            if(lastNode != null)
            {
                var prev = lastNode.Prev;
                if(prev != null)
                {
                    prev.Next = null;
                }
                lastNode.Prev = null;

                size--;
            }
            RemoveFirst();
        }

        // Method to cleach the entire linked list.
        public void Clear()
        {
            head = null;
            size = 0;
        }

        // Method used to get last node in the linked list.
        public Node<T> GetLastNode()
        {
            if (head == null)
            {
                return default;
            }

            var aux = head;

            while (aux != null)
            {
                if (aux.Next is null)
                {
                    return aux;
                }

                aux = aux.Next;
            }

            return default;
        }

        // Method to display elements in the linked list. 
        // Attach the linked list to a data table.
        // Set the datasource for the datagridview = to the data table containing the linked list.
        // Takes input of dataGridView to be used on any user control.
        public void PrintElements(DataGridView dataGridView)
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Customer", typeof(string));
            dataTable.Columns.Add("Food", typeof(string));
            dataTable.Columns.Add("Beverage", typeof(string));
            dataTable.Columns.Add("Order N0.", typeof(int));

            foreach (var item in GlobalData.customerlist)
            {
                dataTable.Rows.Add(item.customerName, item.foodName, item.beverageName, item.orderNumber);
            }
            dataGridView.DataSource = dataTable;
        }

        // Implementation of IEnumberable<T> interface, enumerate objects of the class using the for each loop.
        // Used to traverse through the elements of the linked list. 
        // Iterate through all the nodes in the linked list until it reaches the end, null.
        // Yield keyword is used to return one value at a time. // ITERATE
        public IEnumerator<Node<T>> GetEnumerator()
        {
            Node<T> currentNode = head;
            while (currentNode != null)
            {
                yield return currentNode;
                currentNode = currentNode.Next;
            }
        }

        // Non-generic version of the 'GetEnumerator' method. 
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
