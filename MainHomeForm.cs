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
        /// <summary>
        /// Sets the side panel tab to have the same hight as the home button and top. 
        /// </summary>
        public MainHomeForm()
        {
            InitializeComponent();
            pnlSideButtonMarker.Height = btnHome.Height;
            pnlSideButtonMarker.Top = btnHome.Top;
        }

        /// <summary>
        /// Sets the side panel tab to have the same hight as the home, customer portal 
        /// and orders button button and  their top. 
        /// Bring to front the specific panel corresponding to the button clicked. 
        /// </summary>
        private void btnHome_Click(object sender, EventArgs e)
        {
            pnlSideButtonMarker.Height = btnHome.Height;
            pnlSideButtonMarker.Top = btnHome.Top;
            home1.BringToFront();
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

        // Loads the home page panel when form loads. 
        private void MainHomeForm_Load(object sender, EventArgs e)
        {
            home1.BringToFront();
        }

        // Closes application.
        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Displays CLOSE when hovering over the close application button.
        private void lblcloseApp_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(this.lblcloseApp, "CLOSE");
        }
    }
}
