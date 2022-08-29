using System;
using System.Drawing;
using System.Windows.Forms;

namespace ScratchpaperForms
{
    // Form uses Tabs and RadioButtons to display various font settings
    public partial class UsingTabsForm : Form
    {
        // constructor
        public UsingTabsForm()
        {
            InitializeComponent();
        } // end constructor

        // event handler for Black RadioButton
        private void blackRadioButton_CheckedChanged(
           object sender, EventArgs e)
        {
            displayLabel.ForeColor = Color.Black; // change color to black 
        } // end method blackRadioButton_CheckedChanged

        // event handler for Red RadioButton
        private void redRadioButton_CheckedChanged(
           object sender, EventArgs e)
        {
            displayLabel.ForeColor = Color.Red; // change color to red
        } // end method redRadioButton_CheckedChanged

        // event handler for Green RadioButton
        private void greenRadioButton_CheckedChanged(
           object sender, EventArgs e)
        {
            displayLabel.ForeColor = Color.Green; // change color to green
        } // end method greenRadioButton_CheckedChanged

        // event handler for 12 point RadioButton
        private void blueRadioButton_CheckedChanged(
   object sender, EventArgs e)
        {
            displayLabel.ForeColor = Color.Blue; // change color to blue
        } // end method blueRadioButton_CheckedChanged

        // event handler for 12 point RadioButton
        private void yellowRadioButton_CheckedChanged(
   object sender, EventArgs e)
        {
            displayLabel.ForeColor = Color.Yellow; // change color to yellow
        } // end method yellowRadioButton_CheckedChanged

        // event handler for 12 point RadioButton
        private void orangeRadioButton_CheckedChanged(
   object sender, EventArgs e)
        {
            displayLabel.ForeColor = Color.Orange; // change color to orange
        } // end method orangeRadioButton_CheckedChanged

        // event handler for 12 point RadioButton
        private void purpleRadioButton_CheckedChanged(
   object sender, EventArgs e)
        {
            displayLabel.ForeColor = Color.Purple; // change color to purple
        } // end method purpleRadioButton_CheckedChanged

        // event handler for 12 point RadioButton
        private void size12RadioButton_CheckedChanged(
           object sender, EventArgs e)
        {
            // change font size to 12
            displayLabel.Font = new Font(displayLabel.Font.Name, 12);
        } // end method size12RadioButton_CheckedChanged

        // event handler for 16 point RadioButton
        private void size16RadioButton_CheckedChanged(
           object sender, EventArgs e)
        {
            // change font size to 16
            displayLabel.Font = new Font(displayLabel.Font.Name, 16);
        } // end method size16RadioButton_CheckedChanged

        // event handler for 20 point RadioButton
        private void size20RadioButton_CheckedChanged(
           object sender, EventArgs e)
        {
            // change font size to 20
            displayLabel.Font = new Font(displayLabel.Font.Name, 20);
        } // end method size20RadioButton_CheckedChanged

        // event handler for  Hello! RadioButton
        private void size24RadioButton_CheckedChanged(
   object sender, EventArgs e)
        {
            // change font size to 20
            displayLabel.Font = new Font(displayLabel.Font.Name, 24);
        } // end method size24RadioButton_CheckedChanged

        // event handler for  Hello! RadioButton
        private void size28RadioButton_CheckedChanged(
   object sender, EventArgs e)
        {
            // change font size to 20
            displayLabel.Font = new Font(displayLabel.Font.Name, 28);
        } // end method size28RadioButton_CheckedChanged

        // event handler for  Hello! RadioButton
        private void size32RadioButton_CheckedChanged(
   object sender, EventArgs e)
        {
            // change font size to 20
            displayLabel.Font = new Font(displayLabel.Font.Name, 32);
        } // end method size32RadioButton_CheckedChanged

        // event handler for  Hello! RadioButton
        private void size36RadioButton_CheckedChanged(
   object sender, EventArgs e)
        {
            // change font size to 20
            displayLabel.Font = new Font(displayLabel.Font.Name, 36);
        } // end method size36RadioButton_CheckedChanged

        // event handler for  Hello! RadioButton
        private void helloRadioButton_CheckedChanged(
           object sender, EventArgs e)
        {
            displayLabel.Text = "Hello!"; // change text to Hello!
            displayLabel2.Text = "Hello!"; // change text to Hello!
            displayLabel3.Text = "Hello!"; // change text to Hello!
            uppercaseRadioButton.Checked = false;
            reverseRadioButton.Checked = false;
            charactersRadioButton.Checked = false;
        } // end method helloRadioButton_CheckedChanged

