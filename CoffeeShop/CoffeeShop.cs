using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeShop
{
    public partial class CoffeeShop : Form
    {
        public CoffeeShop()
        {
            InitializeComponent();
        }

        string customerName;
        string contactNo ;
        string address;
        string Order ;
        int total;
        int Quantity ;

        private void SaveButton_Click(object sender, EventArgs e)
        {
            customerName = customerNameTextBox.Text;
             contactNo = contactNoTextBox.Text;
             address = AddressTextBox.Text;
             Order = orderNameComboBox.SelectedItem.ToString();
            
            int Quantity = Convert.ToInt32(CoffeeQuantity.Text);
            if (Order == "Black")
            {
                total = 120 * Quantity;
            }
            else if (Order == "Cold")
            {
                total = 100 * Quantity;
            }
            else if (Order == "Hot")
            {
                total = 90 * Quantity;
            }
            else if (Order == "Regular")
            {
                total = 80 * Quantity;
            }
            orderOutput.Text = ("Customer Name: " + customerName + "\n Contact No: " + contactNo + "\n Address: " + address + "\n Order: " + Order + "\n Quantity:" + Quantity + "\n Total Price: " + total).ToString();
        }
            
    }
}
