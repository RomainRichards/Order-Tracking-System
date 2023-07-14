using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Restaurant_Order_Tracking.Node;

namespace Restaurant_Order_Tracking
{
    public partial class CustomerPortal : UserControl
    {
        //GlobalData;


        public CustomerPortal()
        {
            InitializeComponent();

        }






        // Method to input beverage name when selected.
        // Clears textbox if empty then inputs beverage name. 
        public void BeverageName(string input)
        {
            if (!string.IsNullOrEmpty(txtbevSelc.Text))
            {
                txtbevSelc.Clear();
                txtbevSelc.Text = input;
            }
            else
            {
                txtbevSelc.Text = input;
            }
        }

        // Method to input food name when selected.
        // Clears textbox if empty then inputs food name. 
        public void FoodName(string input)
        {
            if (!string.IsNullOrEmpty(txtfoodSelc.Text))
            {
                txtfoodSelc.Clear();
                txtfoodSelc.Text = input;
            }
            else
            {
                txtfoodSelc.Text = input;
            }
        }

        // Food selected gets inputed into food textbox.
        private void btnBaconSup_Click(object sender, EventArgs e)
        {
            FoodName("Bacon Supreme");
        }

        private void btnchicPlate_Click(object sender, EventArgs e)
        {
            FoodName("Chicken Plate");
        }

        private void btnGrilChic_Click(object sender, EventArgs e)
        {
            FoodName("Grill Chicken");
        }

        private void btnFries_Click(object sender, EventArgs e)
        {
            FoodName("Fries");
        }

        private void btnDoubleBeef_Click(object sender, EventArgs e)
        {
            FoodName("Double Decker Beef");
        }
        private void btnsearfoodPizza_Click(object sender, EventArgs e)
        {
            FoodName("Seafood Pizza");
        }

        // Beverage selected gets inputed into beverage textbox.
        private void btnBeer_Click(object sender, EventArgs e)
        {
            BeverageName("Beer");
        }

        private void btnCoke_Click(object sender, EventArgs e)
        {
            BeverageName("Coke Soda");
        }

        private void btnrumPunch_Click(object sender, EventArgs e)
        {
            BeverageName("Rum Punch");
        }

        private void btnMagarita_Click(object sender, EventArgs e)
        {
            BeverageName("Lime Magarita");
        }

        private void btnMojito_Click(object sender, EventArgs e)
        {
            BeverageName("Mojito");
        }

        private void btnIcedTea_Click(object sender, EventArgs e)
        {
            BeverageName("Iced Tea");
        }

        // Add to the queue at the head.
        private void btnmemOrder_Click(object sender, EventArgs e)
        {
            GlobalData.customerlist.addLast(01, txtcusName.Text, txtfoodSelc.Text, txtbevSelc.Text);
            //od.showData();

        }

        // Add to the queue at the tail.
        private void btnnonMemOrd_Click(object sender, EventArgs e)
        {
            GlobalData.customerlist.addFirst(02, txtcusName.Text, txtfoodSelc.Text, txtbevSelc.Text);
            //od.showData();
            //od.richtxttotOrd.Text = sb.Append(qll).ToString();
            
        }
    }
}