        // event handler for Goodbye! RadioButton
        private void goodbyeRadioButton_CheckedChanged(
           object sender, EventArgs e)
        {
            displayLabel.Text = "Goodbye!"; // change text to Goodbye!
            displayLabel2.Text = "Goodbye!"; // change text to Goodbye!
            displayLabel3.Text = "Goodbye!"; // change text to Goodbye!
            uppercaseRadioButton.Checked = false;
            reverseRadioButton.Checked = false;
            charactersRadioButton.Checked = false;
        } // end method goodbyeRadioButton_CheckedChanged

        // event handler for Bonjour! RadioButton
        private void bonjourRadioButton_CheckedChanged(
           object sender, EventArgs e)
        {
            displayLabel.Text = "Bonjour!"; // change text to Goodbye!
            displayLabel2.Text = "Bonjour!"; // change text to Goodbye!
            displayLabel3.Text = "Bonjour!"; // change text to Goodbye!
            uppercaseRadioButton.Checked = false;
            reverseRadioButton.Checked = false;
            charactersRadioButton.Checked = false;
        } // end method bonjourRadioButton_CheckedChanged

        // event handler for Adieu! RadioButton
        private void adieuRadioButton_CheckedChanged(
           object sender, EventArgs e)
        {
            displayLabel.Text = "Adieu!"; // change text to Goodbye!
            displayLabel2.Text = "Adieu!"; // change text to Goodbye!
            displayLabel3.Text = "Adieu!"; // change text to Goodbye!
            uppercaseRadioButton.Checked = false;
            reverseRadioButton.Checked = false;
            charactersRadioButton.Checked = false;
        } // end method adieuRadioButton_CheckedChanged

        // event handler for Salut! RadioButton
        private void salutRadioButton_CheckedChanged(
           object sender, EventArgs e)
        {
            displayLabel.Text = "Salut!"; // change text to Goodbye!
            displayLabel2.Text = "Salut!"; // change text to Goodbye!
            displayLabel3.Text = "Salut!"; // change text to Goodbye!
            uppercaseRadioButton.Checked = false;
            reverseRadioButton.Checked = false;
            charactersRadioButton.Checked = false;
        } // end method salutRadioButton_CheckedChanged

        // event handler for bold RadioButton
        private void leftRadioButton_CheckedChanged(
           object sender, EventArgs e)
        {
            displayLabel.TextAlign = ContentAlignment.MiddleLeft; // change alignment to left
        } // end method leftRadioButton_CheckedChanged

        // event handler for italicize RadioButton
        private void centerRadioButton_CheckedChanged(
           object sender, EventArgs e)
        {
            displayLabel.TextAlign = ContentAlignment.MiddleCenter; // change alignment to center
        } // end method centerRadioButton_CheckedChanged

        // event handler for underline RadioButton
        private void rightRadioButton_CheckedChanged(
           object sender, EventArgs e)
        {
            displayLabel.TextAlign = ContentAlignment.MiddleRight; // change alignment to right
        } // end method rightRadioButton_CheckedChanged

        // event handler for uppercase RadioButton
        private void uppercaseRadioButton_CheckedChanged(
           object sender, EventArgs e)
        {
            string upper = displayLabel.Text.ToUpper();
            displayLabel2.Text = upper;
        } // end method uppercaseRadioButton_CheckedChanged

        // event handler for Underline! RadioButton
        private void reverseRadioButton_CheckedChanged(
           object sender, EventArgs e)
        {
            string reverse = "";
            for (int i = displayLabel.Text.Length - 1; i >= 0; i--)
                reverse += displayLabel.Text[i];
            displayLabel2.Text = reverse;
        } // end method reverseRadioButton_CheckedChanged

        // event handler for Underline! RadioButton
        private void charactersRadioButton_CheckedChanged(
           object sender, EventArgs e)
        {
            int characters = displayLabel.Text.Length;
            displayLabel2.Text = characters.ToString();
        } // end method charactersRadioButton_CheckedChanged

        // event handler for increment Button
        private void increment_Click(object sender, EventArgs e)
        {
            string increment = "";
            for (int i = 0; i < displayLabel3.Text.Length; i++)
                increment += Char.ConvertFromUtf32(Char.ConvertToUtf32(displayLabel3.Text, i) + 1);
            displayLabel3.Text = increment;
        } // end method charactersRadioButton_CheckedChanged

        // event handler for decrement Button
        private void decrement_Click(object sender, EventArgs e)
        {
            string decrement = "";
            for (int i = 0; i < displayLabel3.Text.Length; i++)
                decrement += Char.ConvertFromUtf32(Char.ConvertToUtf32(displayLabel3.Text, i) - 1);
            displayLabel3.Text = decrement;
        } // end method charactersRadioButton_CheckedChanged
    } // end class UsingTabsForm
} // end namespace UsingTabs