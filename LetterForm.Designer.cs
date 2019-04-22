namespace UPVApp
{
    partial class LetterForm
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
            this.originComboBox = new System.Windows.Forms.ComboBox();
            this.destinationComboBox = new System.Windows.Forms.ComboBox();
            this.fixedCostTextBox = new System.Windows.Forms.TextBox();
            this.oKButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.originLabel = new System.Windows.Forms.Label();
            this.destinationLabel = new System.Windows.Forms.Label();
            this.fixedCostLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // originComboBox
            // 
            this.originComboBox.FormattingEnabled = true;
            this.originComboBox.Location = new System.Drawing.Point(243, 70);
            this.originComboBox.Name = "originComboBox";
            this.originComboBox.Size = new System.Drawing.Size(121, 28);
            this.originComboBox.TabIndex = 0;
            // 
            // destinationComboBox
            // 
            this.destinationComboBox.FormattingEnabled = true;
            this.destinationComboBox.Location = new System.Drawing.Point(243, 146);
            this.destinationComboBox.Name = "destinationComboBox";
            this.destinationComboBox.Size = new System.Drawing.Size(121, 28);
            this.destinationComboBox.TabIndex = 1;
            // 
            // fixedCostTextBox
            // 
            this.fixedCostTextBox.AcceptsReturn = true;
            this.fixedCostTextBox.Location = new System.Drawing.Point(243, 244);
            this.fixedCostTextBox.Name = "fixedCostTextBox";
            this.fixedCostTextBox.Size = new System.Drawing.Size(100, 26);
            this.fixedCostTextBox.TabIndex = 2;
            // 
            // oKButton
            // 
            this.oKButton.Location = new System.Drawing.Point(57, 352);
            this.oKButton.Name = "oKButton";
            this.oKButton.Size = new System.Drawing.Size(92, 40);
            this.oKButton.TabIndex = 3;
            this.oKButton.Text = "OK";
            this.oKButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(280, 352);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(84, 40);
            this.cancelButton.TabIndex = 4;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cancelButton_MouseDown);
            // 
            // originLabel
            // 
            this.originLabel.AutoSize = true;
            this.originLabel.Location = new System.Drawing.Point(65, 78);
            this.originLabel.Name = "originLabel";
            this.originLabel.Size = new System.Drawing.Size(117, 20);
            this.originLabel.TabIndex = 5;
            this.originLabel.Text = "Origin Address:";
            // 
            // destinationLabel
            // 
            this.destinationLabel.AutoSize = true;
            this.destinationLabel.Location = new System.Drawing.Point(70, 149);
            this.destinationLabel.Name = "destinationLabel";
            this.destinationLabel.Size = new System.Drawing.Size(148, 20);
            this.destinationLabel.TabIndex = 6;
            this.destinationLabel.Text = "Destiation Address:";
            // 
            // fixedCostLabel
            // 
            this.fixedCostLabel.AutoSize = true;
            this.fixedCostLabel.Location = new System.Drawing.Point(70, 244);
            this.fixedCostLabel.Name = "fixedCostLabel";
            this.fixedCostLabel.Size = new System.Drawing.Size(88, 20);
            this.fixedCostLabel.TabIndex = 7;
            this.fixedCostLabel.Text = "Fixed Cost:";
            // 
            // LetterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 450);
            this.Controls.Add(this.fixedCostLabel);
            this.Controls.Add(this.destinationLabel);
            this.Controls.Add(this.originLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.oKButton);
            this.Controls.Add(this.fixedCostTextBox);
            this.Controls.Add(this.destinationComboBox);
            this.Controls.Add(this.originComboBox);
            this.Name = "LetterForm";
            this.Text = "LetterForm";
            this.Load += new System.EventHandler(this.LetterForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox originComboBox;
        private System.Windows.Forms.ComboBox destinationComboBox;
        private System.Windows.Forms.TextBox fixedCostTextBox;
        private System.Windows.Forms.Button oKButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label originLabel;
        private System.Windows.Forms.Label destinationLabel;
        private System.Windows.Forms.Label fixedCostLabel;
    }
}