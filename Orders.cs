using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
            showData();
            richtxttotOrd.Text = GlobalData.customerlist.ToString();
        }
        public void showData()
        {
            
        }

    }
}
