namespace ScratchpaperForms
{
    partial class UsingTabsForm
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
            this.displayLabel = new System.Windows.Forms.Label();
            this.asciiTabPage = new System.Windows.Forms.TabPage();
            this.increment = new System.Windows.Forms.Button();
            this.decrement = new System.Windows.Forms.Button();
            this.displayLabel3 = new System.Windows.Forms.Label();
            this.processTabPage = new System.Windows.Forms.TabPage();
            this.displayLabel2 = new System.Windows.Forms.Label();
            this.uppercaseRadioButton = new System.Windows.Forms.RadioButton();
            this.reverseRadioButton = new System.Windows.Forms.RadioButton();
            this.charactersRadioButton = new System.Windows.Forms.RadioButton();
            this.alignTabPage = new System.Windows.Forms.TabPage();
            this.leftRadioButton = new System.Windows.Forms.RadioButton();
            this.centerRadioButton = new System.Windows.Forms.RadioButton();
            this.rightRadioButton = new System.Windows.Forms.RadioButton();
            this.messageTabPage = new System.Windows.Forms.TabPage();
            this.helloRadioButton = new System.Windows.Forms.RadioButton();
            this.goodbyeRadioButton = new System.Windows.Forms.RadioButton();
            this.bonjourRadioButton = new System.Windows.Forms.RadioButton();
            this.adieuRadioButton = new System.Windows.Forms.RadioButton();
            this.salutRadioButton = new System.Windows.Forms.RadioButton();
            this.sizeTabPage = new System.Windows.Forms.TabPage();
            this.size12RadioButton = new System.Windows.Forms.RadioButton();
            this.size16RadioButton = new System.Windows.Forms.RadioButton();
            this.size20RadioButton = new System.Windows.Forms.RadioButton();
            this.size24RadioButton = new System.Windows.Forms.RadioButton();
            this.size28RadioButton = new System.Windows.Forms.RadioButton();
            this.size32RadioButton = new System.Windows.Forms.RadioButton();
            this.size36RadioButton = new System.Windows.Forms.RadioButton();
            this.colorTabPage = new System.Windows.Forms.TabPage();
            this.blackRadioButton = new System.Windows.Forms.RadioButton();
            this.redRadioButton = new System.Windows.Forms.RadioButton();
            this.greenRadioButton = new System.Windows.Forms.RadioButton();
            this.blueRadioButton = new System.Windows.Forms.RadioButton();
            this.yellowRadioButton = new System.Windows.Forms.RadioButton();
            this.orangeRadioButton = new System.Windows.Forms.RadioButton();
            this.purpleRadioButton = new System.Windows.Forms.RadioButton();
            this.textOptionsTabControl = new System.Windows.Forms.TabControl();
            this.asciiTabPage.SuspendLayout();
            this.processTabPage.SuspendLayout();
            this.alignTabPage.SuspendLayout();
            this.messageTabPage.SuspendLayout();
            this.sizeTabPage.SuspendLayout();
            this.colorTabPage.SuspendLayout();
            this.textOptionsTabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // displayLabel
            // 
            this.displayLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayLabel.Location = new System.Drawing.Point(16, 300);
            this.displayLabel.Name = "displayLabel";
            this.displayLabel.Size = new System.Drawing.Size(461, 113);
            this.displayLabel.TabIndex = 7;
            this.displayLabel.Text = "Hello!";
            this.displayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // asciiTabPage
            // 
            this.asciiTabPage.Controls.Add(this.displayLabel3);
            this.asciiTabPage.Controls.Add(this.decrement);
            this.asciiTabPage.Controls.Add(this.increment);
            this.asciiTabPage.Location = new System.Drawing.Point(4, 34);
            this.asciiTabPage.Name = "asciiTabPage";
            this.asciiTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.asciiTabPage.Size = new System.Drawing.Size(461, 247);
            this.asciiTabPage.TabIndex = 6;
            this.asciiTabPage.Text = "ASCII";
            this.asciiTabPage.UseVisualStyleBackColor = true;
            // 
            // increment
            // 
            this.increment.Location = new System.Drawing.Point(6, 6);
            this.increment.Name = "increment";
            this.increment.Size = new System.Drawing.Size(144, 38);
            this.increment.TabIndex = 0;
            this.increment.Text = "Increment";
            this.increment.UseVisualStyleBackColor = true;
            this.increment.Click += new System.EventHandler(this.increment_Click);
            // 
            // decrement
            // 
            this.decrement.Location = new System.Drawing.Point(6, 50);
            this.decrement.Name = "decrement";
            this.decrement.Size = new System.Drawing.Size(144, 38);
            this.decrement.TabIndex = 1;
            this.decrement.Text = "Decrement";
            this.decrement.UseVisualStyleBackColor = true;
            this.decrement.Click += new System.EventHandler(this.decrement_Click);
            // 
            // displayLabel3
            // 
            this.displayLabel3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayLabel3.Location = new System.Drawing.Point(220, 3);
            this.displayLabel3.Name = "displayLabel3";
            this.displayLabel3.Size = new System.Drawing.Size(238, 241);
            this.displayLabel3.TabIndex = 9;
            this.displayLabel3.Text = this.displayLabel.Text;
            this.displayLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // processTabPage
            // 
            this.processTabPage.Controls.Add(this.charactersRadioButton);
            this.processTabPage.Controls.Add(this.reverseRadioButton);
            this.processTabPage.Controls.Add(this.uppercaseRadioButton);
            this.processTabPage.Controls.Add(this.displayLabel2);
            this.processTabPage.Location = new System.Drawing.Point(4, 34);
            this.processTabPage.Name = "processTabPage";
            this.processTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.processTabPage.Size = new System.Drawing.Size(461, 247);
            this.processTabPage.TabIndex = 5;
            this.processTabPage.Text = "Process";
            this.processTabPage.UseVisualStyleBackColor = true;
            // 
            // displayLabel2
            // 
            this.displayLabel2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayLabel2.Location = new System.Drawing.Point(220, 3);
            this.displayLabel2.Name = "displayLabel2";
            this.displayLabel2.Size = new System.Drawing.Size(238, 241);
            this.displayLabel2.TabIndex = 8;
            this.displayLabel2.Text = this.displayLabel.Text;
            this.displayLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uppercaseRadioButton
            // 
            this.uppercaseRadioButton.AutoSize = true;
            this.uppercaseRadioButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uppercaseRadioButton.Location = new System.Drawing.Point(6, 6);
            this.uppercaseRadioButton.Name = "uppercaseRadioButton";
            this.uppercaseRadioButton.Size = new System.Drawing.Size(120, 29);
            this.uppercaseRadioButton.TabIndex = 9;
            this.uppercaseRadioButton.TabStop = true;
            this.uppercaseRadioButton.Text = "Uppercase";
            this.uppercaseRadioButton.CheckedChanged += new System.EventHandler(this.uppercaseRadioButton_CheckedChanged);
            // 
            // reverseRadioButton
            // 
            this.reverseRadioButton.AutoSize = true;
            this.reverseRadioButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reverseRadioButton.Location = new System.Drawing.Point(6, 41);
            this.reverseRadioButton.Name = "reverseRadioButton";
            this.reverseRadioButton.Size = new System.Drawing.Size(97, 29);
            this.reverseRadioButton.TabIndex = 10;
            this.reverseRadioButton.TabStop = true;
            this.reverseRadioButton.Text = "Reverse";
            this.reverseRadioButton.CheckedChanged += new System.EventHandler(this.reverseRadioButton_CheckedChanged);
            // 
            // charactersRadioButton
            // 
            this.charactersRadioButton.AutoSize = true;
            this.charactersRadioButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.charactersRadioButton.Location = new System.Drawing.Point(6, 76);
            this.charactersRadioButton.Name = "charactersRadioButton";
            this.charactersRadioButton.Size = new System.Drawing.Size(119, 29);
            this.charactersRadioButton.TabIndex = 11;
            this.charactersRadioButton.TabStop = true;
            this.charactersRadioButton.Text = "Characters";
            this.charactersRadioButton.CheckedChanged += new System.EventHandler(this.charactersRadioButton_CheckedChanged);
            // 
            // alignTabPage
            // 
            this.alignTabPage.Controls.Add(this.rightRadioButton);
            this.alignTabPage.Controls.Add(this.centerRadioButton);
            this.alignTabPage.Controls.Add(this.leftRadioButton);
            this.alignTabPage.Location = new System.Drawing.Point(4, 34);
            this.alignTabPage.Name = "alignTabPage";
            this.alignTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.alignTabPage.Size = new System.Drawing.Size(560, 247);
            this.alignTabPage.TabIndex = 4;
            this.alignTabPage.Text = "Alignment";
            this.alignTabPage.UseVisualStyleBackColor = true;
            // 
            // leftRadioButton
            // 
            this.leftRadioButton.AutoSize = true;
            this.leftRadioButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leftRadioButton.Location = new System.Drawing.Point(6, 6);
            this.leftRadioButton.Name = "leftRadioButton";
            this.leftRadioButton.Size = new System.Drawing.Size(66, 29);
            this.leftRadioButton.TabIndex = 3;
            this.leftRadioButton.TabStop = true;
            this.leftRadioButton.Text = "Left";
            this.leftRadioButton.CheckedChanged += new System.EventHandler(this.leftRadioButton_CheckedChanged);
            // 
            // centerRadioButton
            // 
            this.centerRadioButton.AutoSize = true;
            this.centerRadioButton.Checked = true;
            this.centerRadioButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.centerRadioButton.Location = new System.Drawing.Point(6, 41);
            this.centerRadioButton.Name = "centerRadioButton";
            this.centerRadioButton.Size = new System.Drawing.Size(88, 29);
            this.centerRadioButton.TabIndex = 4;
            this.centerRadioButton.TabStop = true;
            this.centerRadioButton.Text = "Center";
            this.centerRadioButton.CheckedChanged += new System.EventHandler(this.centerRadioButton_CheckedChanged);
            // 
            // rightRadioButton
            // 
            this.rightRadioButton.AutoSize = true;
            this.rightRadioButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rightRadioButton.Location = new System.Drawing.Point(6, 76);
            this.rightRadioButton.Name = "rightRadioButton";
            this.rightRadioButton.Size = new System.Drawing.Size(79, 29);
            this.rightRadioButton.TabIndex = 5;
            this.rightRadioButton.TabStop = true;
            this.rightRadioButton.Text = "Right";
            this.rightRadioButton.CheckedChanged += new System.EventHandler(this.rightRadioButton_CheckedChanged);
            // 
            // messageTabPage
            // 
            this.messageTabPage.Controls.Add(this.salutRadioButton);
            this.messageTabPage.Controls.Add(this.adieuRadioButton);
            this.messageTabPage.Controls.Add(this.bonjourRadioButton);
            this.messageTabPage.Controls.Add(this.goodbyeRadioButton);
            this.messageTabPage.Controls.Add(this.helloRadioButton);
            this.messageTabPage.Location = new System.Drawing.Point(4, 34);
            this.messageTabPage.Name = "messageTabPage";
            this.messageTabPage.Size = new System.Drawing.Size(560, 247);
            this.messageTabPage.TabIndex = 2;
            this.messageTabPage.Text = "Message";
            // 
            // helloRadioButton
            // 
            this.helloRadioButton.AutoSize = true;
            this.helloRadioButton.Checked = true;
            this.helloRadioButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helloRadioButton.Location = new System.Drawing.Point(6, 6);
            this.helloRadioButton.Name = "helloRadioButton";
            this.helloRadioButton.Size = new System.Drawing.Size(83, 29);
            this.helloRadioButton.TabIndex = 2;
            this.helloRadioButton.TabStop = true;
            this.helloRadioButton.Text = "Hello!";
            this.helloRadioButton.CheckedChanged += new System.EventHandler(this.helloRadioButton_CheckedChanged);
            // 
            // goodbyeRadioButton
            // 
            this.goodbyeRadioButton.AutoSize = true;
            this.goodbyeRadioButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goodbyeRadioButton.Location = new System.Drawing.Point(6, 41);
            this.goodbyeRadioButton.Name = "goodbyeRadioButton";
            this.goodbyeRadioButton.Size = new System.Drawing.Size(116, 29);
            this.goodbyeRadioButton.TabIndex = 3;
            this.goodbyeRadioButton.Text = "Goodbye!";
            this.goodbyeRadioButton.CheckedChanged += new System.EventHandler(this.goodbyeRadioButton_CheckedChanged);
            // 
            // bonjourRadioButton
            // 
            this.bonjourRadioButton.AutoSize = true;
            this.bonjourRadioButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bonjourRadioButton.Location = new System.Drawing.Point(6, 76);
            this.bonjourRadioButton.Name = "bonjourRadioButton";
            this.bonjourRadioButton.Size = new System.Drawing.Size(104, 29);
            this.bonjourRadioButton.TabIndex = 4;
            this.bonjourRadioButton.Text = "Bonjour!";
            this.bonjourRadioButton.CheckedChanged += new System.EventHandler(this.bonjourRadioButton_CheckedChanged);
            // 
            // adieuRadioButton
            // 
            this.adieuRadioButton.AutoSize = true;
            this.adieuRadioButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adieuRadioButton.Location = new System.Drawing.Point(6, 111);
            this.adieuRadioButton.Name = "adieuRadioButton";
            this.adieuRadioButton.Size = new System.Drawing.Size(88, 29);
            this.adieuRadioButton.TabIndex = 5;
            this.adieuRadioButton.Text = "Adieu!";
            this.adieuRadioButton.CheckedChanged += new System.EventHandler(this.adieuRadioButton_CheckedChanged);
            // 
            // salutRadioButton
            // 
            this.salutRadioButton.AutoSize = true;
            this.salutRadioButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salutRadioButton.Location = new System.Drawing.Point(6, 146);
            this.salutRadioButton.Name = "salutRadioButton";
            this.salutRadioButton.Size = new System.Drawing.Size(81, 29);
            this.salutRadioButton.TabIndex = 6;
            this.salutRadioButton.Text = "Salut!";
            this.salutRadioButton.CheckedChanged += new System.EventHandler(this.salutRadioButton_CheckedChanged);
            // 
            // sizeTabPage
            // 
            this.sizeTabPage.Controls.Add(this.size36RadioButton);
            this.sizeTabPage.Controls.Add(this.size32RadioButton);
            this.sizeTabPage.Controls.Add(this.size28RadioButton);
            this.sizeTabPage.Controls.Add(this.size24RadioButton);
            this.sizeTabPage.Controls.Add(this.size20RadioButton);
            this.sizeTabPage.Controls.Add(this.size16RadioButton);
            this.sizeTabPage.Controls.Add(this.size12RadioButton);
            this.sizeTabPage.Location = new System.Drawing.Point(4, 34);
            this.sizeTabPage.Name = "sizeTabPage";
            this.sizeTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.sizeTabPage.Size = new System.Drawing.Size(560, 247);
            this.sizeTabPage.TabIndex = 1;
            this.sizeTabPage.Text = "Size";
            // 
            // size12RadioButton
            // 
            this.size12RadioButton.AutoSize = true;
            this.size12RadioButton.Checked = true;
            this.size12RadioButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.size12RadioButton.Location = new System.Drawing.Point(6, 6);
            this.size12RadioButton.Name = "size12RadioButton";
            this.size12RadioButton.Size = new System.Drawing.Size(104, 29);
            this.size12RadioButton.TabIndex = 0;
            this.size12RadioButton.TabStop = true;
            this.size12RadioButton.Text = "12 point";
            this.size12RadioButton.CheckedChanged += new System.EventHandler(this.size12RadioButton_CheckedChanged);
            // 
            // size16RadioButton
            // 
            this.size16RadioButton.AutoSize = true;
            this.size16RadioButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.size16RadioButton.Location = new System.Drawing.Point(6, 41);
            this.size16RadioButton.Name = "size16RadioButton";
            this.size16RadioButton.Size = new System.Drawing.Size(104, 29);
            this.size16RadioButton.TabIndex = 1;
            this.size16RadioButton.Text = "16 point";
            this.size16RadioButton.CheckedChanged += new System.EventHandler(this.size16RadioButton_CheckedChanged);
            // 
            // size20RadioButton
            // 
            this.size20RadioButton.AutoSize = true;
            this.size20RadioButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.size20RadioButton.Location = new System.Drawing.Point(6, 76);
            this.size20RadioButton.Name = "size20RadioButton";
            this.size20RadioButton.Size = new System.Drawing.Size(104, 29);
            this.size20RadioButton.TabIndex = 2;
            this.size20RadioButton.Text = "20 point";
            this.size20RadioButton.CheckedChanged += new System.EventHandler(this.size20RadioButton_CheckedChanged);
            // 
            // size24RadioButton
            // 
            this.size24RadioButton.AutoSize = true;
            this.size24RadioButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.size24RadioButton.Location = new System.Drawing.Point(6, 111);
            this.size24RadioButton.Name = "size24RadioButton";
            this.size24RadioButton.Size = new System.Drawing.Size(104, 29);
            this.size24RadioButton.TabIndex = 3;
            this.size24RadioButton.Text = "24 point";
            this.size24RadioButton.CheckedChanged += new System.EventHandler(this.size24RadioButton_CheckedChanged);
            // 
            // size28RadioButton
            // 
            this.size28RadioButton.AutoSize = true;
            this.size28RadioButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.size28RadioButton.Location = new System.Drawing.Point(6, 146);
            this.size28RadioButton.Name = "size28RadioButton";
            this.size28RadioButton.Size = new System.Drawing.Size(104, 29);
            this.size28RadioButton.TabIndex = 4;
            this.size28RadioButton.Text = "28 point";
            this.size28RadioButton.CheckedChanged += new System.EventHandler(this.size28RadioButton_CheckedChanged);
            // 
            // size32RadioButton
            // 
            this.size32RadioButton.AutoSize = true;
            this.size32RadioButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.size32RadioButton.Location = new System.Drawing.Point(6, 181);
            this.size32RadioButton.Name = "size32RadioButton";
            this.size32RadioButton.Size = new System.Drawing.Size(104, 29);
            this.size32RadioButton.TabIndex = 5;
            this.size32RadioButton.Text = "32 point";
            this.size32RadioButton.CheckedChanged += new System.EventHandler(this.size32RadioButton_CheckedChanged);
            // 
            // size36RadioButton
            // 
            this.size36RadioButton.AutoSize = true;
            this.size36RadioButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.size36RadioButton.Location = new System.Drawing.Point(6, 216);
            this.size36RadioButton.Name = "size36RadioButton";
            this.size36RadioButton.Size = new System.Drawing.Size(104, 29);
            this.size36RadioButton.TabIndex = 6;
            this.size36RadioButton.Text = "36 point";
            this.size36RadioButton.CheckedChanged += new System.EventHandler(this.size36RadioButton_CheckedChanged);
            // 
            // colorTabPage
            // 
            this.colorTabPage.Controls.Add(this.purpleRadioButton);
            this.colorTabPage.Controls.Add(this.orangeRadioButton);
            this.colorTabPage.Controls.Add(this.yellowRadioButton);
            this.colorTabPage.Controls.Add(this.blueRadioButton);
            this.colorTabPage.Controls.Add(this.greenRadioButton);
            this.colorTabPage.Controls.Add(this.redRadioButton);
            this.colorTabPage.Controls.Add(this.blackRadioButton);
            this.colorTabPage.Location = new System.Drawing.Point(4, 34);
            this.colorTabPage.Name = "colorTabPage";
            this.colorTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.colorTabPage.Size = new System.Drawing.Size(560, 247);
            this.colorTabPage.TabIndex = 0;
            this.colorTabPage.Text = "Color";
            // 
            // blackRadioButton
            // 
            this.blackRadioButton.AutoSize = true;
            this.blackRadioButton.Checked = true;
            this.blackRadioButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blackRadioButton.Location = new System.Drawing.Point(6, 6);
            this.blackRadioButton.Name = "blackRadioButton";
            this.blackRadioButton.Size = new System.Drawing.Size(77, 29);
            this.blackRadioButton.TabIndex = 0;
            this.blackRadioButton.TabStop = true;
            this.blackRadioButton.Text = "Black";
            this.blackRadioButton.CheckedChanged += new System.EventHandler(this.blackRadioButton_CheckedChanged);
            // 
            // redRadioButton
            // 
            this.redRadioButton.AutoSize = true;
            this.redRadioButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.redRadioButton.Location = new System.Drawing.Point(6, 41);
            this.redRadioButton.Name = "redRadioButton";
            this.redRadioButton.Size = new System.Drawing.Size(67, 29);
            this.redRadioButton.TabIndex = 1;
            this.redRadioButton.Text = "Red";
            this.redRadioButton.CheckedChanged += new System.EventHandler(this.redRadioButton_CheckedChanged);
            // 
            // greenRadioButton
            // 
            this.greenRadioButton.AutoSize = true;
            this.greenRadioButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.greenRadioButton.Location = new System.Drawing.Point(6, 76);
            this.greenRadioButton.Name = "greenRadioButton";
            this.greenRadioButton.Size = new System.Drawing.Size(83, 29);
            this.greenRadioButton.TabIndex = 2;
            this.greenRadioButton.Text = "Green";
            this.greenRadioButton.CheckedChanged += new System.EventHandler(this.greenRadioButton_CheckedChanged);
            // 
            // blueRadioButton
            // 
            this.blueRadioButton.AutoSize = true;
            this.blueRadioButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blueRadioButton.Location = new System.Drawing.Point(6, 111);
            this.blueRadioButton.Name = "blueRadioButton";
            this.blueRadioButton.Size = new System.Drawing.Size(70, 29);
            this.blueRadioButton.TabIndex = 3;
            this.blueRadioButton.Text = "Blue";
            this.blueRadioButton.CheckedChanged += new System.EventHandler(this.blueRadioButton_CheckedChanged);
            // 
            // yellowRadioButton
            // 
            this.yellowRadioButton.AutoSize = true;
            this.yellowRadioButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yellowRadioButton.Location = new System.Drawing.Point(6, 146);
            this.yellowRadioButton.Name = "yellowRadioButton";
            this.yellowRadioButton.Size = new System.Drawing.Size(86, 29);
            this.yellowRadioButton.TabIndex = 4;
            this.yellowRadioButton.Text = "Yellow";
            this.yellowRadioButton.CheckedChanged += new System.EventHandler(this.yellowRadioButton_CheckedChanged);
            // 
            // orangeRadioButton
            // 
            this.orangeRadioButton.AutoSize = true;
            this.orangeRadioButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orangeRadioButton.Location = new System.Drawing.Point(6, 181);
            this.orangeRadioButton.Name = "orangeRadioButton";
            this.orangeRadioButton.Size = new System.Drawing.Size(96, 29);
            this.orangeRadioButton.TabIndex = 5;
            this.orangeRadioButton.Text = "Orange";
            this.orangeRadioButton.CheckedChanged += new System.EventHandler(this.orangeRadioButton_CheckedChanged);
            // 
            // purpleRadioButton
            // 
            this.purpleRadioButton.AutoSize = true;
            this.purpleRadioButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.purpleRadioButton.Location = new System.Drawing.Point(6, 216);
            this.purpleRadioButton.Name = "purpleRadioButton";
            this.purpleRadioButton.Size = new System.Drawing.Size(87, 29);
            this.purpleRadioButton.TabIndex = 6;
            this.purpleRadioButton.Text = "Purple";
            this.purpleRadioButton.CheckedChanged += new System.EventHandler(this.purpleRadioButton_CheckedChanged);
            // 
            // textOptionsTabControl
            // 
            this.textOptionsTabControl.Controls.Add(this.colorTabPage);
            this.textOptionsTabControl.Controls.Add(this.sizeTabPage);
            this.textOptionsTabControl.Controls.Add(this.messageTabPage);
            this.textOptionsTabControl.Controls.Add(this.alignTabPage);
            this.textOptionsTabControl.Controls.Add(this.processTabPage);
            this.textOptionsTabControl.Controls.Add(this.asciiTabPage);
            this.textOptionsTabControl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textOptionsTabControl.Location = new System.Drawing.Point(12, 12);
            this.textOptionsTabControl.Name = "textOptionsTabControl";
            this.textOptionsTabControl.SelectedIndex = 0;
            this.textOptionsTabControl.Size = new System.Drawing.Size(469, 285);
            this.textOptionsTabControl.TabIndex = 6;
            // 
            // UsingTabsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 428);
            this.Controls.Add(this.displayLabel);
            this.Controls.Add(this.textOptionsTabControl);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "UsingTabsForm";
            this.Text = "Using Tabs";
            this.asciiTabPage.ResumeLayout(false);
            this.processTabPage.ResumeLayout(false);
            this.processTabPage.PerformLayout();
            this.alignTabPage.ResumeLayout(false);
            this.alignTabPage.PerformLayout();
            this.messageTabPage.ResumeLayout(false);
            this.messageTabPage.PerformLayout();
            this.sizeTabPage.ResumeLayout(false);
            this.sizeTabPage.PerformLayout();
            this.colorTabPage.ResumeLayout(false);
            this.colorTabPage.PerformLayout();
            this.textOptionsTabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Label displayLabel;
        private System.Windows.Forms.TabPage asciiTabPage;
        internal System.Windows.Forms.Label displayLabel3;
        private System.Windows.Forms.Button decrement;
        private System.Windows.Forms.Button increment;
        internal System.Windows.Forms.TabPage processTabPage;
        internal System.Windows.Forms.RadioButton charactersRadioButton;
        internal System.Windows.Forms.RadioButton reverseRadioButton;
        internal System.Windows.Forms.RadioButton uppercaseRadioButton;
        internal System.Windows.Forms.Label displayLabel2;
        internal System.Windows.Forms.TabPage alignTabPage;
        internal System.Windows.Forms.RadioButton rightRadioButton;
        internal System.Windows.Forms.RadioButton centerRadioButton;
        internal System.Windows.Forms.RadioButton leftRadioButton;
        internal System.Windows.Forms.TabPage messageTabPage;
        internal System.Windows.Forms.RadioButton salutRadioButton;
        internal System.Windows.Forms.RadioButton adieuRadioButton;
        internal System.Windows.Forms.RadioButton bonjourRadioButton;
        internal System.Windows.Forms.RadioButton goodbyeRadioButton;
        internal System.Windows.Forms.RadioButton helloRadioButton;
        internal System.Windows.Forms.TabPage sizeTabPage;
        internal System.Windows.Forms.RadioButton size36RadioButton;
        internal System.Windows.Forms.RadioButton size32RadioButton;
        internal System.Windows.Forms.RadioButton size28RadioButton;
        internal System.Windows.Forms.RadioButton size24RadioButton;
        internal System.Windows.Forms.RadioButton size20RadioButton;
        internal System.Windows.Forms.RadioButton size16RadioButton;
        internal System.Windows.Forms.RadioButton size12RadioButton;
        internal System.Windows.Forms.TabPage colorTabPage;
        internal System.Windows.Forms.RadioButton purpleRadioButton;
        internal System.Windows.Forms.RadioButton orangeRadioButton;
        internal System.Windows.Forms.RadioButton yellowRadioButton;
        internal System.Windows.Forms.RadioButton blueRadioButton;
        internal System.Windows.Forms.RadioButton greenRadioButton;
        internal System.Windows.Forms.RadioButton redRadioButton;
        internal System.Windows.Forms.RadioButton blackRadioButton;
        internal System.Windows.Forms.TabControl textOptionsTabControl;
    }
}