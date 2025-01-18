using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace child_forms
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void richTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if Ctrl pressed
            if ((Control.ModifierKeys & Keys.Control) == Keys.Control)
            {
                return; // Allow Copy/Paste
            }

            if (Text == richTextBox1.Text)
            {
                if (e.KeyChar != (char)Keys.Back && !char.IsSeparator(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    MessageBox.Show("Special characters are not allowed");
                    e.Handled = true;
                }
            }
        }
    }
}
