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
    public partial class LetterForm : Form
    {
        protected List<Address> addressList;

        //A constant that shows the minimum number of addresses that we need
        public const int MINIMUM_ADDRESSES = 4;

        //The letter form provides connects the method list and the address class
        public LetterForm(List<Address> addresses)
        {

            InitializeComponent();
            addressList = addresses;
        }

        int TheOrginAddressIndex
        {
            //Get property is created
            get
            {
                return originComboBox.SelectedIndex;
            }

            set
            {
                //If a value is entered and itis less than he address count, it will be displayed in the combobox
                if ((value >= -1) && (value < addressList.Count))
                    originComboBox.SelectedIndex = value;
                else
                    //Throws an exception if there isn't a valid value entered
                    throw new ArgumentOutOfRangeException("There has to be a valid value entered");
            }

        }

          int TheDestinationAddressIndex
        {
            //Get property is created
            get
            {
                return destinationComboBox.SelectedIndex;
            }

            set
            {
                //If a value is entered and itis less than he address count, it will be displayed in the combobox
                if ((value >= -1) && (value < addressList.Count))
                    destinationComboBox.SelectedIndex = value;
                else
                    //Throws an exception if there isn't a valid value entered
                    throw new ArgumentOutOfRangeException("There has to be a valid value entered");
            }
        }

        //This repesents the fixed cost for the letters
       internal string FixedCostText
        {

            get
            {
                return fixedCostTextBox.Text;
            }

            set
            {
                fixedCostTextBox.Text = value;
            }

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void LetterForm_Load(object sender, EventArgs e)
        {
            // This counts the amount of addresses we have and it lets us know if we need more addresses to complete the letter
            if (addressList.Count < MINIMUM_ADDRESSES)
            {
                //This message box populates if we have an error
                MessageBox.Show("There is an error with the addresses and it is needed to create the letter");
            }
            else
            {
                // This a foreach loop that displays a condition for what each address does
                foreach (Address a in addressList)
                {
                   originComboBox.Items.Add(a.Name);
                    destinationComboBox.Items.Add(a.Name);
                }
            }
        }
        //The cancel button can be clicked to close out the file
        private void cancelButton_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                this.DialogResult = DialogResult.Cancel;
        }
    }
}
