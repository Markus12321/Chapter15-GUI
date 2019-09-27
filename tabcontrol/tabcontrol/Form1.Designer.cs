namespace tabcontrol
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.blackButton = new System.Windows.Forms.RadioButton();
            this.redButton = new System.Windows.Forms.RadioButton();
            this.greenButton = new System.Windows.Forms.RadioButton();
            this.smallButton = new System.Windows.Forms.RadioButton();
            this.mediumButton = new System.Windows.Forms.RadioButton();
            this.bigButton = new System.Windows.Forms.RadioButton();
            this.helloButton = new System.Windows.Forms.RadioButton();
            this.goodbyeButton = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.displayLabel = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(149, 54);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(468, 199);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            this.tabPage1.Controls.Add(this.greenButton);
            this.tabPage1.Controls.Add(this.redButton);
            this.tabPage1.Controls.Add(this.blackButton);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(460, 173);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Transparent;
            this.tabPage2.Controls.Add(this.bigButton);
            this.tabPage2.Controls.Add(this.mediumButton);
            this.tabPage2.Controls.Add(this.smallButton);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(460, 173);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.Transparent;
            this.tabPage3.Controls.Add(this.goodbyeButton);
            this.tabPage3.Controls.Add(this.helloButton);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(460, 173);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.Transparent;
            this.tabPage4.Controls.Add(this.label1);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(460, 173);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "tabPage4";
            // 
            // blackButton
            // 
            this.blackButton.AutoSize = true;
            this.blackButton.Location = new System.Drawing.Point(24, 34);
            this.blackButton.Name = "blackButton";
            this.blackButton.Size = new System.Drawing.Size(52, 17);
            this.blackButton.TabIndex = 0;
            this.blackButton.TabStop = true;
            this.blackButton.Text = "Black";
            this.blackButton.UseVisualStyleBackColor = true;
            this.blackButton.CheckedChanged += new System.EventHandler(this.blackButton_CheckedChanged);
            // 
            // redButton
            // 
            this.redButton.AutoSize = true;
            this.redButton.Location = new System.Drawing.Point(24, 69);
            this.redButton.Name = "redButton";
            this.redButton.Size = new System.Drawing.Size(45, 17);
            this.redButton.TabIndex = 1;
            this.redButton.TabStop = true;
            this.redButton.Text = "Red";
            this.redButton.UseVisualStyleBackColor = true;
            this.redButton.CheckedChanged += new System.EventHandler(this.blackButton_CheckedChanged);
            // 
            // greenButton
            // 
            this.greenButton.AutoSize = true;
            this.greenButton.Location = new System.Drawing.Point(24, 105);
            this.greenButton.Name = "greenButton";
            this.greenButton.Size = new System.Drawing.Size(54, 17);
            this.greenButton.TabIndex = 2;
            this.greenButton.TabStop = true;
            this.greenButton.Text = "Green";
            this.greenButton.UseVisualStyleBackColor = true;
            this.greenButton.CheckedChanged += new System.EventHandler(this.blackButton_CheckedChanged);
            // 
            // smallButton
            // 
            this.smallButton.AutoSize = true;
            this.smallButton.Location = new System.Drawing.Point(26, 41);
            this.smallButton.Name = "smallButton";
            this.smallButton.Size = new System.Drawing.Size(37, 17);
            this.smallButton.TabIndex = 0;
            this.smallButton.TabStop = true;
            this.smallButton.Text = "12";
            this.smallButton.UseVisualStyleBackColor = true;
            this.smallButton.CheckedChanged += new System.EventHandler(this.smallButton_CheckedChanged);
            // 
            // mediumButton
            // 
            this.mediumButton.AutoSize = true;
            this.mediumButton.Location = new System.Drawing.Point(26, 80);
            this.mediumButton.Name = "mediumButton";
            this.mediumButton.Size = new System.Drawing.Size(37, 17);
            this.mediumButton.TabIndex = 1;
            this.mediumButton.TabStop = true;
            this.mediumButton.Text = "16";
            this.mediumButton.UseVisualStyleBackColor = true;
            this.mediumButton.CheckedChanged += new System.EventHandler(this.smallButton_CheckedChanged);
            // 
            // bigButton
            // 
            this.bigButton.AutoSize = true;
            this.bigButton.Location = new System.Drawing.Point(26, 119);
            this.bigButton.Name = "bigButton";
            this.bigButton.Size = new System.Drawing.Size(37, 17);
            this.bigButton.TabIndex = 2;
            this.bigButton.TabStop = true;
            this.bigButton.Text = "20";
            this.bigButton.UseVisualStyleBackColor = true;
            this.bigButton.CheckedChanged += new System.EventHandler(this.smallButton_CheckedChanged);
            // 
            // helloButton
            // 
            this.helloButton.AutoSize = true;
            this.helloButton.Location = new System.Drawing.Point(30, 31);
            this.helloButton.Name = "helloButton";
            this.helloButton.Size = new System.Drawing.Size(52, 17);
            this.helloButton.TabIndex = 0;
            this.helloButton.TabStop = true;
            this.helloButton.Text = "Hello!";
            this.helloButton.UseVisualStyleBackColor = true;
            this.helloButton.CheckedChanged += new System.EventHandler(this.helloButton_CheckedChanged);
            // 
            // goodbyeButton
            // 
            this.goodbyeButton.AutoSize = true;
            this.goodbyeButton.Location = new System.Drawing.Point(30, 82);
            this.goodbyeButton.Name = "goodbyeButton";
            this.goodbyeButton.Size = new System.Drawing.Size(71, 17);
            this.goodbyeButton.TabIndex = 1;
            this.goodbyeButton.TabStop = true;
            this.goodbyeButton.Text = "Goodbye!";
            this.goodbyeButton.UseVisualStyleBackColor = true;
            this.goodbyeButton.CheckedChanged += new System.EventHandler(this.helloButton_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 30);
            this.label1.MaximumSize = new System.Drawing.Size(400, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(399, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tabs are used to orgamoze controls and conserve screen space";
            // 
            // displayLabel
            // 
            this.displayLabel.AutoSize = true;
            this.displayLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.displayLabel.Location = new System.Drawing.Point(307, 322);
            this.displayLabel.Name = "displayLabel";
            this.displayLabel.Size = new System.Drawing.Size(31, 13);
            this.displayLabel.TabIndex = 1;
            this.displayLabel.Text = "Hello";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.displayLabel);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.RadioButton greenButton;
        private System.Windows.Forms.RadioButton redButton;
        private System.Windows.Forms.RadioButton blackButton;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.RadioButton bigButton;
        private System.Windows.Forms.RadioButton mediumButton;
        private System.Windows.Forms.RadioButton smallButton;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.RadioButton goodbyeButton;
        private System.Windows.Forms.RadioButton helloButton;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label displayLabel;
    }
}

