using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorBusiness
{
    
    public partial class marginForm : Form
    {
        private bool gross, operating, net;
        public marginForm()
        {
            InitializeComponent();
        }

        public marginForm(bool gross, bool operating, bool net)
        {
            InitializeComponent();
            this.gross = gross;
            this.operating = operating;
            this.net = net;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void calculatorTab2_Click(object sender, EventArgs e)
        {
            //Work out the answers
            Dictionary<string, float> results = new Dictionary<string, float>();
            if (gross)
            {
                results.Add("Gross Margin", (grossProfit.GetValue() / sales.GetValue()));
            }
            if (operating)
            {
                results.Add("Operating Margin", ((operatingIncome.GetValue() / sales.GetValue())));
            }
            if (net)
            {
                results.Add("Net Profit Margin", (netIncome.GetValue() / sales.GetValue()));
            }

            new RatioResults(results).ShowDialog();
        }
    }
}
