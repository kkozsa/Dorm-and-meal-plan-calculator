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
            totalLabel.Text = "€" + totalCost.ToString();   // Initialize this component and sets te text of totalLabel
        }                                                   // to display the total cost which converted to a string.

        private void closeButton_Click(object sender, EventArgs e)      // This event closes the TotalForm
        {
            this.Close();
        }
    }
}
