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
    
    public class QLinkedList<T> : IEnumerable<Node<T>>
    {
        public Node<T> head { get; set; }
        public int size { get; set; }

        public int Length()
        {
            return size;
        }
        public bool IsEmpty()
        {
            return size == 0;
        }
        public void ShowOrderSize(RichTextBox sizeinput)
        {
            if (size != 0)
            {
                sizeinput.Text = size.ToString();
            }
            else
                sizeinput.Text = string.Empty;
        }
        public void ShowNextOrder(System.Windows.Forms.TextBox nxtOrd)
        { 
            if(head != null || IsEmpty())
            {
                nxtOrd.Text = ($"Order No :{head.orderNumber}\t   Items : {head.foodName} & {head.beverageName.ToString()}");
            }
            else
                nxtOrd.Text = string.Empty;
        }

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
        public void Clear()
        {
            head = null;
            size = 0;
        }

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
           // dataGridView.DataSource = null;
            dataGridView.DataSource = dataTable;
        }
        public IEnumerator<Node<T>> GetEnumerator()
        {
            Node<T> currentNode = head;
            while (currentNode != null)
            {
                yield return currentNode;
                currentNode = currentNode.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        internal void AddFirst(QLinkedList<string> qLinkedList)
        {
            throw new NotImplementedException();
        }
    }
}
