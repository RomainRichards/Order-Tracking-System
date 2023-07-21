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
            dataGVOrders.DataSource = GlobalData.customerlist;
        }

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
        private void btntotOrd_Click(object sender, EventArgs e)
        {
            DataGridView totOrd = dataGVOrders;
            GlobalData.customerlist.PrintElements(totOrd);
        }
    }


}
