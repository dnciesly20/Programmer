namespace UPVApp
{
    partial class NewAddressForm
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
            this.cancelButton = new System.Windows.Forms.Button();
            this.oKButton = new System.Windows.Forms.Button();
            this.returnAddressComboBox = new System.Windows.Forms.ComboBox();
            this.editAddressLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(411, 294);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(133, 53);
            this.cancelButton.TabIndex = 0;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // oKButton
            // 
            this.oKButton.Location = new System.Drawing.Point(82, 294);
            this.oKButton.Name = "oKButton";
            this.oKButton.Size = new System.Drawing.Size(149, 53);
            this.oKButton.TabIndex = 1;
            this.oKButton.Text = "Ok";
            this.oKButton.UseVisualStyleBackColor = true;
            this.oKButton.Click += new System.EventHandler(this.oKButton_Click);
            // 
            // returnAddressComboBox
            // 
            this.returnAddressComboBox.FormattingEnabled = true;
            this.returnAddressComboBox.Location = new System.Drawing.Point(147, 128);
            this.returnAddressComboBox.Name = "returnAddressComboBox";
            this.returnAddressComboBox.Size = new System.Drawing.Size(333, 28);
            this.returnAddressComboBox.TabIndex = 2;
            // 
            // editAddressLabel
            // 
            this.editAddressLabel.Location = new System.Drawing.Point(178, 75);
            this.editAddressLabel.Name = "editAddressLabel";
            this.editAddressLabel.Size = new System.Drawing.Size(413, 36);
            this.editAddressLabel.TabIndex = 3;
            this.editAddressLabel.Text = "Choose Address from LIst Below:";
            // 
            // NewAddressForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 415);
            this.Controls.Add(this.editAddressLabel);
            this.Controls.Add(this.returnAddressComboBox);
            this.Controls.Add(this.oKButton);
            this.Controls.Add(this.cancelButton);
            this.Name = "NewAddressForm";
            this.Text = "NewAddressForm";
            this.Load += new System.EventHandler(this.NewAddressForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button oKButton;
        private System.Windows.Forms.ComboBox returnAddressComboBox;
        private System.Windows.Forms.Label editAddressLabel;
    }
}