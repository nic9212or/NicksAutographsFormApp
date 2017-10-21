using System;
using System.Windows.Forms;

namespace NicksAutographsFormApp
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            NickAutographsOpeningForm addAutoForm = new NickAutographsOpeningForm();
            addAutoForm.Show();
        }

        private void btnPictures_Click(object sender, EventArgs e)
        {
            PicturesForm pform = new PicturesForm();
            pform.Show();
        }

        private void btnShowDB_Click(object sender, EventArgs e)
        {
            //show db form
            DBForm dbf = new DBForm();
            dbf.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();       
        }
    }
}
