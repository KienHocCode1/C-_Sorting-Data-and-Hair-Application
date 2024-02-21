using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3B
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //listbox adding method
            HairdresserDropdownBox.Items.AddRange(new string[] { "Jane Samley", "Pat Johnson", "Ron Chambers", "Sue Pallon", "Laurie Renkins" });
            HairdresserDropdownBox.SelectedIndex = 0;
            //listbox adding method
            ServiceListBox.Items.AddRange(new string[] { "Cut", "Wash, blow-dry, and style", "Colour", "Highlights", "Extensions", "Up-to" });
            //disable add server, calculate button 
            AddServiceButton.Enabled = false;
            CalculateButton.Enabled = false;
        }
        //-------------------------------------Add service button----------------------------------//
        /// <summary>
        /// Event handler for the Add Service button click event. Handles the selection of hairdresser and services, 
        /// and updates the display accordingly.
        /// </summary>
        /// <param name="sender">The object that triggered the event.</param>
        /// <param name="e">The event arguments.</param
        private void AddServiceButton_Click(object sender, EventArgs e)
        {
            //disable hairdresser selection
            HairdresserDropdownBox.Enabled = false;
            // enable calculate button when Add service is used for 1st time
            if (AddServiceButton.Enabled)
            {
                CalculateButton.Enabled = true;
            }
            else 
            {
                CalculateButton.Enabled = false;
            }
            ///<summary>
            /// Display prices accordingly to Hairdresser and multiple selected Services and display them on Charged ListBox and Price ListBox
            /// </summary>
            if (HairdresserDropdownBox.SelectedItem != null && ServiceListBox.SelectedItems != null)
            {
                string selectedHairdresser = HairdresserDropdownBox.SelectedItem.ToString();
                int selectedHairdresserValue;

                if (selectedHairdresser == "Jane Samley")
                {
                    selectedHairdresserValue = 30;
                }
                else if (selectedHairdresser == "Pat Johnson")
                {
                    selectedHairdresserValue = 45;
                }
                else if (selectedHairdresser == "Ron Chambers")
                {
                    selectedHairdresserValue = 40;
                }
                else if (selectedHairdresser == "Sue Pallon")
                {
                    selectedHairdresserValue = 50;
                }
                else if (selectedHairdresser == "Laurie Renkins")
                {
                    selectedHairdresserValue = 55;
                }
                else
                {
                    selectedHairdresserValue = 0;
                }
                ////-----LIST BOX PROPERTIES------////
                // clear charged box if user select more services
                ChargedItemsListBox.Items.Clear();
                // display selected hairdresser as a string to charged box ToString()
                ChargedItemsListBox.Items.Add(selectedHairdresser.ToString());
                //clear price box when user select more services
                PriceBox.Items.Clear();
                // display integer as string using ToString()
                PriceBox.Items.Add("$"+selectedHairdresserValue.ToString());

                ///<summary>
                /// display multiple services on Charged ListBox if user select multiple and return according value for that service
                /// </summary>
                foreach (var selectedItem in ServiceListBox.SelectedItems)
                {
                    string selectedService = selectedItem.ToString();
                    int selectedServiceValue;

                    if (selectedService == "Cut")
                    {
                        selectedServiceValue = 30;
                    }
                    else if (selectedService == "Wash, blow-dry, and style")
                    {
                        selectedServiceValue = 20;
                    }
                    else if (selectedService == "Colour")
                    {
                        selectedServiceValue = 40;
                    }
                    else if (selectedService == "Highlights")
                    {
                        selectedServiceValue = 50;
                    }
                    else if (selectedService == "Extensions")
                    {
                        selectedServiceValue = 200;
                    }
                    else if (selectedService == "Up-to")
                    {
                        selectedServiceValue = 60;
                    }
                    else
                    {
                        selectedServiceValue = 0; // Default value if none of the options match
                    }
                    // display services onto Charged ListBox
                    ChargedItemsListBox.Items.Add(selectedService);
                    // Display price for selected service parallel
                    PriceBox.Items.Add("$" + selectedServiceValue.ToString());
                }
            }
        }
        //---------------------------------------Calculate button--------------------------------------//
        /// <summary>
        /// Event handler for the Calculate button click event. Calculates and displays the total prices of selected services.
        /// </summary>
        /// <param name="sender">The object that triggered the event.</param>
        /// <param name="e">The event arguments.</param>
        private void CalculateButton_Click(object sender, EventArgs e)
        {
            ///<summary>
            /// Similar functionality to Add Service Button but this time it display Final Price on Total Price Display TextBox
            /// </summary>
            
            // disable hairdresser when calculate button is clicked
            HairdresserDropdownBox.Enabled = false;          
            if (HairdresserDropdownBox.SelectedItem != null && ServiceListBox.SelectedItems != null)
            {
                // total amount to display
                int finalServiceValue = 0;
                string selectedHairdresser = HairdresserDropdownBox.SelectedItem.ToString();
                //Hairdresser amount
                int selectedHairdresserValue;

                if (selectedHairdresser == "Jane Samley")
                {
                    selectedHairdresserValue = 30;
                }
                else if (selectedHairdresser == "Pat Johnson")
                {
                    selectedHairdresserValue = 45;
                }
                else if (selectedHairdresser == "Ron Chambers")
                {
                    selectedHairdresserValue = 40;
                }
                else if (selectedHairdresser == "Sue Pallon")
                {
                    selectedHairdresserValue = 50;
                }
                else if (selectedHairdresser == "Laurie Renkins")
                {
                    selectedHairdresserValue = 55;
                }
                else
                {
                    selectedHairdresserValue = 0;
                }
                ChargedItemsListBox.Items.Clear();
                ChargedItemsListBox.Items.Add(selectedHairdresser.ToString());
                PriceBox.Items.Clear();
                PriceBox.Items.Add("$" + selectedHairdresserValue.ToString());

                foreach (var selectedItem in ServiceListBox.SelectedItems)
                {
                    string selectedService = selectedItem.ToString();
                    //service amount
                    int selectedServiceValue;

                    if (selectedService == "Cut")
                    {
                        selectedServiceValue = 30;
                    }
                    else if (selectedService == "Wash, blow-dry, and style")
                    {
                        selectedServiceValue = 20;
                    }
                    else if (selectedService == "Colour")
                    {
                        selectedServiceValue = 40;
                    }
                    else if (selectedService == "Highlights")
                    {
                        selectedServiceValue = 50;
                    }
                    else if (selectedService == "Extensions")
                    {
                        selectedServiceValue = 200;
                    }
                    else if (selectedService == "Up-to")
                    {
                        selectedServiceValue = 60;
                    }
                    else
                    {
                        selectedServiceValue = 0; // Default value if none of the options match
                    }
                    ChargedItemsListBox.Items.Add(selectedService);
                    PriceBox.Items.Add("$" + selectedServiceValue.ToString());
                    //accumulate amount for services
                    finalServiceValue += selectedServiceValue;
                }
                // Display final amount to text box
                TotalPriceDisplayBox.Text = $"${finalServiceValue + selectedHairdresserValue}";
            }
        }
        /// <summary>
        /// Event handler for the Reset button click event. Resets the form's elements including ListBox selections, TextBox values, 
        /// and Button states to their default settings.
        /// </summary>
        /// <param name="sender">The object that triggered the event.</param>
        /// <param name="e">The event arguments.</param>
        private void ResetButton_Click(object sender, EventArgs e)
        {
            //ListBoxes Name.Items.Add()/Clear()
            // if Name.SelectedItems != null
            HairdresserDropdownBox.SelectedIndex = 0;
            ChargedItemsListBox.Items.Clear();
            PriceBox.Items.Clear();           
            ServiceListBox.SelectedItems.Clear();
            // clear text box
            TotalPriceDisplayBox.Text = "";
            // disable Buttons
            AddServiceButton.Enabled = false;
            CalculateButton.Enabled = false;
            // Enable hairdresser box
            HairdresserDropdownBox.Enabled = true;
            // set focus to the hairdresser box
            ActiveControl = HairdresserDropdownBox;
        }

        /// <summary>
        /// Event handler for the SelectedIndexChanged event of the ServiceListBox. 
        /// Enables the Add Service button if an item is selected, otherwise disables it.
        /// </summary>
        /// <param name="sender">The object that triggered the event.</param>
        /// <param name="e">The event arguments.</param>
        private void ServiceListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // if 1 or more service is selected => Enable Add service button
            if (ServiceListBox.SelectedItem != null)
            {
                AddServiceButton.Enabled = true;
            }
            else 
            {
                AddServiceButton.Enabled = false;
            }           
        }
        /// <summary>
        /// Close the program
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
