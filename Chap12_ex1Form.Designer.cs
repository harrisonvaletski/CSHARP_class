namespace CHap12_excercise1WindowsFormsApplication2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TextBoxValue1 = new System.Windows.Forms.TextBox();
            this.TextBoxValue2 = new System.Windows.Forms.TextBox();
            this.ListBoxValue1 = new System.Windows.Forms.ListBox();
            this.ListBoxValue2 = new System.Windows.Forms.ListBox();
            this.ListBoxResult = new System.Windows.Forms.ListBox();
            this.Button = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Value1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(141, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Value2";
            // 
            // TextBoxValue1
            // 
            this.TextBoxValue1.Location = new System.Drawing.Point(55, 86);
            this.TextBoxValue1.Name = "TextBoxValue1";
            this.TextBoxValue1.Size = new System.Drawing.Size(43, 28);
            this.TextBoxValue1.TabIndex = 0;
            this.TextBoxValue1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TextBoxValue2
            // 
            this.TextBoxValue2.Location = new System.Drawing.Point(144, 86);
            this.TextBoxValue2.Name = "TextBoxValue2";
            this.TextBoxValue2.Size = new System.Drawing.Size(43, 28);
            this.TextBoxValue2.TabIndex = 1;
            this.TextBoxValue2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ListBoxValue1
            // 
            this.ListBoxValue1.FormattingEnabled = true;
            this.ListBoxValue1.ItemHeight = 22;
            this.ListBoxValue1.Location = new System.Drawing.Point(55, 139);
            this.ListBoxValue1.Name = "ListBoxValue1";
            this.ListBoxValue1.Size = new System.Drawing.Size(49, 92);
            this.ListBoxValue1.TabIndex = 4;
            // 
            // ListBoxValue2
            // 
            this.ListBoxValue2.FormattingEnabled = true;
            this.ListBoxValue2.ItemHeight = 22;
            this.ListBoxValue2.Location = new System.Drawing.Point(144, 139);
            this.ListBoxValue2.Name = "ListBoxValue2";
            this.ListBoxValue2.Size = new System.Drawing.Size(49, 92);
            this.ListBoxValue2.TabIndex = 5;
            // 
            // ListBoxResult
            // 
            this.ListBoxResult.FormattingEnabled = true;
            this.ListBoxResult.ItemHeight = 22;
            this.ListBoxResult.Location = new System.Drawing.Point(238, 139);
            this.ListBoxResult.Name = "ListBoxResult";
            this.ListBoxResult.Size = new System.Drawing.Size(49, 92);
            this.ListBoxResult.TabIndex = 6;
            // 
            // Button
            // 
            this.Button.BackColor = System.Drawing.Color.PapayaWhip;
            this.Button.Location = new System.Drawing.Point(125, 252);
            this.Button.Name = "Button";
            this.Button.Size = new System.Drawing.Size(87, 60);
            this.Button.TabIndex = 2;
            this.Button.Text = "Process Values";
            this.Button.UseVisualStyleBackColor = false;
            this.Button.Click += new System.EventHandler(this.Button_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(235, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "Product";
            // 
            // Form1
            // 
            this.AcceptButton = this.Button;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(426, 363);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Button);
            this.Controls.Add(this.ListBoxResult);
            this.Controls.Add(this.ListBoxValue2);
            this.Controls.Add(this.ListBoxValue1);
            this.Controls.Add(this.TextBoxValue2);
            this.Controls.Add(this.TextBoxValue1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Gray;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Number Processor";
            this.Load += new System.EventHandler(this.FrmNumberProcessor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextBoxValue1;
        private System.Windows.Forms.TextBox TextBoxValue2;
        private System.Windows.Forms.ListBox ListBoxValue1;
        private System.Windows.Forms.ListBox ListBoxValue2;
        private System.Windows.Forms.ListBox ListBoxResult;
        private System.Windows.Forms.Button Button;
        private System.Windows.Forms.Label label3;
    }
}

