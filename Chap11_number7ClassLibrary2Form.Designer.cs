namespace Bank
{
    partial class BanksForm
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
            this.cmboType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lstBxCheck = new System.Windows.Forms.ListBox();
            this.lstBxSave = new System.Windows.Forms.ListBox();
            this.lblCustomers = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(87, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Display Account Details";
            // 
            // cmboType
            // 
            this.cmboType.FormattingEnabled = true;
            this.cmboType.Items.AddRange(new object[] {
            "Savings",
            "Checking"});
            this.cmboType.Location = new System.Drawing.Point(23, 100);
            this.cmboType.Name = "cmboType";
            this.cmboType.Size = new System.Drawing.Size(121, 28);
            this.cmboType.TabIndex = 1;
            this.cmboType.SelectedIndexChanged += new System.EventHandler(this.cmboTypeOfAccount_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Type of Account:";
            // 
            // lstBxCheck
            // 
            this.lstBxCheck.FormattingEnabled = true;
            this.lstBxCheck.ItemHeight = 20;
            this.lstBxCheck.Location = new System.Drawing.Point(187, 100);
            this.lstBxCheck.Name = "lstBxCheck";
            this.lstBxCheck.Size = new System.Drawing.Size(120, 84);
            this.lstBxCheck.TabIndex = 3;
            this.lstBxCheck.Visible = false;
            this.lstBxCheck.SelectedIndexChanged += new System.EventHandler(this.lstBxChecking_SelectedIndexChanged);
            // 
            // lstBxSave
            // 
            this.lstBxSave.FormattingEnabled = true;
            this.lstBxSave.ItemHeight = 20;
            this.lstBxSave.Location = new System.Drawing.Point(187, 100);
            this.lstBxSave.Name = "lstBxSave";
            this.lstBxSave.Size = new System.Drawing.Size(120, 84);
            this.lstBxSave.TabIndex = 4;
            this.lstBxSave.Visible = false;
            this.lstBxSave.SelectedIndexChanged += new System.EventHandler(this.lstBxSavings_SelectedIndexChanged);
            // 
            // lblCustomers
            // 
            this.lblCustomers.AutoSize = true;
            this.lblCustomers.Location = new System.Drawing.Point(201, 79);
            this.lblCustomers.Name = "lblCustomers";
            this.lblCustomers.Size = new System.Drawing.Size(91, 20);
            this.lblCustomers.TabIndex = 5;
            this.lblCustomers.Text = "Customers";
            this.lblCustomers.Visible = false;
            // 
            // BanksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(379, 322);
            this.Controls.Add(this.lblCustomers);
            this.Controls.Add(this.lstBxSave);
            this.Controls.Add(this.lstBxCheck);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmboType);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "BanksForm";
            this.Text = "C...&...Z Banking";
            this.Load += new System.EventHandler(this.BankingForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmboType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstBxCheck;
        private System.Windows.Forms.ListBox lstBxSave;
        private System.Windows.Forms.Label lblCustomers;
    }
}

