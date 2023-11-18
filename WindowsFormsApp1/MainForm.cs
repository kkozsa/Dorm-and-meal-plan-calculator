using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class MainForm : Form        // Define MainForm class that inherits from main Form class.
    {
        public MainForm()
        {
            InitializeComponent();
        }

        double totalCost;               // Variable totalCost that is stores the calculated total cost.
               
        private void totalButton_Click(object sender, EventArgs e)
        {
            double dormCost = 0;                // Initial values 0
            double mealCost = 0;                

            if (allenRadiobutton.Checked)
            {
                dormCost = 1500;
            }

            else if (pikeRadiobutton.Checked)
            {
                dormCost = 1600;
            }

            else if (dbsRadiobutton.Checked)
            {
                dormCost = 1800;
            }

            else if (suiteButton.Checked)
            {
                dormCost = 2500;
            }

            if (sevenRadiobutton.Checked)
            {
                mealCost = 600;
            }

            else if (fourteenRadiobutton.Checked)
            {
                mealCost = 1200;
            }

            else if (unlimitedRadiobutton.Checked)
            {
                mealCost = 1700;
            }

            totalCost = dormCost + mealCost;

            TotalForm myTotalForm = new TotalForm(totalCost);       // TotalForm is another form class that is
                                                                    
            myTotalForm.Show();                                     // Displays the total cost.


        }
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
