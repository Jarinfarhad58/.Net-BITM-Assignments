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
        int index = 0;
        string [] customerName = new string [5];
        string [] contactNo = new string [5] ;
        string [] address = new string [5];
        string [] Order = new string [5] ;
        int [] total = new int [5];
        int [] Quantity = new int [5] ;

        private void SaveButton_Click(object sender, EventArgs e)
        {
            customerName[index] = customerNameTextBox.Text;
             contactNo[index] = contactNoTextBox.Text;
             address[index] = AddressTextBox.Text;
             Order[index] = orderNameComboBox.SelectedItem.ToString();
             Quantity[index] = Convert.ToInt32(CoffeeQuantity.Text);
            
            string message = " ";
            
            if (Order[index] == "Black")
            {
                total[index] = 120 * Quantity[index];
            }
            else if (Order[index] == "Cold")
            {
                total[index] = 100 * Quantity[index];
            }
            else if (Order[index] == "Hot")
            {
                total[index] = 90 * Quantity[index];
            }
            else if (Order[index] == "Regular")
            {
                total[index] = 80 * Quantity[index];
            }
            index++;
            for (int index = 0; index < customerName.Length; index++)
            {
                if (Quantity[index] !=0)
                    message =message + ("Customer Name: " + customerName[index] + "\n Contact No: " + contactNo[index] + "\n Address: " + address[index] + "\n Order: " + Order[index] + "\n Quantity:" + Quantity[index] + "\n Total Price: " + total[index]+"\n----------------\n").ToString();

            }
        orderOutput.Text = message;    
        }
            
    }
}
