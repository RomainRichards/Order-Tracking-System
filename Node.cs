using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_Order_Tracking
{
    /// <summary>
    /// Node<T> class with different public properties we want to store in the node. 
    /// Next property represents the next node from the custom linked list.
    /// Prev represents the previous node.
    /// </summary>
    public class Node<T>
    {
        public string customerName { get; set; }
        public string foodName { get; set; }
        public string beverageName { get; set; }
        public int orderNumber { get; set; }
        public Node<T> Next { get; set; }
        public Node<T> Prev { get; set; }
        
        public Node(string cusName, string fdName, string bevName, int ordNum)
        {
            customerName = cusName;
            foodName = fdName;
            beverageName = bevName;
            orderNumber = ordNum;
        }
    }  
}
