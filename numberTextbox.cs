using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorBusiness
{
    public class numberTextbox : TextBox
    {
        public numberTextbox()
        {
            this.TextChanged += NumberTextbox_TextChanged;
        }

        public float GetValue()
        {
            float v = 0;
            float.TryParse(Text, out v);
            return v;
        }

        private void NumberTextbox_TextChanged(object sender, EventArgs e)
        {
            string inputText = Text;
            string outputText = "";
            foreach (char c in inputText)
            {
                if ("0123456789.".Contains(c))
                {
                    outputText += c.ToString();
                }
            }
            Text = outputText;
        }
    }

    
}
