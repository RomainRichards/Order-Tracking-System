using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Order_Tracking
{
    internal static class GlobalData
    {
        public static QLinkedList customerlist;

        static GlobalData()
        {
            customerlist = new QLinkedList();
        }

    }
}
