namespace UPVApp
{
    partial class AddressForm
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
            this.nameLabel = new System.Windows.Forms.Label();
            this.addressoneLabel = new System.Windows.Forms.Label();
            this.addresstwoLabel = new System.Windows.Forms.Label();
            this.cityLabel = new System.Windows.Forms.Label();
            this.stateLabel = new System.Windows.Forms.Label();
            this.zipcodeLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.nameTextbox = new System.Windows.Forms.TextBox();
            this.addressOneTextbox = new System.Windows.Forms.TextBox();
            this.addressTwotextbox = new System.Windows.Forms.TextBox();
            this.cityTextbox = new System.Windows.Forms.TextBox();
            this.zipcodeTextBox = new System.Windows.Forms.TextBox();
            this.stateComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.Location = new System.Drawing.Point(78, 43);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(100, 23);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Name:";
            // 
            // addressoneLabel
            // 
            this.addressoneLabel.Location = new System.Drawing.Point(78, 106);
            this.addressoneLabel.Name = "addressoneLabel";
            this.addressoneLabel.Size = new System.Drawing.Size(100, 23);
            this.addressoneLabel.TabIndex = 1;
            this.addressoneLabel.Text = "Address1:";
            // 
            // addresstwoLabel
            // 
            this.addresstwoLabel.Location = new System.Drawing.Point(78, 168);
            this.addresstwoLabel.Name = "addresstwoLabel";
            this.addresstwoLabel.Size = new System.Drawing.Size(100, 23);
            this.addresstwoLabel.TabIndex = 2;
            this.addresstwoLabel.Text = "Addess2:";
            // 
            // cityLabel
            // 
            this.cityLabel.Location = new System.Drawing.Point(78, 237);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(100, 23);
            this.cityLabel.TabIndex = 3;
            this.cityLabel.Text = "City:";
            // 
            // stateLabel
            // 
            this.stateLabel.Location = new System.Drawing.Point(78, 297);
            this.stateLabel.Name = "stateLabel";
            this.stateLabel.Size = new System.Drawing.Size(100, 23);
            this.stateLabel.TabIndex = 4;
            this.stateLabel.Text = "State:";
            // 
            // zipcodeLabel
            // 
            this.zipcodeLabel.Location = new System.Drawing.Point(78, 365);
            this.zipcodeLabel.Name = "zipcodeLabel";
            this.zipcodeLabel.Size = new System.Drawing.Size(100, 23);
            this.zipcodeLabel.TabIndex = 5;
            this.zipcodeLabel.Text = "ZipCode:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(482, 300);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "label8";
            // 
            // nameTextbox
            // 
            this.nameTextbox.Location = new System.Drawing.Point(267, 40);
            this.nameTextbox.Name = "nameTextbox";
            this.nameTextbox.Size = new System.Drawing.Size(116, 26);
            this.nameTextbox.TabIndex = 8;
            // 
            // addressOneTextbox
            // 
            this.addressOneTextbox.Location = new System.Drawing.Point(267, 103);
            this.addressOneTextbox.Name = "addressOneTextbox";
            this.addressOneTextbox.Size = new System.Drawing.Size(116, 26);
            this.addressOneTextbox.TabIndex = 9;
            // 
            // addressTwotextbox
            // 
            this.addressTwotextbox.Location = new System.Drawing.Point(267, 165);
            this.addressTwotextbox.Name = "addressTwotextbox";
            this.addressTwotextbox.Size = new System.Drawing.Size(116, 26);
            this.addressTwotextbox.TabIndex = 10;
            // 
            // cityTextbox
            // 
            this.cityTextbox.Location = new System.Drawing.Point(267, 234);
            this.cityTextbox.Name = "cityTextbox";
            this.cityTextbox.Size = new System.Drawing.Size(116, 26);
            this.cityTextbox.TabIndex = 11;
            // 
            // zipcodeTextBox
            // 
            this.zipcodeTextBox.Location = new System.Drawing.Point(267, 365);
            this.zipcodeTextBox.Name = "zipcodeTextBox";
            this.zipcodeTextBox.Size = new System.Drawing.Size(116, 26);
            this.zipcodeTextBox.TabIndex = 13;
            this.zipcodeTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.zipcodeTextBox_Validating);
            // 
            // stateComboBox
            // 
            this.stateComboBox.FormattingEnabled = true;
            this.stateComboBox.Location = new System.Drawing.Point(267, 292);
            this.stateComboBox.Name = "stateComboBox";
            this.stateComboBox.Size = new System.Drawing.Size(116, 28);
            this.stateComboBox.TabIndex = 14;
            this.stateComboBox.Validating += new System.ComponentModel.CancelEventHandler(this.stateComboBox_Validating);
            // 
            // AddressForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 450);
            this.Controls.Add(this.stateComboBox);
            this.Controls.Add(this.zipcodeTextBox);
            this.Controls.Add(this.cityTextbox);
            this.Controls.Add(this.addressTwotextbox);
            this.Controls.Add(this.addressOneTextbox);
            this.Controls.Add(this.nameTextbox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.zipcodeLabel);
            this.Controls.Add(this.stateLabel);
            this.Controls.Add(this.cityLabel);
            this.Controls.Add(this.addresstwoLabel);
            this.Controls.Add(this.addressoneLabel);
            this.Controls.Add(this.nameLabel);
            this.Name = "AddressForm";
            this.Text = "AddressForm";
            this.Load += new System.EventHandler(this.AddressForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label addressoneLabel;
        private System.Windows.Forms.Label addresstwoLabel;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.Label stateLabel;
        private System.Windows.Forms.Label zipcodeLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox nameTextbox;
        private System.Windows.Forms.TextBox addressOneTextbox;
        private System.Windows.Forms.TextBox addressTwotextbox;
        private System.Windows.Forms.TextBox cityTextbox;
        private System.Windows.Forms.TextBox zipcodeTextBox;
        private System.Windows.Forms.ComboBox stateComboBox;
    }
}