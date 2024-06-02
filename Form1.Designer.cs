namespace CalculatorBusiness
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.ratioTypeCombobox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ratio_checkbox_panel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.profitabiliy_checkboxes = new System.Windows.Forms.Panel();
            this.checkBox_grossMargin = new System.Windows.Forms.CheckBox();
            this.checkBox_operatingMargin = new System.Windows.Forms.CheckBox();
            this.checkBox_netProfitMargin = new System.Windows.Forms.CheckBox();
            this.liquidity_checkboxes = new System.Windows.Forms.Panel();
            this.checkBox_cashRatio = new System.Windows.Forms.CheckBox();
            this.checkBox_quickRatio = new System.Windows.Forms.CheckBox();
            this.checkBox_currentRatio = new System.Windows.Forms.CheckBox();
            this.leverage_checkboxes = new System.Windows.Forms.Panel();
            this.netDebt = new System.Windows.Forms.CheckBox();
            this.debtCapital = new System.Windows.Forms.CheckBox();
            this.debtequity = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.debtToEnterprise = new System.Windows.Forms.CheckBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.ratio_checkbox_panel.SuspendLayout();
            this.profitabiliy_checkboxes.SuspendLayout();
            this.liquidity_checkboxes.SuspendLayout();
            this.leverage_checkboxes.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(748, 368);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.ratio_checkbox_panel);
            this.tabPage1.Controls.Add(this.ratioTypeCombobox);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(740, 342);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Ratios";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(740, 342);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Future/Present";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(740, 342);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Budgeting";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // ratioTypeCombobox
            // 
            this.ratioTypeCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ratioTypeCombobox.FormattingEnabled = true;
            this.ratioTypeCombobox.Items.AddRange(new object[] {
            "No selection made",
            "Type 1: Profitability Ratios include the Gross Margin, the Operating Margin, and " +
                "the Net Profit Margin",
            "Type 2: Liquidity Ratios include the Current Ratio, the Quick Ratio and the Cash " +
                "Ratio ",
            "Type 3: Leverage Ratios include the Debt-to-Equity Ratio, and Debt-to-Capital Rat" +
                "io ",
            "Type 4: Operating Ratios include the Return on Equity Ratio and the Return on Ass" +
                "ets Ratio"});
            this.ratioTypeCombobox.Location = new System.Drawing.Point(71, 51);
            this.ratioTypeCombobox.Name = "ratioTypeCombobox";
            this.ratioTypeCombobox.Size = new System.Drawing.Size(601, 21);
            this.ratioTypeCombobox.TabIndex = 3;
            this.ratioTypeCombobox.SelectedIndexChanged += new System.EventHandler(this.ratioTypeCombobox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select ratio type from the list below";
            // 
            // ratio_checkbox_panel
            // 
            this.ratio_checkbox_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ratio_checkbox_panel.Controls.Add(this.leverage_checkboxes);
            this.ratio_checkbox_panel.Controls.Add(this.liquidity_checkboxes);
            this.ratio_checkbox_panel.Controls.Add(this.profitabiliy_checkboxes);
            this.ratio_checkbox_panel.Controls.Add(this.label2);
            this.ratio_checkbox_panel.Location = new System.Drawing.Point(6, 106);
            this.ratio_checkbox_panel.Name = "ratio_checkbox_panel";
            this.ratio_checkbox_panel.Size = new System.Drawing.Size(726, 200);
            this.ratio_checkbox_panel.TabIndex = 4;
            this.ratio_checkbox_panel.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Select the required ratios";
            // 
            // profitabiliy_checkboxes
            // 
            this.profitabiliy_checkboxes.Controls.Add(this.checkBox_netProfitMargin);
            this.profitabiliy_checkboxes.Controls.Add(this.checkBox_operatingMargin);
            this.profitabiliy_checkboxes.Controls.Add(this.checkBox_grossMargin);
            this.profitabiliy_checkboxes.Location = new System.Drawing.Point(20, 47);
            this.profitabiliy_checkboxes.Name = "profitabiliy_checkboxes";
            this.profitabiliy_checkboxes.Size = new System.Drawing.Size(121, 132);
            this.profitabiliy_checkboxes.TabIndex = 1;
            // 
            // checkBox_grossMargin
            // 
            this.checkBox_grossMargin.AutoSize = true;
            this.checkBox_grossMargin.Location = new System.Drawing.Point(4, 4);
            this.checkBox_grossMargin.Name = "checkBox_grossMargin";
            this.checkBox_grossMargin.Size = new System.Drawing.Size(87, 17);
            this.checkBox_grossMargin.TabIndex = 0;
            this.checkBox_grossMargin.Text = "Gross margin";
            this.checkBox_grossMargin.UseVisualStyleBackColor = true;
            // 
            // checkBox_operatingMargin
            // 
            this.checkBox_operatingMargin.AutoSize = true;
            this.checkBox_operatingMargin.Location = new System.Drawing.Point(4, 28);
            this.checkBox_operatingMargin.Name = "checkBox_operatingMargin";
            this.checkBox_operatingMargin.Size = new System.Drawing.Size(106, 17);
            this.checkBox_operatingMargin.TabIndex = 1;
            this.checkBox_operatingMargin.Text = "Operating margin";
            this.checkBox_operatingMargin.UseVisualStyleBackColor = true;
            // 
            // checkBox_netProfitMargin
            // 
            this.checkBox_netProfitMargin.AutoSize = true;
            this.checkBox_netProfitMargin.Location = new System.Drawing.Point(4, 52);
            this.checkBox_netProfitMargin.Name = "checkBox_netProfitMargin";
            this.checkBox_netProfitMargin.Size = new System.Drawing.Size(103, 17);
            this.checkBox_netProfitMargin.TabIndex = 2;
            this.checkBox_netProfitMargin.Text = "Net profit margin";
            this.checkBox_netProfitMargin.UseVisualStyleBackColor = true;
            // 
            // liquidity_checkboxes
            // 
            this.liquidity_checkboxes.Controls.Add(this.checkBox_cashRatio);
            this.liquidity_checkboxes.Controls.Add(this.checkBox_quickRatio);
            this.liquidity_checkboxes.Controls.Add(this.checkBox_currentRatio);
            this.liquidity_checkboxes.Location = new System.Drawing.Point(147, 47);
            this.liquidity_checkboxes.Name = "liquidity_checkboxes";
            this.liquidity_checkboxes.Size = new System.Drawing.Size(121, 132);
            this.liquidity_checkboxes.TabIndex = 2;
            this.liquidity_checkboxes.Paint += new System.Windows.Forms.PaintEventHandler(this.liquidity_checkboxes_Paint);
            // 
            // checkBox_cashRatio
            // 
            this.checkBox_cashRatio.AutoSize = true;
            this.checkBox_cashRatio.Location = new System.Drawing.Point(4, 52);
            this.checkBox_cashRatio.Name = "checkBox_cashRatio";
            this.checkBox_cashRatio.Size = new System.Drawing.Size(73, 17);
            this.checkBox_cashRatio.TabIndex = 2;
            this.checkBox_cashRatio.Text = "Cash ratio";
            this.checkBox_cashRatio.UseVisualStyleBackColor = true;
            // 
            // checkBox_quickRatio
            // 
            this.checkBox_quickRatio.AutoSize = true;
            this.checkBox_quickRatio.Location = new System.Drawing.Point(4, 28);
            this.checkBox_quickRatio.Name = "checkBox_quickRatio";
            this.checkBox_quickRatio.Size = new System.Drawing.Size(77, 17);
            this.checkBox_quickRatio.TabIndex = 1;
            this.checkBox_quickRatio.Text = "Quick ratio";
            this.checkBox_quickRatio.UseVisualStyleBackColor = true;
            // 
            // checkBox_currentRatio
            // 
            this.checkBox_currentRatio.AutoSize = true;
            this.checkBox_currentRatio.Location = new System.Drawing.Point(4, 4);
            this.checkBox_currentRatio.Name = "checkBox_currentRatio";
            this.checkBox_currentRatio.Size = new System.Drawing.Size(83, 17);
            this.checkBox_currentRatio.TabIndex = 0;
            this.checkBox_currentRatio.Text = "Current ratio";
            this.checkBox_currentRatio.UseVisualStyleBackColor = true;
            // 
            // leverage_checkboxes
            // 
            this.leverage_checkboxes.Controls.Add(this.debtToEnterprise);
            this.leverage_checkboxes.Controls.Add(this.netDebt);
            this.leverage_checkboxes.Controls.Add(this.debtCapital);
            this.leverage_checkboxes.Controls.Add(this.debtequity);
            this.leverage_checkboxes.Location = new System.Drawing.Point(274, 47);
            this.leverage_checkboxes.Name = "leverage_checkboxes";
            this.leverage_checkboxes.Size = new System.Drawing.Size(166, 132);
            this.leverage_checkboxes.TabIndex = 3;
            this.leverage_checkboxes.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // netDebt
            // 
            this.netDebt.AutoSize = true;
            this.netDebt.Location = new System.Drawing.Point(4, 52);
            this.netDebt.Name = "netDebt";
            this.netDebt.Size = new System.Drawing.Size(69, 17);
            this.netDebt.TabIndex = 2;
            this.netDebt.Text = "Net Debt";
            this.netDebt.UseVisualStyleBackColor = true;
            // 
            // debtCapital
            // 
            this.debtCapital.AutoSize = true;
            this.debtCapital.Location = new System.Drawing.Point(4, 28);
            this.debtCapital.Name = "debtCapital";
            this.debtCapital.Size = new System.Drawing.Size(106, 17);
            this.debtCapital.TabIndex = 1;
            this.debtCapital.Text = "Debt-capital ratio";
            this.debtCapital.UseVisualStyleBackColor = true;
            // 
            // debtequity
            // 
            this.debtequity.AutoSize = true;
            this.debtequity.Location = new System.Drawing.Point(4, 4);
            this.debtequity.Name = "debtequity";
            this.debtequity.Size = new System.Drawing.Size(109, 17);
            this.debtequity.TabIndex = 0;
            this.debtequity.Text = "Debt-Equity Ratio";
            this.debtequity.UseVisualStyleBackColor = true;
            this.debtequity.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(657, 311);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // debtToEnterprise
            // 
            this.debtToEnterprise.AutoSize = true;
            this.debtToEnterprise.Location = new System.Drawing.Point(4, 75);
            this.debtToEnterprise.Name = "debtToEnterprise";
            this.debtToEnterprise.Size = new System.Drawing.Size(162, 17);
            this.debtToEnterprise.TabIndex = 3;
            this.debtToEnterprise.Text = "Debt-to-enterprise value ratio";
            this.debtToEnterprise.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 368);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Business calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ratio_checkbox_panel.ResumeLayout(false);
            this.ratio_checkbox_panel.PerformLayout();
            this.profitabiliy_checkboxes.ResumeLayout(false);
            this.profitabiliy_checkboxes.PerformLayout();
            this.liquidity_checkboxes.ResumeLayout(false);
            this.liquidity_checkboxes.PerformLayout();
            this.leverage_checkboxes.ResumeLayout(false);
            this.leverage_checkboxes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ComboBox ratioTypeCombobox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel ratio_checkbox_panel;
        private System.Windows.Forms.Panel profitabiliy_checkboxes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox_netProfitMargin;
        private System.Windows.Forms.CheckBox checkBox_operatingMargin;
        private System.Windows.Forms.CheckBox checkBox_grossMargin;
        private System.Windows.Forms.Panel liquidity_checkboxes;
        private System.Windows.Forms.CheckBox checkBox_cashRatio;
        private System.Windows.Forms.CheckBox checkBox_quickRatio;
        private System.Windows.Forms.CheckBox checkBox_currentRatio;
        private System.Windows.Forms.Panel leverage_checkboxes;
        private System.Windows.Forms.CheckBox netDebt;
        private System.Windows.Forms.CheckBox debtCapital;
        private System.Windows.Forms.CheckBox debtequity;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox debtToEnterprise;
    }
}

