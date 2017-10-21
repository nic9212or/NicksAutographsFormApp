namespace NicksAutographsFormApp
{
    partial class PicturesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.linkLabelPhotoSelected = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // linkLabelPhotoSelected
            // 
            this.linkLabelPhotoSelected.AutoSize = true;
            this.linkLabelPhotoSelected.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelPhotoSelected.Location = new System.Drawing.Point(109, 313);
            this.linkLabelPhotoSelected.Name = "linkLabelPhotoSelected";
            this.linkLabelPhotoSelected.Size = new System.Drawing.Size(91, 16);
            this.linkLabelPhotoSelected.TabIndex = 0;
            this.linkLabelPhotoSelected.TabStop = true;
            this.linkLabelPhotoSelected.Text = "Flickr Account";
            this.linkLabelPhotoSelected.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelPhotoSelected_LinkClicked);
            // 
            // PicturesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 463);
            this.Controls.Add(this.linkLabelPhotoSelected);
            this.Name = "PicturesForm";
            this.Text = "PicturesForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabelPhotoSelected;
    }
}