namespace WindowsFormsApplication2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Question = new System.Windows.Forms.Label();
            this.Prompt = new System.Windows.Forms.Label();
            this.InputValue = new System.Windows.Forms.TextBox();
            this.Label = new System.Windows.Forms.Label();
            this.Answer = new System.Windows.Forms.Label();
            this.G = new System.Windows.Forms.Button();
            this.R = new System.Windows.Forms.Button();
            this.Message = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Question
            // 
            this.Question.AutoSize = true;
            this.Question.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Question.Location = new System.Drawing.Point(86, 162);
            this.Question.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Question.Name = "Question";
            this.Question.Size = new System.Drawing.Size(665, 29);
            this.Question.TabIndex = 0;
            this.Question.Text = "How quickly can you guess the random number?";
            // 
            // Prompt
            // 
            this.Prompt.AutoSize = true;
            this.Prompt.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Prompt.Location = new System.Drawing.Point(12, 66);
            this.Prompt.Name = "Prompt";
            this.Prompt.Size = new System.Drawing.Size(289, 25);
            this.Prompt.TabIndex = 1;
            this.Prompt.Text = "What number  ( 0 - 100 ) ?";
            // 
            // InputValue
            // 
            this.InputValue.Location = new System.Drawing.Point(326, 64);
            this.InputValue.Name = "InputValue";
            this.InputValue.Size = new System.Drawing.Size(328, 36);
            this.InputValue.TabIndex = 0;
            this.InputValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.Location = new System.Drawing.Point(12, 121);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(177, 29);
            this.Label.TabIndex = 3;
            this.Label.Text = "Guess Count:";
            // 
            // Answer
            // 
            this.Answer.AutoSize = true;
            this.Answer.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Answer.Location = new System.Drawing.Point(222, 121);
            this.Answer.Name = "Answer";
            this.Answer.Size = new System.Drawing.Size(30, 29);
            this.Answer.TabIndex = 4;
            this.Answer.Text = "0";
            this.Answer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // G
            // 
            this.G.BackColor = System.Drawing.Color.White;
            this.G.Font = new System.Drawing.Font("Verdana", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.G.ForeColor = System.Drawing.Color.Black;
            this.G.Location = new System.Drawing.Point(494, 106);
            this.G.Name = "G";
            this.G.Size = new System.Drawing.Size(160, 53);
            this.G.TabIndex = 1;
            this.G.Text = "Guess";
            this.G.UseVisualStyleBackColor = false;
            this.G.Click += new System.EventHandler(this.G_Click);
            // 
            // R
            // 
            this.R.BackColor = System.Drawing.Color.White;
            this.R.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.R.ForeColor = System.Drawing.Color.Black;
            this.R.Location = new System.Drawing.Point(326, 106);
            this.R.Name = "R";
            this.R.Size = new System.Drawing.Size(149, 53);
            this.R.TabIndex = 6;
            this.R.Text = "Reset";
            this.R.UseVisualStyleBackColor = false;
            this.R.Click += new System.EventHandler(this.R_Click);
            // 
            // Message
            // 
            this.Message.AutoSize = true;
            this.Message.Location = new System.Drawing.Point(30, 21);
            this.Message.Name = "Message";
            this.Message.Size = new System.Drawing.Size(0, 29);
            this.Message.TabIndex = 7;
            // 
            // Form1
            // 
            this.AcceptButton = this.G;
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(784, 200);
            this.Controls.Add(this.Message);
            this.Controls.Add(this.R);
            this.Controls.Add(this.G);
            this.Controls.Add(this.Answer);
            this.Controls.Add(this.Label);
            this.Controls.Add(this.InputValue);
            this.Controls.Add(this.Prompt);
            this.Controls.Add(this.Question);
            this.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Form1";
            this.Text = "Chapter 9 Exercise 10";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Question;
        private System.Windows.Forms.Label Prompt;
        private System.Windows.Forms.TextBox InputValue;
        private System.Windows.Forms.Label Label;
        private System.Windows.Forms.Label Answer;
        private System.Windows.Forms.Button G;
        private System.Windows.Forms.Button R;
        private System.Windows.Forms.Label Message;
    }
}

