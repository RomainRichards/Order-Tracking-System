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
            pnlSideButtonMarker.Height = btnHome.Height;
            pnlSideButtonMarker.Top = btnHome.Top;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            pnlSideButtonMarker.Height = btnHome.Height;
            pnlSideButtonMarker.Top = btnHome.Top;
        }

        private void btnCustomerPortal_Click(object sender, EventArgs e)
        {
            pnlSideButtonMarker.Height = btnCustomerPortal.Height;
            pnlSideButtonMarker.Top = btnCustomerPortal.Top;
            customerPortal1.BringToFront();
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            pnlSideButtonMarker.Height = btnOrders.Height;
            pnlSideButtonMarker.Top = btnOrders.Top;
            orders1.BringToFront();
        }
    }
}
