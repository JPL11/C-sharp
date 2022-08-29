namespace EX3_Q3_Mortgage
{
    partial class Mortgage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Principal = new System.Windows.Forms.Label();
            this.PrincipalBox = new System.Windows.Forms.TextBox();
            this.Rate = new System.Windows.Forms.Label();
            this.RateBox = new System.Windows.Forms.TextBox();
            this.Time = new System.Windows.Forms.Label();
            this.TimeBox = new System.Windows.Forms.TextBox();
            this.MonthlyInstallments = new System.Windows.Forms.Button();
            this.Intro = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Principal
            // 
            this.Principal.AutoSize = true;
            this.Principal.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.Principal.Location = new System.Drawing.Point(319, 91);
            this.Principal.Name = "Principal";
            this.Principal.Size = new System.Drawing.Size(95, 20);
            this.Principal.TabIndex = 0;
            this.Principal.Text = "Principal ($): ";
            // 
            // PrincipalBox
            // 
            this.PrincipalBox.Location = new System.Drawing.Point(449, 84);
            this.PrincipalBox.Name = "PrincipalBox";
            this.PrincipalBox.Size = new System.Drawing.Size(125, 27);
            this.PrincipalBox.TabIndex = 1;
            this.PrincipalBox.TextChanged += new System.EventHandler(this.PrincipalBox_TextChanged);
            // 
            // Rate
            // 
            this.Rate.AutoSize = true;
            this.Rate.Location = new System.Drawing.Point(215, 135);
            this.Rate.Name = "Rate";
            this.Rate.Size = new System.Drawing.Size(199, 20);
            this.Rate.TabIndex = 2;
            this.Rate.Text = "Annual Percantage Rate (%): ";
            // 
            // RateBox
            // 
            this.RateBox.Location = new System.Drawing.Point(449, 135);
            this.RateBox.Name = "RateBox";
            this.RateBox.Size = new System.Drawing.Size(125, 27);
            this.RateBox.TabIndex = 3;
            this.RateBox.TextChanged += new System.EventHandler(this.RateBox_TextChanged);
            // 
            // Time
            // 
            this.Time.AutoSize = true;
            this.Time.Location = new System.Drawing.Point(288, 185);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(126, 20);
            this.Time.TabIndex = 4;
            this.Time.Text = "Number of Years: ";
            // 
            // TimeBox
            // 
            this.TimeBox.Location = new System.Drawing.Point(449, 182);
            this.TimeBox.Name = "TimeBox";
            this.TimeBox.Size = new System.Drawing.Size(125, 27);
            this.TimeBox.TabIndex = 5;
            this.TimeBox.TextChanged += new System.EventHandler(this.TimeBox_TextChanged);
            // 
            // MonthlyInstallments
            // 
            this.MonthlyInstallments.Location = new System.Drawing.Point(372, 272);
            this.MonthlyInstallments.Name = "MonthlyInstallments";
            this.MonthlyInstallments.Size = new System.Drawing.Size(94, 29);
            this.MonthlyInstallments.TabIndex = 6;
            this.MonthlyInstallments.Text = "Calculate";
            this.MonthlyInstallments.UseVisualStyleBackColor = true;
            this.MonthlyInstallments.Click += new System.EventHandler(this.MonthlyInstallments_Click);
            // 
            // Intro
            // 
            this.Intro.AutoSize = true;
            this.Intro.Location = new System.Drawing.Point(118, 21);
            this.Intro.Name = "Intro";
            this.Intro.Size = new System.Drawing.Size(550, 20);
            this.Intro.TabIndex = 7;
            this.Intro.Text = "Please enter the following values to calculate the estimated monthly installments" +
    ": ";
            // 
            // Mortgage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Intro);
            this.Controls.Add(this.MonthlyInstallments);
            this.Controls.Add(this.TimeBox);
            this.Controls.Add(this.Time);
            this.Controls.Add(this.RateBox);
            this.Controls.Add(this.Rate);
            this.Controls.Add(this.PrincipalBox);
            this.Controls.Add(this.Principal);
            this.Name = "Mortgage";
            this.Text = "Mortgage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label Principal;
        private TextBox PrincipalBox;
        private Label Rate;
        private TextBox RateBox;
        private Label Time;
        private TextBox TimeBox;
        private Button MonthlyInstallments;
        public Label Intro;
    }
}