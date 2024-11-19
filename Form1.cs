//Name: Ahmed Benyusf
//Class and Section (CS 313 01)
//Assignment (Program 01 Chapter 07)
//Description of the Program : this program reads sales values from a file and displays
//the values in a list box. It also calculates the total sales and the average sales.

//Extra Credit: The program also displays the highest sales value in a message box.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C07_P01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ReadSales(List<double> SalesList)
        {
            try
            {
                StreamReader inputFile = File.OpenText("Sales.txt");
                //  Open the file
                while (!inputFile.EndOfStream)
                //  Continue processing until the end of the file is reached
                {

                    string line = inputFile.ReadLine();
                    //  Read a line from the file
                    if (double.TryParse(line, out double salesValue))
                    //  Convert the input to a double
                    {
                        SalesList.Add(salesValue);
                        //  Add the sales value to the list
                    }
                }
                inputFile.Close();
                //  Close the file
            }
            catch (Exception ex)
            //  Catch any exceptions that occur
            {
                MessageBox.Show(ex.Message);
                //  Display an error message
            }
        }

        private void DisplaySales(List<double> SalesList)
        {
            foreach (double value in SalesList)

            {
                OutputListbox.Items.Add(value);
                //  Display the sales values
            }
        }
        private double AverageSales(List<double> SalesList)
        {
            double total = 0;
            double Average = 0;
            //  Set the accumulator to 0

            foreach (double value in SalesList)

            {
                total += value;
                //  Add the value to the total
            }
            Average = (double)total / SalesList.Count;
            //  Calculate the average sales
            return Average;
            
        }

        private void TotalSales(List<double> SalesList)
        {
            double total = 0;
            //  Set the accumulator to 0
            foreach (double value in SalesList)
            //  Add the value to the total
            {
                total += value;
                //  Display the total sales
            }
            TotalTextBox.Text = total.ToString("c");
            // Display the total sales
        }
        // extra credit
        private void HighestSale(List<double> SalesList)
        {
            double Highest = SalesList.Max();
            //  Find the largest sale
            MessageBox.Show ("The Highest sales value is :"+Highest.ToString("c"));
            //  Display the Highest sale
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
            // Close the form.
        }

        private void GetSalesButton_Click(object sender, EventArgs e)
        {
            // Create a list to hold the sales values.
            List<double> SalesList = new List<double>();
            
            // Read the sales values from the file
            ReadSales(SalesList);
            // Display the sales values.
            DisplaySales(SalesList);
            // Display the total sales
            TotalSales(SalesList);
            // Display the largest sale
            HighestSale(SalesList);

            AvgTextBox.Text = AverageSales(SalesList).ToString("c");
            // Display the average sales
            

        }
    }
}
