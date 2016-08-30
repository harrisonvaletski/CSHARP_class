namespace ConsoleApplication6
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

       
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.theLabel = new System.Windows.Forms.Label();
            this.theTextBox = new System.Windows.Forms.TextBox();
            this.theButton = new System.Windows.Forms.Button();
            this.theNewLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // theLabel
            // 
            this.theLabel.AutoSize = true;
            this.theLabel.BackColor = System.Drawing.Color.DarkGray;
            this.theLabel.Location = new System.Drawing.Point(12, 158);
            this.theLabel.Name = "theLabel";
            this.theLabel.Size = new System.Drawing.Size(414, 25);
            this.theLabel.TabIndex = 0;
            this.theLabel.Text = "Type your name and click on the button";
            // 
            // theTextBox
            // 
            this.theTextBox.Location = new System.Drawing.Point(119, 100);
            this.theTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.theTextBox.Name = "theTextBox";
            this.theTextBox.Size = new System.Drawing.Size(267, 32);
            this.theTextBox.TabIndex = 1;
            // 
            // theButton
            // 
            this.theButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.theButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.theButton.Location = new System.Drawing.Point(28, 94);
            this.theButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.theButton.Name = "theButton";
            this.theButton.Size = new System.Drawing.Size(67, 42);
            this.theButton.TabIndex = 2;
            this.theButton.Text = "OK";
            this.theButton.UseVisualStyleBackColor = false;
            this.theButton.Click += new System.EventHandler(this.theButton_Click);
            // 
            // theNewLabel
            // 
            this.theNewLabel.AutoSize = true;
            this.theNewLabel.Location = new System.Drawing.Point(23, 27);
            this.theNewLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.theNewLabel.Name = "theNewLabel";
            this.theNewLabel.Size = new System.Drawing.Size(0, 25);
            this.theNewLabel.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(456, 192);
            this.Controls.Add(this.theNewLabel);
            this.Controls.Add(this.theButton);
            this.Controls.Add(this.theTextBox);
            this.Controls.Add(this.theLabel);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Yellow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "NameRetreivalApp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label theLabel;
        private System.Windows.Forms.TextBox theTextBox;
        private System.Windows.Forms.Button theButton;
        private System.Windows.Forms.Label theNewLabel;
    }
}
