namespace CoffeeShop
{
    partial class CoffeeShop
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.orderOutput = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.customerNameTextBox = new System.Windows.Forms.TextBox();
            this.contactNoTextBox = new System.Windows.Forms.TextBox();
            this.AddressTextBox = new System.Windows.Forms.TextBox();
            this.CoffeeQuantity = new System.Windows.Forms.TextBox();
            this.orderNameComboBox = new System.Windows.Forms.ComboBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // orderOutput
            // 
            this.orderOutput.Location = new System.Drawing.Point(399, 12);
            this.orderOutput.Name = "orderOutput";
            this.orderOutput.Size = new System.Drawing.Size(231, 258);
            this.orderOutput.TabIndex = 0;
            this.orderOutput.Text = "";
           
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Customer Information";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Customer Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Contact No";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Address";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Order";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 212);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Quantity";
            // 
            // customerNameTextBox
            // 
            this.customerNameTextBox.Location = new System.Drawing.Point(152, 66);
            this.customerNameTextBox.Name = "customerNameTextBox";
            this.customerNameTextBox.Size = new System.Drawing.Size(193, 20);
            this.customerNameTextBox.TabIndex = 7;
            // 
            // contactNoTextBox
            // 
            this.contactNoTextBox.Location = new System.Drawing.Point(152, 97);
            this.contactNoTextBox.Name = "contactNoTextBox";
            this.contactNoTextBox.Size = new System.Drawing.Size(193, 20);
            this.contactNoTextBox.TabIndex = 8;
            // 
            // AddressTextBox
            // 
            this.AddressTextBox.Location = new System.Drawing.Point(152, 127);
            this.AddressTextBox.Name = "AddressTextBox";
            this.AddressTextBox.Size = new System.Drawing.Size(193, 20);
            this.AddressTextBox.TabIndex = 9;
            // 
            // CoffeeQuantity
            // 
            this.CoffeeQuantity.Location = new System.Drawing.Point(152, 212);
            this.CoffeeQuantity.Name = "CoffeeQuantity";
            this.CoffeeQuantity.Size = new System.Drawing.Size(193, 20);
            this.CoffeeQuantity.TabIndex = 10;
            // 
            // orderNameComboBox
            // 
            this.orderNameComboBox.FormattingEnabled = true;
            this.orderNameComboBox.Items.AddRange(new object[] {
            "Black",
            "Cold",
            "Hot",
            "Regular"});
            this.orderNameComboBox.Location = new System.Drawing.Point(153, 181);
            this.orderNameComboBox.Name = "orderNameComboBox";
            this.orderNameComboBox.Size = new System.Drawing.Size(192, 21);
            this.orderNameComboBox.TabIndex = 11;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(184, 250);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(109, 27);
            this.SaveButton.TabIndex = 12;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // CoffeeShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 289);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.orderNameComboBox);
            this.Controls.Add(this.CoffeeQuantity);
            this.Controls.Add(this.AddressTextBox);
            this.Controls.Add(this.contactNoTextBox);
            this.Controls.Add(this.customerNameTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.orderOutput);
            this.Name = "CoffeeShop";
            this.Text = "Coffee Shop";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox orderOutput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox customerNameTextBox;
        private System.Windows.Forms.TextBox contactNoTextBox;
        private System.Windows.Forms.TextBox AddressTextBox;
        private System.Windows.Forms.TextBox CoffeeQuantity;
        private System.Windows.Forms.ComboBox orderNameComboBox;
        private System.Windows.Forms.Button SaveButton;
    }
}

