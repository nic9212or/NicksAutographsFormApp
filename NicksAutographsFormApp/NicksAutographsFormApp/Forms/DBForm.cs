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
    //https://www.youtube.com/watch?time_continue=801&v=w5vZiemB06c
    public partial class DBForm : Form
    {
        AutographCollectionEntities db = new AutographCollectionEntities();

        public DBForm()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            dataGridViewFilterBy.DataSource = db.NicksAutographs.ToList();
        }

        private void DBForm_Load(object sender, EventArgs e)
        {
            comboBoxCategory.DataSource = db.NicksAutographs.ToList();
        }

        private void comboBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridViewFilterBy.DataSource = db.NicksAutographs.Where(x => x.AutographID == comboBoxCategory.SelectedIndex).ToList();
        }

        private void textBoxItem_TextChanged(object sender, EventArgs e)
        {
            dataGridViewFilterBy.DataSource = db.NicksAutographs.Where(x => x.Item.Contains(textBoxItem.Text)).ToList();
        }
    }
}
