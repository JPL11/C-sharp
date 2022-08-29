
namespace Scratchpaper
{
    partial class Scratchpaper
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
            this.components = new System.ComponentModel.Container();
            this.firstReal = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.firstImaginary = new System.Windows.Forms.NumericUpDown();
            this.secondReal = new System.Windows.Forms.NumericUpDown();
            this.secondImaginary = new System.Windows.Forms.NumericUpDown();
            this.powerInput = new System.Windows.Forms.NumericUpDown();
            this.buttonPower = new System.Windows.Forms.Button();
            this.buttonSum = new System.Windows.Forms.Button();
            this.buttonDifference = new System.Windows.Forms.Button();
            this.buttonProduct = new System.Windows.Forms.Button();
            this.buttonQuotient = new System.Windows.Forms.Button();
            this.buttonPolar = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.firstReal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstImaginary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondReal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondImaginary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.powerInput)).BeginInit();
            this.SuspendLayout();
            // 
            // firstReal
            // 
            this.firstReal.DecimalPlaces = 1;
            this.firstReal.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.firstReal.Location = new System.Drawing.Point(10, 45);
            this.firstReal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.firstReal.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.firstReal.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.firstReal.Name = "firstReal";
            this.firstReal.Size = new System.Drawing.Size(101, 31);
            this.firstReal.TabIndex = 2;
            this.firstReal.ValueChanged += new System.EventHandler(this.firstReal_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(119, 47);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Real";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(319, 47);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Imaginary";
            this.label3.Click += new System.EventHandler(this.label2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(819, 47);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 25);
            this.label6.TabIndex = 10;
            this.label6.Text = "Imaginary";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(609, 47);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Real";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "First Complex Number";
            this.label1.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(500, 10);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(216, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Second Complex Number";
            // 
            // firstImaginary
            // 
            this.firstImaginary.DecimalPlaces = 1;
            this.firstImaginary.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.firstImaginary.Location = new System.Drawing.Point(210, 45);
            this.firstImaginary.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.firstImaginary.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.firstImaginary.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.firstImaginary.Name = "firstImaginary";
            this.firstImaginary.Size = new System.Drawing.Size(101, 31);
            this.firstImaginary.TabIndex = 4;
            this.firstImaginary.ValueChanged += new System.EventHandler(this.firstImaginary_ValueChanged);
            // 
            // secondReal
            // 
            this.secondReal.DecimalPlaces = 1;
            this.secondReal.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.secondReal.Location = new System.Drawing.Point(710, 45);
            this.secondReal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.secondReal.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.secondReal.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.secondReal.Name = "secondReal";
            this.secondReal.Size = new System.Drawing.Size(101, 31);
            this.secondReal.TabIndex = 9;
            this.secondReal.ValueChanged += new System.EventHandler(this.secondImaginary_ValueChanged);
            // 
            // secondImaginary
            // 
            this.secondImaginary.DecimalPlaces = 1;
            this.secondImaginary.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.secondImaginary.Location = new System.Drawing.Point(500, 45);
            this.secondImaginary.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.secondImaginary.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.secondImaginary.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.secondImaginary.Name = "secondImaginary";
            this.secondImaginary.Size = new System.Drawing.Size(101, 31);
            this.secondImaginary.TabIndex = 7;
            this.secondImaginary.ValueChanged += new System.EventHandler(this.secondReal_ValueChanged);
            // 
            // powerInput
            // 
            this.powerInput.Location = new System.Drawing.Point(851, 90);
            this.powerInput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.powerInput.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.powerInput.Name = "powerInput";
            this.powerInput.Size = new System.Drawing.Size(51, 31);
            this.powerInput.TabIndex = 17;
            this.powerInput.ValueChanged += new System.EventHandler(this.powerInput_ValueChanged);
            // 
            // buttonPower
            // 
            this.buttonPower.Location = new System.Drawing.Point(750, 90);
            this.buttonPower.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonPower.Name = "buttonPower";
            this.buttonPower.Size = new System.Drawing.Size(101, 31);
            this.buttonPower.TabIndex = 16;
            this.buttonPower.Text = "Power";
            this.toolTip1.SetToolTip(this.buttonPower, "Raise the first number to the integer entered on the right");
            this.buttonPower.UseVisualStyleBackColor = true;
            this.buttonPower.Click += new System.EventHandler(this.buttonPower_Click);
            // 
            // buttonSum
            // 
            this.buttonSum.Location = new System.Drawing.Point(10, 90);
            this.buttonSum.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonSum.Name = "buttonSum";
            this.buttonSum.Size = new System.Drawing.Size(101, 31);
            this.buttonSum.TabIndex = 11;
            this.buttonSum.Text = "Sum";
            this.toolTip1.SetToolTip(this.buttonSum, "Add the first and second numbers");
            this.buttonSum.UseVisualStyleBackColor = true;
            this.buttonSum.Click += new System.EventHandler(this.buttonSum_Click);
            // 
            // buttonDifference
            // 
            this.buttonDifference.AccessibleName = "";
            this.buttonDifference.Location = new System.Drawing.Point(150, 90);
            this.buttonDifference.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonDifference.Name = "buttonDifference";
            this.buttonDifference.Size = new System.Drawing.Size(101, 31);
            this.buttonDifference.TabIndex = 12;
            this.buttonDifference.Text = "Difference";
            this.toolTip1.SetToolTip(this.buttonDifference, "Subtract the second number from the first");
            this.buttonDifference.UseVisualStyleBackColor = true;
            this.buttonDifference.Click += new System.EventHandler(this.buttonDifference_Click);
            // 
            // buttonProduct
            // 
            this.buttonProduct.Location = new System.Drawing.Point(300, 90);
            this.buttonProduct.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonProduct.Name = "buttonProduct";
            this.buttonProduct.Size = new System.Drawing.Size(101, 31);
            this.buttonProduct.TabIndex = 13;
            this.buttonProduct.Text = "Product";
            this.toolTip1.SetToolTip(this.buttonProduct, "Multiply the first and second numbers");
            this.buttonProduct.UseVisualStyleBackColor = true;
            this.buttonProduct.Click += new System.EventHandler(this.buttonProduct_Click);
            // 
            // buttonQuotient
            // 
            this.buttonQuotient.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
            this.buttonQuotient.Location = new System.Drawing.Point(450, 90);
            this.buttonQuotient.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonQuotient.Name = "buttonQuotient";
            this.buttonQuotient.Size = new System.Drawing.Size(101, 31);
            this.buttonQuotient.TabIndex = 14;
            this.buttonQuotient.Text = "Quotient";
            this.toolTip1.SetToolTip(this.buttonQuotient, "Divide the first number by the second");
            this.buttonQuotient.UseVisualStyleBackColor = true;
            this.buttonQuotient.Click += new System.EventHandler(this.buttonQuotient_Click);
            // 
            // buttonPolar
            // 
            this.buttonPolar.Location = new System.Drawing.Point(600, 90);
            this.buttonPolar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonPolar.Name = "buttonPolar";
            this.buttonPolar.Size = new System.Drawing.Size(101, 31);
            this.buttonPolar.TabIndex = 15;
            this.buttonPolar.Text = "Polar";
            this.toolTip1.SetToolTip(this.buttonPolar, "Convert the first number into polar form");
            this.buttonPolar.UseVisualStyleBackColor = true;
            this.buttonPolar.Click += new System.EventHandler(this.buttonPolar_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Location = new System.Drawing.Point(10, 140);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(900, 179);
            this.listBox1.TabIndex = 18;
            // 
            // Scratchpaper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 344);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.buttonPolar);
            this.Controls.Add(this.buttonQuotient);
            this.Controls.Add(this.buttonProduct);
            this.Controls.Add(this.buttonDifference);
            this.Controls.Add(this.buttonSum);
            this.Controls.Add(this.buttonPower);
            this.Controls.Add(this.powerInput);
            this.Controls.Add(this.secondImaginary);
            this.Controls.Add(this.secondReal);
            this.Controls.Add(this.firstImaginary);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.firstReal);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Scratchpaper";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.firstReal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstImaginary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondReal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondImaginary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.powerInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown firstReal;
        private System.Windows.Forms.NumericUpDown firstImaginary;
        private System.Windows.Forms.NumericUpDown secondReal;
        private System.Windows.Forms.NumericUpDown secondImaginary;
        private System.Windows.Forms.NumericUpDown powerInput;
        private System.Windows.Forms.Button buttonSum;
        private System.Windows.Forms.Button buttonDifference;
        private System.Windows.Forms.Button buttonProduct;
        private System.Windows.Forms.Button buttonQuotient;
        private System.Windows.Forms.Button buttonPolar;
        private System.Windows.Forms.Button buttonPower;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

