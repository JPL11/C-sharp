namespace EX3_Q2_Programming
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (InputTextBox.Text == string.Empty) // Checking for empty values in input textbox
            {
                MessageBox.Show("Nothing to clear", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                InputTextBox.Text = string.Empty;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (InputTextBox.Text == string.Empty) // Checking for empty values in input textbox
            {
                MessageBox.Show("You have typed nothing", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show(InputTextBox.Text, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}