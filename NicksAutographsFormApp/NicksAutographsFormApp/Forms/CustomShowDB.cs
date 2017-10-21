using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NicksAutographsFormApp
{
    public partial class CustomShowDB : Form
    {
        public CustomShowDB()
        {
            InitializeComponent();
            textBoxMaxPrice.Enabled = false;
            textBoxMinPrice.Enabled = false;
        }

        private void btnShowDb_Click(object sender, EventArgs e)
        {
            if (textBoxMaxPrice.Text == "")
            {
                lblError.Text = "Enter #";
            }
        }
      

        private void CheckBoxPriceChecked(object sender, EventArgs e)
        {
            if (checkBoxPrice.Checked == true)
            {
                textBoxMaxPrice.Enabled = true;
                textBoxMinPrice.Enabled = true;
            }
            else
            {
                textBoxMaxPrice.Enabled = false;
                textBoxMinPrice.Enabled = false;
            }
        }

    }
}
