using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy_Management_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Font defaultFont = SystemFonts.DefaultFont;

            if (label1.Text.StartsWith("**") && label1.Text.EndsWith("**"))
            {
                label1.Font = new Font(defaultFont.FontFamily, defaultFont.Size, FontStyle.Bold);
                label1.ForeColor = Color.Red;
                // note: can't change text here as it will recursively trigger this handler
            }
            else
            {
                label1.Font = defaultFont;
                label1.ForeColor = SystemColors.ControlText;
            }
        }
    }
}
