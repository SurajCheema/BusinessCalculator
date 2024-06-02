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
    public partial class liquidityRatiosInputForm : Form
    {
        private bool current, quick, cash;
        public liquidityRatiosInputForm()
        {
            InitializeComponent();
        }

        private void currentAssets_TextChanged(object sender, EventArgs e)
        {

        }

        public liquidityRatiosInputForm(bool current, bool quick, bool cash)
        {
            InitializeComponent();
            this.cash = cash;
            this.quick = quick;
            this.current = current;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Work out the answers
            Dictionary<string, float> results = new Dictionary<string, float>();
            if (current)
            {
                results.Add("Current ratio", (currentAssets.GetValue() / currentLiabilities.GetValue()));
            }
            if (quick)
            {
                results.Add("Quick ratio", ((currentAssets.GetValue() - currentInventory.GetValue()) / currentLiabilities.GetValue()));
            }
            if (cash)
            {
                results.Add("Cash ratio", (currentCash.GetValue() / currentLiabilities.GetValue()));
            }

            new RatioResults(results).ShowDialog();
        }
    }
}
