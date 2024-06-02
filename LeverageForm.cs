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
    public partial class LeverageForm : Form
    {
        private bool debt, capital, netDebt, debtEnterprise;
        public LeverageForm()
        {
            InitializeComponent();
        }
        public LeverageForm(bool debt, bool capital, bool netDebt, bool debtEnterprise)
        {
            InitializeComponent();

        }

        private void levResults_Click(object sender, EventArgs e)
        {
            Dictionary<string, float> results = new Dictionary<string, float>();
            if (debt)
            {
                results.Add("Debt-equity ratio", totalDebt.GetValue() / totalEquity.GetValue());
            }
            if (capital)
            {
                results.Add("Operating Margin", ((totalDebt.GetValue() / (totalEquity.GetValue() + totalDebt.GetValue()))));
            }
            if (netDebt)
            {
                results.Add("Net Profit Margin", (totalDebt.GetValue() - (excessCash.GetValue() + shortTerm.GetValue())));
            }

            new RatioResults(results).ShowDialog();
        }
    }
}
