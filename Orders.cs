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
           // dataGridView1.DataSource = null;
            dataGridView1.DataSource = GlobalData.customerlist;
            DataGridView dataGrid = dataGridView1;
            GlobalData.customerlist.PrintElements(dataGrid);
            richtxtnextOrd.Text = GlobalData.customerlist.Length().ToString();
        }

        private void Orders_Load(object sender, EventArgs e)
        {
            
        }

        private void btnMkOrd_Click(object sender, EventArgs e)
        {
            DataGridView dataGrid = dataGridView1;
            GlobalData.customerlist.PrintElements(dataGrid);
            richtxtnextOrd.Text = GlobalData.customerlist.Length().ToString();
        }
    }


}
