using System;
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
            pnlsideBar.Height = btnHome.Height;
            pnlsideBar.Top = btnHome.Top;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            pnlsideBar.Height = btnHome.Height;
            pnlsideBar.Top = btnHome.Top;
        }

        private void btnCustomerPortal_Click(object sender, EventArgs e)
        {
            pnlsideBar.Height = btnCustomerPortal.Height;
            pnlsideBar.Top = btnCustomerPortal.Top;
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            pnlsideBar.Height = btnOrders.Height;
            pnlsideBar.Top = btnOrders.Top;
        }
    }
}
