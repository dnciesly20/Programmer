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
    public partial class AddressForm : Form
    {
        //The GUI is ready to be shown
        public AddressForm()
        {
            InitializeComponent();

            //Examples of possible test data
            List<string> states = new List<string> { "TN", "WY", "OH", "FL" };
            foreach (string statename in states)
                stateComboBox.Items.Add(statename);
                
        }
 
        //Get property that returns the name text
       internal  string AddressName
        { 
            get
            {
                return nameTextbox.Text;
            }
            
            //The text of the name field is set to a certain value
            set
            {
                nameTextbox.Text = value;
            }
        }

        //Get property that returns the address text
       internal string Address1
        {
            get
            {
                return addressOneTextbox.Text;
            }
            
            //The text of the address one field is set to a certain value
            set
            {
                addressOneTextbox.Text = value;
            }
        }
        //Get property that returns the address text
        internal string Address2
        {
            get
            {
                return addressTwotextbox.Text;
            }
            //The text of the address two field is set to a certain value
            set
            {
                addressTwotextbox.Text = value;
            }
        }
        //Get property that returns the city text
       internal string City
        {
            get
            {
                return cityTextbox.Text;
            }
            //The text of the city field is set to a certain value
            set
            {
                cityTextbox.Text = value;
            }
        }
        //Get property that returns the state text
       internal string State
        {
            get
            {
                //If state that will return a certain value as long as a correct state is entered
                if (stateComboBox.SelectedIndex != -1)
                    return stateComboBox.ToString();
                else
                    return "Blank Value";
            }
            //The text of  the state field is set to a certain value
            set
            {
                stateComboBox.Text = value;
            }
        }
        //Get property that returns the zipcode text
        internal string ZipCode
        {
            get
            {
                return zipcodeTextBox.Text;
            }

            //The text of  the zip code is set to a certain value
            set
            {
                zipcodeTextBox.Text = value;
            }
        }

        private void AddressForm_Load(object sender, EventArgs e)
        {

        }
 

        private void stateComboBox_Validating(object sender, CancelEventArgs e)
        {
            //This is a validating event created for the state combo box
            if (stateComboBox.SelectedIndex == -1)
            {
                e.Cancel = true;
               
            }   
        }

        private void zipcodeTextBox_Validating(object sender, CancelEventArgs e)
        {
            //The zipcode number
            int zipnumber;

            //This is when the parse amount fails
            if (!int.TryParse(zipcodeTextBox.Text, out zipnumber)

                //This shows an invalid field that has been created
                || (zipnumber < 0) || (zipnumber > Address.MAX_ZIP))
            {
                e.Cancel = true;
                zipcodeTextBox.SelectAll();
                
            }
        }
    }
}
