using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_Order_Tracking
{
    public partial class Orders : UserControl
    {
        public Orders()
        {
            InitializeComponent();
            // Sets the data source for the orders grid to the custom globaldata list. 
            dataGVOrders.DataSource = GlobalData.customerlist;
        }

        /// <summary>
        /// Implemented the RemoveFirst method. This simulates the FIFO. 
        /// Implement the ShowNextOrder method. This prints the next order to the text box. 
        /// Shows messagage if there are no orders to show next.
        /// Updates data gridview when node is removed. 
        /// </summary>
        private void btnserveOrd_Click(object sender, EventArgs e)
        {
            if (GlobalData.customerlist.Length() >= 1)
            {
                GlobalData.customerlist.RemoveFirst();

                TextBox showOrd = txtbxNextCust;
                GlobalData.customerlist.ShowNextOrder(showOrd);
            }
            else if (GlobalData.customerlist.IsEmpty())
            {
                MessageBox.Show("No orders found.");
            }
            DataGridView totOrd = dataGVOrders;
            GlobalData.customerlist.PrintElements(totOrd);
        }
        /// <summary>
        /// Displays all nodes in the custom linked list to the dataGridView. 
        /// Shows the first order to be served.
        /// </summary>
        private void btntotOrd_Click(object sender, EventArgs e)
        {
            DataGridView totOrd = dataGVOrders;
            GlobalData.customerlist.PrintElements(totOrd);

            TextBox showOrd = txtbxNextCust;
            GlobalData.customerlist.ShowNextOrder(showOrd);
        }
    }


}
