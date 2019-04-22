// Program 2
// CIS 200-01
// Fall 2018
// Due: 10/25/2018
// By: Andrew L. Wright (Students use Grading ID)

// File: Prog2Form.cs
// This class creates the main GUI for Program 2. It provides a
// File menu with About and Exit items, an Insert menu with Address and
// Letter items, and a Report menu with List Addresses and List Parcels
// items.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Windows.Forms;

namespace UPVApp
{
    public partial class Prog2Form : Form
    {
        private UserParcelView upv; // The UserParcelView

        // Precondition:  None
        // Postcondition: The form's GUI is prepared for display. A few test addresses are
        //                added to the list of addresses
        public Prog2Form()
        {
            InitializeComponent();

            upv = new UserParcelView();


        }

        // Precondition:  File, About menu item activated
        // Postcondition: Information about author displayed in dialog box
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string NL = Environment.NewLine; // Newline shorthand

            MessageBox.Show($"Program 2{NL}By: Andrew L. Wright{NL}CIS 200{NL}Fall 2018",
                "About Program 2");
        }

        // Precondition:  File, Exit menu item activated
        // Postcondition: The application is exited
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Precondition:  Insert, Address menu item activated
        // Postcondition: The Address dialog box is displayed. If data entered
        //                are OK, an Address is created and added to the list
        //                of addresses
        private void addressToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddressForm addressForm = new AddressForm();    // The address dialog box form
            DialogResult result = addressForm.ShowDialog(); // Show form as dialog and store result
            int zip; // Address zip code

            if (result == DialogResult.OK) // Only add if OK
            {
                if (int.TryParse(addressForm.ZipText, out zip))
                {
                    upv.AddAddress(addressForm.AddressName, addressForm.Address1,
                        addressForm.Address2, addressForm.City, addressForm.State,
                        zip); // Use form's properties to create address
                }
                else // This should never happen if form validation works!
                {
                    MessageBox.Show("Problem with Address Validation!", "Validation Error");
                }
            }

