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
    public partial class Prog2Form : Form
    {
        protected UserParcelView upv;

        public Prog2Form()
        {
            InitializeComponent();

            upv = new UserParcelView();

            upv.AddAddress("  John Smith  ", "   123 Any St.   ", "  Apt. 45 ",
               "  Louisville   ", "  KY   ", 40202); // Test Address 1
            upv.AddAddress("Jane Doe", "987 Main St.",
                 "Beverly Hills", "CA", 90210); // Test Address 2
            upv.AddAddress("James Kirk", "654 Roddenberry Way", "Suite 321",
                "El Paso", "TX", 79901); // Test Address 3
            upv.AddAddress("John Crichton", "678 Pau Place", "Apt. 7",
                 "Portland", "ME", 04101); // Test Address 4
            upv.AddAddress("Michael Joseph", "424 bradley Place", "Suite 534",
                "New York", "NY", 25958); // Test Address 5
            upv.AddAddress("Bradley Pitt", "479 Valley Station", "Apt. 9",
                "Portland", "OR", 89581); // Test Address 6
            upv.AddAddress("Jennifer Hiesman", "199 Montary Way", "Suite 102",
                " Los Angeles", "CA", 57553); // Test Address 7
            upv.AddAddress("Michael Perry", "323 Kareem Ave", "Apt. 62",
                "Lexington", "KY", 64756); // Test Address 8

            //Addded additional test data to the list
            upv.AddLetter(upv.AddressAt(1), upv.AddressAt(5), 3.95M);   // Letter test object
            upv.AddLetter(upv.AddressAt(7), upv.AddressAt(2), 2.75M);// Letter test object
            upv.AddLetter(upv.AddressAt(0), upv.AddressAt(1), 8.95M);  // Letter test object
            upv.AddGroundPackage(upv.AddressAt(3), upv.AddressAt(6), 14, 10, 5, 12.5);        // Ground test object
            upv.AddGroundPackage(upv.AddressAt(2), upv.AddressAt(6), 10, 17, 2, 15.5);        // Ground test object
            upv.AddGroundPackage(upv.AddressAt(4), upv.AddressAt(1), 18, 12, 1, 14.5);        // Ground test object
            upv.AddNextDayAirPackage(upv.AddressAt(5), upv.AddressAt(4), 25, 15, 15,    // Next Day test object
                  85, 7.50M);
            upv.AddNextDayAirPackage(upv.AddressAt(6), upv.AddressAt(0), 13, 11, 39,    // Next Day test object
                27, 5.50M);
            upv.AddNextDayAirPackage(upv.AddressAt(0), upv.AddressAt(3), 32, 16, 57,    // Next Day test object
                74, 8.20M);

            upv.AddTwoDayAirPackage(upv.AddressAt(6), upv.AddressAt(5), 46.5, 39.5, 28.0, // Two Day test object
                80.5, TwoDayAirPackage.Delivery.Saver);
            upv.AddTwoDayAirPackage(upv.AddressAt(0), upv.AddressAt(2), 32.5, 56.5, 19.0, // Two Day test object
                30.5, TwoDayAirPackage.Delivery.Saver);
            upv.AddTwoDayAirPackage(upv.AddressAt(7), upv.AddressAt(6), 56.5, 95.5, 44, // Two Day test object
                59, TwoDayAirPackage.Delivery.Saver);

        }

        private void Prog2Form_Load(object sender, EventArgs e)
        {

        }

        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //This gives information about the user
            string NL = Environment.NewLine;
            MessageBox.Show($"My Grading ID is D3100 {NL} My section number is 01 {NL} This is my program 2");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //The button exits the application
            Application.Exit();
        }

        private void addressToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //This is where our address from is created
            AddressForm addressForm = new AddressForm();
            DialogResult result = addressForm.ShowDialog();
            int zipcode;

            if (result == DialogResult.OK)
            {
                if (int.TryParse(addressForm.Text, out zipcode))
                {
                    upv.AddAddress(addressForm.AddressName, addressForm.Address1, addressForm.City, addressForm.State, zipcode);
                }
                else
                {
                    MessageBox.Show("There is a validation error");
                }
            }

        }

        private void listAddressesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //This is an option that will hold the text
            StringBuilder result = new StringBuilder();

            //This is going to display a new line 
            string NL = Environment.NewLine;

            //This is going to show a result of the new line in the GUI
            result.Append(NL);

            //Want to show the result of each Address in the upv Address list
            foreach (Address a in upv.AddressList)
            {
                result.Append(NL);
            }
            
        }

        private void listParcelsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // This is an option that will hold the text
            StringBuilder result = new StringBuilder();

            //This is going to display a new line 
            string NL = Environment.NewLine;
            decimal theTotalCost = 0;

            //This is going to show a result of the new line in the GUI
            result.Append(NL);


            //Want to show the result of each Parcel in the upv Parcel list
            foreach (Parcel p in upv.ParcelList)
            {
                result.Append(NL);
                theTotalCost = p.CalcCost();
            }
        }

        private void letterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //This shows the dialog box for the letter form, the result of that specfic dialog box, and the set fixed cost
            LetterForm letterForm;
            DialogResult result;
            decimal theFixedCost;

            //This makes sure that we have enough addresses to use
            if (upv.AddressCount < LetterForm.MINIMUM_ADDRESSES)
            {
                //If there aren't enough addresses then there is a message box that tells us we need more
                MessageBox.Show("Error! Need to enter more addresses");
                return;
            }

            //Creating a new letter form where we can add more addresses
            letterForm = new LetterForm(upv.AddressList);

            //This shows the result of the new letter form we created
            result = letterForm.ShowDialog();

            if (decimal.TryParse(letterForm.FixedCostText, out theFixedCost))
            {
                
            }
        }
    }
}
            
                
            
        
    

