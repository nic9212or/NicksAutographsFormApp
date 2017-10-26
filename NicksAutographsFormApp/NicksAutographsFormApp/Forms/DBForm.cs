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

              

        private void textBoxMin_TextChanged(object sender, EventArgs e)
        {
            double outMin;
            double outMax;
            Boolean canCvtMin;
            canCvtMin = double.TryParse(textBoxMinAuto.Text, out outMin);
            //canCvtAuto = double.TryParse(txtBoxAutoCost.Text, out outAuto);
            if (canCvtMin)
            {
               
            }


            //dataGridViewFilterBy.DataSource = db.NicksAutographs.Where(x => x.AutographCost.Value.CompareTo(outMin)).ToList();
            // dataGridViewFilterBy.DataSource = db.NicksAutographs.Where(x => x.AutographCost.Value.CompareTo(0.0000)).ToList();cant
            dataGridViewFilterBy.DataSource = db.NicksAutographs.Where(x => (x.AutographCost.Value <  (decimal)outMin)).ToList();

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxAutoPrNtSt_CheckedChanged(object sender, EventArgs e)
        {
            dataGridViewFilterBy.DataSource = db.NicksAutographs.Where(x => x.AutographCost.Value.Equals(0.0000)).ToList();

        }

        private void textBoxMaxAuto_TextChanged(object sender, EventArgs e)
        {
         
            double outMax;
            Boolean canCvtMin;
            canCvtMin = double.TryParse(textBoxMinAuto.Text, out outMax);
            dataGridViewFilterBy.DataSource = db.NicksAutographs.Where(x => (x.AutographCost.Value < (decimal)outMax)).ToList();
        }
    }
}
