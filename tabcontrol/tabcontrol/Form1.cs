using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tabcontrol
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
        }

        private void blackButton_CheckedChanged(object sender, EventArgs e)
        {
            if(sender == blackButton)
            {
                displayLabel.ForeColor = Color.Black;
            }else if(sender == redButton)
            {
                displayLabel.ForeColor = Color.Red;
            }
            else
            {
                displayLabel.ForeColor = Color.Green;
            }
        }

        private void smallButton_CheckedChanged(object sender, EventArgs e)
        {
            if (sender == smallButton)
            {
                displayLabel.Font = new Font(displayLabel.Font.FontFamily, 12F);
            }
            else if (sender == mediumButton)
            {
                displayLabel.Font = new Font(displayLabel.Font.FontFamily, 16F);
            }
            else
            {
                displayLabel.Font = new Font(displayLabel.Font.FontFamily, 20F);

            }
        }

        private void helloButton_CheckedChanged(object sender, EventArgs e)
        {
            if(sender == helloButton)
            {
                displayLabel.Text = "Hello!";
            }
            else
            {
                displayLabel.Text = "Goodbye!";
            }
        }
    }
}
