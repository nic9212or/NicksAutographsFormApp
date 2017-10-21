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
    public partial class PicturesForm : Form
    {
        public PicturesForm()
        {
            InitializeComponent();

            //get rows where picture link is not null
            //display rows

            //when selecting row; have clickable link
            //https://msdn.microsoft.com/en-us/library/cc304466.aspx
        }

        private void linkLabelPhotoSelected_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //get image selected
            //make link 
            try
            {
                System.Diagnostics.Process.Start("https://www.flickr.com/photos/152389030@N07/");
            }
            catch { }
        }
    }
}
