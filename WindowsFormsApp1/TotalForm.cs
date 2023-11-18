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
    public partial class TotalForm : Form       // Define TotalForm class that inherits from main Form class.
    {
        public TotalForm(double totalCost)      // The constructor of TotalForm takes the parameter totalCost.
        {
            InitializeComponent();
            totalLabel.Text = "€" + totalCost.ToString();   
        }                                                   // To display the total cost.

        private void closeButton_Click(object sender, EventArgs e)
        { 
            this.Close();
        }
    }
}
