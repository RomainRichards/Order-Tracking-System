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
    public partial class CustomerPortal : UserControl
    {        
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
        public void FoodName(string input2)
        {
            if (!string.IsNullOrEmpty(txtfoodSelc.Text))
            {
                txtfoodSelc.Clear();
                txtfoodSelc.Text = input2;
            }
            else
            {
                txtfoodSelc.Text = input2;
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
            FoodName("Double Decker");
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

        // Add node to the front of the custom linked list.
        // Confirms each order.
        // Shows totals size of linked list.
        private void btnmemOrder_Click(object sender, EventArgs e)
        {
            var rand = new Random();
            var result = MessageBox.Show($"{txtcusName.Text}, confirm order for {txtfoodSelc.Text} &" +
                $" {txtbevSelc.Text}.", "Order Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                GlobalData.customerlist.AddFirst(txtcusName.Text, txtfoodSelc.Text, txtbevSelc.Text, rand.Next(101, 150));
            }
            RichTextBox nxtOrd = richtxtTotOrd;
            GlobalData.customerlist.ShowOrderSize(nxtOrd);
            clearEntry();
        }

        // Add node to the custom linked list. 
        // Confirms each order.
        // Shows totals size of linked list.
        private void btnnonMemOrd_Click(object sender, EventArgs e)
        {
            var rand = new Random();
            var result = MessageBox.Show($"{txtcusName.Text}, confirm order for {txtfoodSelc.Text} &" +
                $" {txtbevSelc.Text}.", "Order Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                GlobalData.customerlist.AddLast(txtcusName.Text, txtfoodSelc.Text, txtbevSelc.Text, rand.Next(155, 201));

            }
            RichTextBox nxtOrd = richtxtTotOrd;
            GlobalData.customerlist.ShowOrderSize(nxtOrd);
            clearEntry();
        }
        // Clear entry field for customer name, food, beverage.
        private void clearEntry()
        {
            txtcusName.Clear();
            txtfoodSelc.Clear();
            txtbevSelc.Clear();
        }
    }
}
