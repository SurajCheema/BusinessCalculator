namespace CalculatorBusiness
{
    partial class marginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grossProfit = new CalculatorBusiness.numberTextbox();
            this.operatingIncome = new CalculatorBusiness.numberTextbox();
            this.netIncome = new CalculatorBusiness.numberTextbox();
            this.sales = new CalculatorBusiness.numberTextbox();
            this.grossProfitLabel = new System.Windows.Forms.Label();
            this.operatingProfitLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.calculatorTab2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // grossProfit
            // 
            this.grossProfit.Location = new System.Drawing.Point(378, 67);
            this.grossProfit.Name = "grossProfit";
            this.grossProfit.Size = new System.Drawing.Size(100, 20);
            this.grossProfit.TabIndex = 5;
            // 
            // operatingIncome
            // 
            this.operatingIncome.Location = new System.Drawing.Point(378, 131);
            this.operatingIncome.Name = "operatingIncome";
            this.operatingIncome.Size = new System.Drawing.Size(100, 20);
            this.operatingIncome.TabIndex = 6;
            // 
            // netIncome
            // 
            this.netIncome.Location = new System.Drawing.Point(378, 192);
            this.netIncome.Name = "netIncome";
            this.netIncome.Size = new System.Drawing.Size(100, 20);
            this.netIncome.TabIndex = 7;
            // 
            // sales
            // 
            this.sales.Location = new System.Drawing.Point(378, 254);
            this.sales.Name = "sales";
            this.sales.Size = new System.Drawing.Size(100, 20);
            this.sales.TabIndex = 8;
            // 
            // grossProfitLabel
            // 
            this.grossProfitLabel.AutoSize = true;
            this.grossProfitLabel.Location = new System.Drawing.Point(229, 73);
            this.grossProfitLabel.Name = "grossProfitLabel";
            this.grossProfitLabel.Size = new System.Drawing.Size(61, 13);
            this.grossProfitLabel.TabIndex = 9;
            this.grossProfitLabel.Text = "Gross Profit";
            this.grossProfitLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // operatingProfitLabel
            // 
            this.operatingProfitLabel.AutoSize = true;
            this.operatingProfitLabel.Location = new System.Drawing.Point(229, 131);
            this.operatingProfitLabel.Name = "operatingProfitLabel";
            this.operatingProfitLabel.Size = new System.Drawing.Size(91, 13);
            this.operatingProfitLabel.TabIndex = 10;
            this.operatingProfitLabel.Text = "Operating Income";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(229, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Net Income";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(229, 257);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Sales";
            // 
            // calculatorTab2
            // 
            this.calculatorTab2.Location = new System.Drawing.Point(378, 350);
            this.calculatorTab2.Name = "calculatorTab2";
            this.calculatorTab2.Size = new System.Drawing.Size(75, 23);
            this.calculatorTab2.TabIndex = 13;
            this.calculatorTab2.Text = "Results";
            this.calculatorTab2.UseVisualStyleBackColor = true;
            this.calculatorTab2.Click += new System.EventHandler(this.calculatorTab2_Click);
            // 
            // marginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.calculatorTab2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.operatingProfitLabel);
            this.Controls.Add(this.grossProfitLabel);
            this.Controls.Add(this.sales);
            this.Controls.Add(this.netIncome);
            this.Controls.Add(this.operatingIncome);
            this.Controls.Add(this.grossProfit);
            this.Name = "marginForm";
            this.Text = "marginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private numberTextbox grossProfit;
        private numberTextbox operatingIncome;
        private numberTextbox netIncome;
        private numberTextbox sales;
        private System.Windows.Forms.Label grossProfitLabel;
        private System.Windows.Forms.Label operatingProfitLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button calculatorTab2;
    }
}