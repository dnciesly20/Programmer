using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UPVApp
{
    public partial class NewAddressForm : Form
    {
        //The full addresses that will be used in the combo box
        private List<Address> listofAddresses;

        //This display the New Address form we created
        public NewAddressForm(List<Address> allAddresses)
        {
            InitializeComponent();
            allAddresses = listofAddresses;
        }

        //The user is selcted an address from the combo box established on the form
        public int ChosenAddress
        {
            // Get and Set Prpoerty returning a value chosen in the combo box
            get
            {
                //Return an address that is chosen
                return returnAddressComboBox.SelectedIndex;
            }

            set
            {
                // If a value is chosen, then return an address
                if ((value >= 0) && (value < listofAddresses.Count))
                    returnAddressComboBox.SelectedIndex = value;
                //If a value isnt chosen and left empty, then an exception should be thrown
                else throw new ArgumentOutOfRangeException("There is an error with the index");
            }
        }

        //The user clisks the ok button to accept the value chosen on the form
        private void oKButton_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
                this.DialogResult = DialogResult.OK;
        }
        //User clicks the cancel button to cancel the or leave the form
        private void cancelButton_Click(object sender, EventArgs e)
        {
            
                this.DialogResult = DialogResult.Cancel;
        }

        private void NewAddressForm_Load(object sender, EventArgs e)
        {
            // This populates how many addresses are in the address combo box
            foreach (Address a in listofAddresses)
            {
                //Return address value
                returnAddressComboBox.Items.Add(a.Name);
            }
        }
    }
}
