namespace C07_P01
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
            this.OutputListbox = new System.Windows.Forms.ListBox();
            this.TotalTextBox = new System.Windows.Forms.TextBox();
            this.AvgTextBox = new System.Windows.Forms.TextBox();
            this.ExitButton = new System.Windows.Forms.Button();
            this.GetSalesButton = new System.Windows.Forms.Button();
            this.AvgTextLabel = new System.Windows.Forms.Label();
            this.TotalTextLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // OutputListbox
            // 
            this.OutputListbox.FormattingEnabled = true;
            this.OutputListbox.Location = new System.Drawing.Point(24, 8);
            this.OutputListbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.OutputListbox.Name = "OutputListbox";
            this.OutputListbox.Size = new System.Drawing.Size(151, 108);
            this.OutputListbox.TabIndex = 0;
            // 
            // TotalTextBox
            // 
            this.TotalTextBox.Location = new System.Drawing.Point(92, 173);
            this.TotalTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TotalTextBox.Name = "TotalTextBox";
            this.TotalTextBox.Size = new System.Drawing.Size(68, 20);
            this.TotalTextBox.TabIndex = 1;
            // 
            // AvgTextBox
            // 
            this.AvgTextBox.Location = new System.Drawing.Point(92, 131);
            this.AvgTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AvgTextBox.Name = "AvgTextBox";
            this.AvgTextBox.Size = new System.Drawing.Size(68, 20);
            this.AvgTextBox.TabIndex = 2;
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(11, 201);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(59, 35);
            this.ExitButton.TabIndex = 3;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // GetSalesButton
            // 
            this.GetSalesButton.Location = new System.Drawing.Point(131, 201);
            this.GetSalesButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GetSalesButton.Name = "GetSalesButton";
            this.GetSalesButton.Size = new System.Drawing.Size(59, 35);
            this.GetSalesButton.TabIndex = 4;
            this.GetSalesButton.Text = "Get Sales";
            this.GetSalesButton.UseVisualStyleBackColor = true;
            this.GetSalesButton.Click += new System.EventHandler(this.GetSalesButton_Click);
            // 
            // AvgTextLabel
            // 
            this.AvgTextLabel.AutoSize = true;
            this.AvgTextLabel.Location = new System.Drawing.Point(8, 134);
            this.AvgTextLabel.Name = "AvgTextLabel";
            this.AvgTextLabel.Size = new System.Drawing.Size(79, 13);
            this.AvgTextLabel.TabIndex = 5;
            this.AvgTextLabel.Text = "Average Sales:";
            // 
            // TotalTextLabel
            // 
            this.TotalTextLabel.AutoSize = true;
            this.TotalTextLabel.Location = new System.Drawing.Point(24, 176);
            this.TotalTextLabel.Name = "TotalTextLabel";
            this.TotalTextLabel.Size = new System.Drawing.Size(66, 13);
            this.TotalTextLabel.TabIndex = 6;
            this.TotalTextLabel.Text = "Total Sales :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(198, 243);
            this.Controls.Add(this.TotalTextLabel);
            this.Controls.Add(this.AvgTextLabel);
            this.Controls.Add(this.GetSalesButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.AvgTextBox);
            this.Controls.Add(this.TotalTextBox);
            this.Controls.Add(this.OutputListbox);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Sales Display";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox OutputListbox;
        private System.Windows.Forms.TextBox TotalTextBox;
        private System.Windows.Forms.TextBox AvgTextBox;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button GetSalesButton;
        private System.Windows.Forms.Label AvgTextLabel;
        private System.Windows.Forms.Label TotalTextLabel;
    }
}

