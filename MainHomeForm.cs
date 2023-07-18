using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_Order_Tracking
{
    public partial class MainHomeForm : Form
    {

        public MainHomeForm()
        {
            InitializeComponent();
            pnlSideButtonMarker.Height = btnHome.Height;
            pnlSideButtonMarker.Top = btnHome.Top;
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = GlobalData.customerlist;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            pnlSideButtonMarker.Height = btnHome.Height;
            pnlSideButtonMarker.Top = btnHome.Top;
            customerPortal1.Visible = false;
            orders1.Visible = false;
            DataGridView dataGrid = dataGridView1;
            GlobalData.customerlist.PrintElements(dataGrid);
        }

        private void btnCustomerPortal_Click(object sender, EventArgs e)
        {
            pnlSideButtonMarker.Height = btnCustomerPortal.Height;
            pnlSideButtonMarker.Top = btnCustomerPortal.Top;
            customerPortal1.Visible = true;
            orders1.Visible = false;
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            pnlSideButtonMarker.Height = btnOrders.Height;
            pnlSideButtonMarker.Top = btnOrders.Top;
            orders1.Visible = true;
            customerPortal1.Visible = false;
        }

        private void MainHomeForm_Load(object sender, EventArgs e)
        {
            customerPortal1.Visible = false;
            orders1.Visible = false;
        }
    }
}
