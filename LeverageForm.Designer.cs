namespace CalculatorBusiness
{
    partial class LeverageForm
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
            this.totalDebt = new CalculatorBusiness.numberTextbox();
            this.totalEquity = new CalculatorBusiness.numberTextbox();
            this.excessCash = new CalculatorBusiness.numberTextbox();
            this.shortTerm = new CalculatorBusiness.numberTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.levResults = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // totalDebt
            // 
            this.totalDebt.Location = new System.Drawing.Point(402, 42);
            this.totalDebt.Name = "totalDebt";
            this.totalDebt.Size = new System.Drawing.Size(100, 20);
            this.totalDebt.TabIndex = 5;
            // 
            // totalEquity
            // 
            this.totalEquity.Location = new System.Drawing.Point(402, 94);
            this.totalEquity.Name = "totalEquity";
            this.totalEquity.Size = new System.Drawing.Size(100, 20);
            this.totalEquity.TabIndex = 6;
            // 
            // excessCash
            // 
            this.excessCash.Location = new System.Drawing.Point(402, 151);
            this.excessCash.Name = "excessCash";
            this.excessCash.Size = new System.Drawing.Size(100, 20);
            this.excessCash.TabIndex = 7;
            // 
            // shortTerm
            // 
            this.shortTerm.Location = new System.Drawing.Point(402, 212);
            this.shortTerm.Name = "shortTerm";
            this.shortTerm.Size = new System.Drawing.Size(100, 20);
            this.shortTerm.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(161, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Total Debt";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(161, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Total equity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(161, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Excess Cash";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(161, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Short-term investments";
            // 
            // levResults
            // 
            this.levResults.Location = new System.Drawing.Point(402, 319);
            this.levResults.Name = "levResults";
            this.levResults.Size = new System.Drawing.Size(75, 23);
            this.levResults.TabIndex = 15;
            this.levResults.Text = "Results";
            this.levResults.UseVisualStyleBackColor = true;
            this.levResults.Click += new System.EventHandler(this.levResults_Click);
            // 
            // LeverageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.levResults);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.shortTerm);
            this.Controls.Add(this.excessCash);
            this.Controls.Add(this.totalEquity);
            this.Controls.Add(this.totalDebt);
            this.Name = "LeverageForm";
            this.Text = "LeverageForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private numberTextbox totalDebt;
        private numberTextbox totalEquity;
        private numberTextbox excessCash;
        private numberTextbox shortTerm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button levResults;
    }
}