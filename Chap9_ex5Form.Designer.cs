namespace ConsoleApplication25
{
    partial class Form1
    { 
        #region Windows Form Designer generated code


        /// Required designer variable.
    
        private System.ComponentModel.IContainer components = null;

        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
     

        private void InitializeComponent()
        {
            this.Output = new System.Windows.Forms.Label();
            this.Value1 = new System.Windows.Forms.Label();
            this.Value2 = new System.Windows.Forms.Label();
            this.x = new System.Windows.Forms.TextBox();
            this.y = new System.Windows.Forms.TextBox();
            this.m = new System.Windows.Forms.Button();
            this.a = new System.Windows.Forms.Button();
            this.r = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Output
            // 
            this.Output.AutoSize = true;
            this.Output.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Output.Location = new System.Drawing.Point(187, 243);
            this.Output.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(243, 31);
            this.Output.TabIndex = 0;
            this.Output.Text = "Simple Calculator";
            // 
            // Value1
            // 
            this.Value1.AutoSize = true;
            this.Value1.Location = new System.Drawing.Point(12, 113);
            this.Value1.Name = "Value1";
            this.Value1.Size = new System.Drawing.Size(111, 25);
            this.Value1.TabIndex = 1;
            this.Value1.Text = "First Value:";
            // 
            // Value2
            // 
            this.Value2.AutoSize = true;
            this.Value2.Location = new System.Drawing.Point(5, 174);
            this.Value2.Name = "Value2";
            this.Value2.Size = new System.Drawing.Size(142, 25);
            this.Value2.TabIndex = 2;
            this.Value2.Text = "Second Value:";
            // 
            // x
            // 
            this.x.Location = new System.Drawing.Point(153, 108);
            this.x.Name = "x";
            this.x.Size = new System.Drawing.Size(250, 30);
            this.x.TabIndex = 3;
            this.x.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // y
            // 
            this.y.Location = new System.Drawing.Point(153, 174);
            this.y.Name = "y";
            this.y.Size = new System.Drawing.Size(250, 30);
            this.y.TabIndex = 4;
            this.y.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // m
            // 
            this.m.Location = new System.Drawing.Point(10, 238);
            this.m.Name = "m";
            this.m.Size = new System.Drawing.Size(104, 36);
            this.m.TabIndex = 5;
            this.m.Text = "Multiply";
            this.m.UseVisualStyleBackColor = true;
            this.m.Click += new System.EventHandler(this.m_Click);
            // 
            // a
            // 
            this.a.Location = new System.Drawing.Point(120, 238);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(60, 36);
            this.a.TabIndex = 6;
            this.a.Text = "Add";
            this.a.UseVisualStyleBackColor = true;
            this.a.Click += new System.EventHandler(this.a_Click);
            // 
            // r
            // 
            this.r.AutoSize = true;
            this.r.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.r.Location = new System.Drawing.Point(28, 28);
            this.r.Name = "r";
            this.r.Size = new System.Drawing.Size(0, 29);
            this.r.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(431, 279);
            this.Controls.Add(this.r);
            this.Controls.Add(this.a);
            this.Controls.Add(this.m);
            this.Controls.Add(this.y);
            this.Controls.Add(this.x);
            this.Controls.Add(this.Value2);
            this.Controls.Add(this.Value1);
            this.Controls.Add(this.Output);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Calculator App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        
        // Clean up any resources being used.
        
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        private System.Windows.Forms.Label Output;
        private System.Windows.Forms.Label Value1;
        private System.Windows.Forms.Label Value2;
        private System.Windows.Forms.TextBox x;
        private System.Windows.Forms.TextBox y;
        private System.Windows.Forms.Button m;
        private System.Windows.Forms.Button a;
        private System.Windows.Forms.Label r;
       

        #endregion
    }
}

