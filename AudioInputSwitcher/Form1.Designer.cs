namespace AudioInputSwitcher
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.inputBox1 = new System.Windows.Forms.ComboBox();
            this.welcome = new System.Windows.Forms.Label();
            this.input1 = new System.Windows.Forms.Label();
            this.input2 = new System.Windows.Forms.Label();
            this.inputBox2 = new System.Windows.Forms.ComboBox();
            this.input1Active = new System.Windows.Forms.Label();
            this.input2Active = new System.Windows.Forms.Label();
            this.changeInputButton = new System.Windows.Forms.Label();
            this.changeInputBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // inputBox1
            // 
            this.inputBox1.Enabled = false;
            this.inputBox1.FormattingEnabled = true;
            this.inputBox1.Location = new System.Drawing.Point(58, 87);
            this.inputBox1.Name = "inputBox1";
            this.inputBox1.Size = new System.Drawing.Size(316, 21);
            this.inputBox1.TabIndex = 0;
            // 
            // welcome
            // 
            this.welcome.AutoSize = true;
            this.welcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcome.Location = new System.Drawing.Point(12, 12);
            this.welcome.Name = "welcome";
            this.welcome.Size = new System.Drawing.Size(91, 24);
            this.welcome.TabIndex = 1;
            this.welcome.Text = "Welcome";
            // 
            // input1
            // 
            this.input1.AutoSize = true;
            this.input1.Location = new System.Drawing.Point(12, 90);
            this.input1.Name = "input1";
            this.input1.Size = new System.Drawing.Size(40, 13);
            this.input1.TabIndex = 2;
            this.input1.Text = "Input 1";
            // 
            // input2
            // 
            this.input2.AutoSize = true;
            this.input2.Location = new System.Drawing.Point(12, 117);
            this.input2.Name = "input2";
            this.input2.Size = new System.Drawing.Size(40, 13);
            this.input2.TabIndex = 4;
            this.input2.Text = "Input 2";
            // 
            // inputBox2
            // 
            this.inputBox2.FormattingEnabled = true;
            this.inputBox2.Location = new System.Drawing.Point(58, 114);
            this.inputBox2.Name = "inputBox2";
            this.inputBox2.Size = new System.Drawing.Size(316, 21);
            this.inputBox2.TabIndex = 3;
            // 
            // input1Active
            // 
            this.input1Active.AutoSize = true;
            this.input1Active.ForeColor = System.Drawing.Color.Green;
            this.input1Active.Location = new System.Drawing.Point(380, 90);
            this.input1Active.Name = "input1Active";
            this.input1Active.Size = new System.Drawing.Size(37, 13);
            this.input1Active.TabIndex = 5;
            this.input1Active.Text = "Active";
            // 
            // input2Active
            // 
            this.input2Active.AutoSize = true;
            this.input2Active.ForeColor = System.Drawing.Color.Green;
            this.input2Active.Location = new System.Drawing.Point(380, 117);
            this.input2Active.Name = "input2Active";
            this.input2Active.Size = new System.Drawing.Size(37, 13);
            this.input2Active.TabIndex = 6;
            this.input2Active.Text = "Active";
            this.input2Active.Visible = false;
            // 
            // changeInputButton
            // 
            this.changeInputButton.AutoSize = true;
            this.changeInputButton.Location = new System.Drawing.Point(11, 54);
            this.changeInputButton.Name = "changeInputButton";
            this.changeInputButton.Size = new System.Drawing.Size(41, 13);
            this.changeInputButton.TabIndex = 7;
            this.changeInputButton.Text = "Hotkey";
            // 
            // changeInputBox
            // 
            this.changeInputBox.FormattingEnabled = true;
            this.changeInputBox.Items.AddRange(new object[] {
            "a",
            "b",
            "c",
            "d",
            "e",
            "f",
            "g",
            "h",
            "i",
            "j",
            "k",
            "l",
            "m",
            "n",
            "o",
            "p",
            "q",
            "r",
            "s",
            "t",
            "u",
            "v",
            "w",
            "x",
            "y",
            "z",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            ",",
            ".",
            "-",
            "<",
            ">",
            "^"});
            this.changeInputBox.Location = new System.Drawing.Point(58, 51);
            this.changeInputBox.Name = "changeInputBox";
            this.changeInputBox.Size = new System.Drawing.Size(104, 21);
            this.changeInputBox.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(429, 158);
            this.Controls.Add(this.changeInputBox);
            this.Controls.Add(this.changeInputButton);
            this.Controls.Add(this.input2Active);
            this.Controls.Add(this.input1Active);
            this.Controls.Add(this.input2);
            this.Controls.Add(this.inputBox2);
            this.Controls.Add(this.input1);
            this.Controls.Add(this.welcome);
            this.Controls.Add(this.inputBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox inputBox1;
        private System.Windows.Forms.Label welcome;
        private System.Windows.Forms.Label input1;
        private System.Windows.Forms.Label input2;
        private System.Windows.Forms.ComboBox inputBox2;
        private System.Windows.Forms.Label input1Active;
        private System.Windows.Forms.Label input2Active;
        private System.Windows.Forms.Label changeInputButton;
        private System.Windows.Forms.ComboBox changeInputBox;
    }
}

