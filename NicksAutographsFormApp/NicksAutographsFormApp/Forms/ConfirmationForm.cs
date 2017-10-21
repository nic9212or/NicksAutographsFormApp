using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NicksAutographsFormApp
{
    public partial class ConfirmationForm : Form
    {
        public ConfirmationForm()
        {
            InitializeComponent();
        }

        private void btnShowDb_Click(object sender, EventArgs e)
        {
          //show db form
            DBForm dbf = new DBForm();
            dbf.Show();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            //not right way
            NickAutographsOpeningForm naof = new NickAutographsOpeningForm();
            naof.Show();
        }
    }
}
