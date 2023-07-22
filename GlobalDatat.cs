using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Restaurant_Order_Tracking
{
    /// <summary>
    /// Global custom static object to hold the linked list data in a central place. 
    /// </summary>
    internal static class GlobalData
    {
        public static QLinkedList<string> customerlist;

        static GlobalData()
        {
            customerlist = new QLinkedList<string>();
        }
    }
}
