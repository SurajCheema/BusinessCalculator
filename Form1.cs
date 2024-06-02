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
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ratioTypeCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ratioTypeCombobox.SelectedIndex < 1)
            {
                ratio_checkbox_panel.Visible = false;
            }
            else
            {
                ratio_checkbox_panel.Visible = true;
                DisplayCheckboxesForRatio();
            }
        }

        private void DisplayCheckboxesForRatio()
        {
            if (ratioTypeCombobox.SelectedIndex == 1)
            {
                //Profitability ratios selected
                profitabiliy_checkboxes.Enabled = true;
                liquidity_checkboxes.Enabled = false;
                leverage_checkboxes.Enabled = false;
            }
            else if (ratioTypeCombobox.SelectedIndex == 2)
            {
                //Liquidity ratios selected
                profitabiliy_checkboxes.Enabled = false;
                liquidity_checkboxes.Enabled = true;
                leverage_checkboxes.Enabled = false;
            }
            else if (ratioTypeCombobox.SelectedIndex == 3)
            {
                //Leverage ratios
                leverage_checkboxes.Enabled = true;
                profitabiliy_checkboxes.Enabled = false;
                liquidity_checkboxes.Enabled = false;
            }
            else
            {
                //Operating ratios
            }
        }

        private void liquidity_checkboxes_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ratioTypeCombobox.SelectedIndex == 2)
            {
                new liquidityRatiosInputForm(checkBox_currentRatio.Checked, checkBox_quickRatio.Checked, checkBox_cashRatio.Checked).ShowDialog();
            }
            else if(ratioTypeCombobox.SelectedIndex == 1)
            {
                new marginForm(checkBox_grossMargin.Checked, checkBox_operatingMargin.Checked, checkBox_netProfitMargin.Checked).ShowDialog();
            }
            else if(ratioTypeCombobox.SelectedIndex == 3)
            {
                new LeverageForm(debtequity.Checked, debtCapital.Checked, netDebt.Checked, debtToEnterprise.Checked).ShowDialog();
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
