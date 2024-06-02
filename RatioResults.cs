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
    public partial class RatioResults : Form
    {
        public RatioResults()
        {
            InitializeComponent();
        }

        public RatioResults(Dictionary<string, float> results)
        {
            InitializeComponent();
            foreach (KeyValuePair<string,float> kvp in results)
            {
                dataGridView1.Rows.Add(new object[] { kvp.Key, kvp.Value });
            }
        }
    }
}
