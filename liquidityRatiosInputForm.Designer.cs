namespace CalculatorBusiness
{
    partial class liquidityRatiosInputForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.currentCash = new CalculatorBusiness.numberTextbox();
            this.currentInventory = new CalculatorBusiness.numberTextbox();
            this.currentLiabilities = new CalculatorBusiness.numberTextbox();
            this.currentAssets = new CalculatorBusiness.numberTextbox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Current assets";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Current liabilities";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Inventory";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cash";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(266, 290);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // currentCash
            // 
            this.currentCash.Location = new System.Drawing.Point(148, 205);
            this.currentCash.Name = "currentCash";
            this.currentCash.Size = new System.Drawing.Size(100, 20);
            this.currentCash.TabIndex = 7;
            // 
            // currentInventory
            // 
            this.currentInventory.Location = new System.Drawing.Point(148, 161);
            this.currentInventory.Name = "currentInventory";
            this.currentInventory.Size = new System.Drawing.Size(100, 20);
            this.currentInventory.TabIndex = 6;
            // 
            // currentLiabilities
            // 
            this.currentLiabilities.Location = new System.Drawing.Point(148, 117);
            this.currentLiabilities.Name = "currentLiabilities";
            this.currentLiabilities.Size = new System.Drawing.Size(100, 20);
            this.currentLiabilities.TabIndex = 5;
            // 
            // currentAssets
            // 
            this.currentAssets.Location = new System.Drawing.Point(148, 51);
            this.currentAssets.Name = "currentAssets";
            this.currentAssets.Size = new System.Drawing.Size(100, 20);
            this.currentAssets.TabIndex = 4;
            this.currentAssets.TextChanged += new System.EventHandler(this.currentAssets_TextChanged);
            // 
            // liquidityRatiosInputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.currentCash);
            this.Controls.Add(this.currentInventory);
            this.Controls.Add(this.currentLiabilities);
            this.Controls.Add(this.currentAssets);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "liquidityRatiosInputForm";
            this.Text = "Liquidity ratios";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private numberTextbox currentAssets;
        private numberTextbox currentLiabilities;
        private numberTextbox currentInventory;
        private numberTextbox currentCash;
        private System.Windows.Forms.Button button1;
    }
}