            addressForm.Dispose(); // Best practice for dialog boxes
                                   // Alternatively, use with using clause as in Ch. 17
        }

        // Precondition:  Report, List Addresses menu item activated
        // Postcondition: The list of addresses is displayed in the addressResultsTxt
        //                text box
        private void listAddressesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StringBuilder result = new StringBuilder(); // Holds text as report being built
                                                        // StringBuilder more efficient than String
            string NL = Environment.NewLine;            // Newline shorthand

            result.Append("Addresses:");
            result.Append(NL); // Remember, \n doesn't always work in GUIs
            result.Append(NL);

            foreach (Address a in upv.AddressList)
            {
                result.Append(a.ToString());
                result.Append(NL);
                result.Append("------------------------------");
                result.Append(NL);
            }

            reportTxt.Text = result.ToString();

            // -- OR --
            // Not using StringBuilder, just use TextBox directly

            //reportTxt.Clear();
            //reportTxt.AppendText("Addresses:");
            //reportTxt.AppendText(NL); // Remember, \n doesn't always work in GUIs
            //reportTxt.AppendText(NL);

            //foreach (Address a in upv.AddressList)
            //{
            //    reportTxt.AppendText(a.ToString());
            //    reportTxt.AppendText(NL);
            //    reportTxt.AppendText("------------------------------");
            //    reportTxt.AppendText(NL);
            //}

            // Put cursor at start of report
            reportTxt.Focus();
            reportTxt.SelectionStart = 0;
            reportTxt.SelectionLength = 0;
        }

        // Precondition:  Insert, Letter menu item activated
        // Postcondition: The Letter dialog box is displayed. If data entered
        //                are OK, a Letter is created and added to the list
        //                of parcels
        private void letterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LetterForm letterForm; // The letter dialog box form
            DialogResult result;   // The result of showing form as dialog
            decimal fixedCost;     // The letter's cost

            if (upv.AddressCount < LetterForm.MIN_ADDRESSES) // Make sure we have enough addresses
            {
                MessageBox.Show("Need " + LetterForm.MIN_ADDRESSES + " addresses to create letter!",
                    "Addresses Error");
                return; // Exit now since can't create valid letter
            }

            letterForm = new LetterForm(upv.AddressList); // Send list of addresses
            result = letterForm.ShowDialog();

            if (result == DialogResult.OK) // Only add if OK
            {
                if (decimal.TryParse(letterForm.FixedCostText, out fixedCost))
                {
                    // For this to work, LetterForm's combo boxes need to be in same
                    // order as upv's AddressList
                    upv.AddLetter(upv.AddressAt(letterForm.OriginAddressIndex),
                        upv.AddressAt(letterForm.DestinationAddressIndex),
                        fixedCost); // Letter to be inserted
                }
                else // This should never happen if form validation works!
                {
                    MessageBox.Show("Problem with Letter Validation!", "Validation Error");
                }
            }

            letterForm.Dispose(); // Best practice for dialog boxes
                                  // Alternatively, use with using clause as in Ch. 17
        }

        // Precondition:  Report, List Parcels menu item activated
        // Postcondition: The list of parcels is displayed in the parcelResultsTxt
        //                text box
        private void listParcelsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StringBuilder result = new StringBuilder(); // Holds text as report being built
                                                        // StringBuilder more efficient than String
            decimal totalCost = 0;                      // Running total of parcel shipping costs
            string NL = Environment.NewLine;            // Newline shorthand

            result.Append("Parcels:");
            result.Append(NL); // Remember, \n doesn't always work in GUIs
            result.Append(NL);

            foreach (Parcel p in upv.ParcelList)
            {
                result.Append(p.ToString());
                result.Append(NL);
                result.Append("------------------------------");
                result.Append(NL);
                totalCost += p.CalcCost();
            }

            result.Append(NL);
            result.Append($"Total Cost: {totalCost:C}");

            reportTxt.Text = result.ToString();

            // Put cursor at start of report
            reportTxt.Focus();
            reportTxt.SelectionStart = 0;
            reportTxt.SelectionLength = 0;
        }

        private void opToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //This is used to put the uPV into binary format
            BinaryFormatter theformat = new BinaryFormatter();
            //We want a dialog box to show our results
            DialogResult result;
            //Create a string for when choosing a file
            string chooseYourFile;
            //This stream reads the file
            FileStream inputvalue = null;
            UserParcelView temporaryholder;

            //Creating the Dialog Box to open
            using (OpenFileDialog chosenFile = new OpenFileDialog())
            {
                //This shows the results from the Dialog Box
                result = chosenFile.ShowDialog();
                //This shows the file name once we choose our file
                chooseYourFile = chosenFile.FileName;
            }

            if (DialogResult.OK == result)
            {
                // If there is an empty file or filename, then there should be a message box that details us about the error
                if (chooseYourFile == string.Empty)
                    MessageBox.Show("The name for this file is invalid");
                else
                {
                    //If there isnt an error then we need to create a file and have and have the UPV choose a file
                    try
                    {
                        //The file is read and accessed from the file stream
                        inputvalue = new FileStream(chooseYourFile, FileMode.Open, FileAccess.ReadWrite);
                        // The UPV is taken from the file that we have chosen
                        temporaryholder = (UserParcelView)theformat.Deserialize(inputvalue);
                    }
                    //This will display if there an erro occurs when trying to open the file that was created
                    catch (IOException)
                    {
                        MessageBox.Show("There is a problem opening up this file");
                    }
                    //This will display if there an erro occurs when trying to open the file that was created
                    finally
                    {
                        //Once the value is outputted it will then close
                        inputvalue.Close();
                    }

                    if (DialogResult.OK == result)
                    {
                        // If there is an empty file or filename, then there should be a message box that details us about the error
                        if (chooseYourFile == string.Empty)
                            MessageBox.Show("The name for this file is invalid");
                        else
                        {
                            //If there isnt an error then we need to create a file and have and have the UPV choose a file
                            try
                            {
                                //The file is read and accessed from the file stream
                                inputvalue = new FileStream(chooseYourFile, FileMode.Open, FileAccess.ReadWrite);
                                // The UPV is taken from the file that we have chosen
                                temporaryholder = (UserParcelView)theformat.Deserialize(inputvalue);
                            }
                            //This will display if there an erro occurs when trying to open the file that was created
                            catch (IOException)
                            {
                                MessageBox.Show("There is a problem opening up this file");
                            }
                            //This will display if there an erro occurs when trying to open the file that was created
                            finally
                            {
                                //Once the value is outputted it will then close
                                inputvalue.Close();
                            }
                        }
                    }
                }
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //This is used to put the uPV into binary format
            BinaryFormatter theformat = new BinaryFormatter();
            //We want a dialog box to show our results
            DialogResult result;
            //Create a string for when choosing a file
            string chooseYourFile;
            //This stream reads the file
            FileStream outputvalue = null;

            //Creating the Dialog Box to Save As
            using (SaveFileDialog chosenFile = new SaveFileDialog())
            {
                //This shows the results from the Dialog Box
                result = chosenFile.ShowDialog();
                //This shows the file name once we choose our file
                chooseYourFile = chosenFile.FileName;
            }

            if (DialogResult.OK == result)
            {
                // If there is an empty file or filename, then there should be a message box that details us about the error
                if (chooseYourFile == string.Empty)
                    MessageBox.Show("The name for this file is invalid");

                else
                {
                    //If there isnt an error then we need to create a file and have and have the UPV choose a file
                    try
                    {
                        outputvalue = new FileStream(chooseYourFile, FileMode.CreateNew);

                        theformat.Serialize(outputvalue, upv);
                    }
                    //This will display if there an erro occurs when trying to open the file that was created
                    catch (IOException)
                    {
                        MessageBox.Show("There is a problem opening up this file");
                    }
                    //This will display if there an erro occurs when trying to open the file that was created
                    finally
                    {
                        //Once the value is outputted it will then close
                        outputvalue.Close();
                    }


                    if (DialogResult.OK == result)
                    {
                        // If there is an empty file or filename, then there should be a message box that details us about the error
                        if (chooseYourFile == string.Empty)
                            MessageBox.Show("The name for this file is invalid");

                        else
                        {
                            //If there isnt an error then we need to create a file and have and have the UPV choose a file
                            try
                            {
                                outputvalue = new FileStream(chooseYourFile, FileMode.CreateNew);

                                theformat.Serialize(outputvalue, upv);
                            }
                            //This will display if there an erro occurs when trying to open the file that was created
                            catch (SerializationException)
                            {
                                MessageBox.Show("There is a problem opening up this file");
                            }

                            //This will display if there an erro occurs when trying to open the file that was created
                            finally
                            {
                                //Once the value is outputted it will then close
                                outputvalue.Close();
                            }
                        }

                    }
                }
            }
        }

        private void addressToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (upv.AddressList.Count > 1)
            {
                //This will show the Dialog Box form to edit a address
                NewAddressForm pickAddressForm = new NewAddressForm(upv.AddressList);
                //The results will be shown with a dialog box
                DialogResult result = pickAddressForm.ShowDialog();

                if (DialogResult.OK == result)
                {
                    //This is the index of the address that we have chosen to edit
                    int editTheAddressIndex;
                    editTheAddressIndex = pickAddressForm.ChosenAddress;

                    if (editTheAddressIndex >= 1)
                    {
                        Address addressBeingEdited = upv.AddressAt(editTheAddressIndex);
                        AddressForm theNewAddressForm = new AddressForm();

                        //The form for the addressses has been populated here
                        theNewAddressForm.AddressName = addressBeingEdited.Name;
                        theNewAddressForm.Address1 = addressBeingEdited.Address1;
                        theNewAddressForm.Address2 = addressBeingEdited.Address2;
                        theNewAddressForm.ZipText = $"{ addressBeingEdited.Zip}";
                        theNewAddressForm.State = addressBeingEdited.State;
                        theNewAddressForm.City = addressBeingEdited.Name;

                        //Showing the Dialog Results from the previous information
                        result = theNewAddressForm.ShowDialog();

                        if (DialogResult.OK == result)
                        {
                            addressBeingEdited.Name = theNewAddressForm.AddressName;
                            addressBeingEdited.Address1 = theNewAddressForm.Address1;
                            addressBeingEdited.Address2 = theNewAddressForm.Address2;
                            addressBeingEdited.State = theNewAddressForm.State;
                            addressBeingEdited.City = theNewAddressForm.City;
                        }

                    }
                }
            }
        }
    }
}
    


