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
    public partial class DBForm : Form
    {//Nichlas ADDED this
        public DBForm()
        {
            InitializeComponent();
        }

        private void DBForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'autographCollectionDataSet.NicksAutographs' table. You can move, or remove it, as needed.
            this.nicksAutographsTableAdapter.Fill(this.autographCollectionDataSet.NicksAutographs);
       

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnShowPics_Click(object sender, EventArgs e)
        {
            PicturesForm pform = new PicturesForm();
            pform.Show();
        }

        private void btnCustDisp_Click(object sender, EventArgs e)
        {
            CustomShowDB csdb = new CustomShowDB();
            csdb.Show();
        }

        private void Home_Click(object sender, EventArgs e)
        {
            HomeForm hf = new HomeForm();
            hf.Show();
        }
    }
}
