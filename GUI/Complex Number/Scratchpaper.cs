using System;
using System.Windows.Forms;

namespace Scratchpaper
{
    public partial class Scratchpaper : Form
    {
        public Scratchpaper()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void firstReal_ValueChanged(object sender, EventArgs e)
        {

        }

        private void firstImaginary_ValueChanged(object sender, EventArgs e)
        {

        }

        private void secondReal_ValueChanged(object sender, EventArgs e)
        {

        }

        private void secondImaginary_ValueChanged(object sender, EventArgs e)
        {

        }

        private void buttonSum_Click(object sender, EventArgs e)
        {
            Complex a = new Complex(), b = new Complex();
            a.SetComplex((double)firstReal.Value, (double)firstImaginary.Value);
            b.SetComplex((double)secondImaginary.Value, (double)secondReal.Value);
            a.add(b);
            listBox1.Items.Add("The sum of the first and second complex numbers is " + a.toString());
        }

        private void buttonDifference_Click(object sender, EventArgs e)
        {
            Complex a = new Complex(), b = new Complex();
            a.SetComplex((double)firstReal.Value, (double)firstImaginary.Value);
            b.SetComplex((double)secondImaginary.Value, (double)secondReal.Value);
            a.sub(b);
            listBox1.Items.Add("The difference of the first and second complex numbers is " + a.toString());
        }

        private void buttonProduct_Click(object sender, EventArgs e)
        {
            Complex a = new Complex(), b = new Complex();
            a.SetComplex((double)firstReal.Value, (double)firstImaginary.Value);
            b.SetComplex((double)secondImaginary.Value, (double)secondReal.Value);
            listBox1.Items.Add("The product of the first and second complex numbers is " + a.mul(b).toString());
        }
        private void buttonQuotient_Click(object sender, EventArgs e)
        {
            Complex a = new Complex(), b = new Complex();
            a.SetComplex((double)firstReal.Value, (double)firstImaginary.Value);
            b.SetComplex((double)secondImaginary.Value, (double)secondReal.Value);
            listBox1.Items.Add("The quotient of the first and second complex numbers is " + a.div(b).toString());
        }

        private void buttonPolar_Click(object sender, EventArgs e)
        {
            Complex a = new Complex(), b = new Complex();
            a.SetComplex((double)firstReal.Value, (double)firstImaginary.Value);
            b.SetComplex((double)secondImaginary.Value, (double)secondReal.Value);
            listBox1.Items.Add("The first complex number converted to polar form is " + a.polarForm());
        }

        private void buttonPower_Click(object sender, EventArgs e)
        {
            Complex a = new Complex(), b = new Complex();
            a.SetComplex((double)firstReal.Value, (double)firstImaginary.Value);
            b.SetComplex((double)secondImaginary.Value, (double)secondReal.Value);
            listBox1.Items.Add("The first complex number raised to the power of " + powerInput.Value + " is " + a.power((double)powerInput.Value));
        }

        private void powerInput_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
