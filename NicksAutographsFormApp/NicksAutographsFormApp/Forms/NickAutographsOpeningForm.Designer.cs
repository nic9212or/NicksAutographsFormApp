namespace NicksAutographsFormApp
{
    partial class NickAutographsOpeningForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NickAutographsOpeningForm));
            this.btnSave = new System.Windows.Forms.Button();
            this.lblHeader = new System.Windows.Forms.Label();
            this.txtBoxCelebrityName = new System.Windows.Forms.TextBox();
            this.cmbBoxItem = new System.Windows.Forms.ComboBox();
            this.cmbBoxCategory = new System.Windows.Forms.ComboBox();
            this.lblCelebrity = new System.Windows.Forms.Label();
            this.lblItem = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblDescrip = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblAutoCost = new System.Windows.Forms.Label();
            this.lblItemCost = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dateTimePickerAutographAquired = new System.Windows.Forms.DateTimePicker();
            this.txtBoxAutoCost = new System.Windows.Forms.TextBox();
            this.txtBoxItemCost = new System.Windows.Forms.TextBox();
            this.txtBoxDesc = new System.Windows.Forms.TextBox();
            this.btnShowDb = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.groupBoxObtainedBy = new System.Windows.Forms.GroupBox();
            this.radioButtonGift = new System.Windows.Forms.RadioButton();
            this.radioButtonMail = new System.Windows.Forms.RadioButton();
            this.radioButtonPurchased = new System.Windows.Forms.RadioButton();
            this.radioButtonMySelf = new System.Windows.Forms.RadioButton();
            this.lblPicLink = new System.Windows.Forms.Label();
            this.txtBoxPicLink = new System.Windows.Forms.TextBox();
            this.btnCustShow = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBoxObtainedBy.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(393, 481);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(66, 18);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(229, 33);
            this.lblHeader.TabIndex = 1;
            this.lblHeader.Text = "Add Autograph:";
            // 
            // txtBoxCelebrityName
            // 
            this.txtBoxCelebrityName.Location = new System.Drawing.Point(130, 91);
            this.txtBoxCelebrityName.Name = "txtBoxCelebrityName";
            this.txtBoxCelebrityName.Size = new System.Drawing.Size(100, 20);
            this.txtBoxCelebrityName.TabIndex = 1;
            // 
            // cmbBoxItem
            // 
            this.cmbBoxItem.FormattingEnabled = true;
            this.cmbBoxItem.Location = new System.Drawing.Point(130, 113);
            this.cmbBoxItem.Name = "cmbBoxItem";
            this.cmbBoxItem.Size = new System.Drawing.Size(100, 21);
            this.cmbBoxItem.TabIndex = 2;
            // 
            // cmbBoxCategory
            // 
            this.cmbBoxCategory.FormattingEnabled = true;
            this.cmbBoxCategory.Location = new System.Drawing.Point(130, 164);
            this.cmbBoxCategory.Name = "cmbBoxCategory";
            this.cmbBoxCategory.Size = new System.Drawing.Size(100, 21);
            this.cmbBoxCategory.TabIndex = 3;
            // 
            // lblCelebrity
            // 
            this.lblCelebrity.AutoSize = true;
            this.lblCelebrity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCelebrity.Location = new System.Drawing.Point(37, 90);
            this.lblCelebrity.Name = "lblCelebrity";
            this.lblCelebrity.Size = new System.Drawing.Size(64, 16);
            this.lblCelebrity.TabIndex = 6;
            this.lblCelebrity.Text = "Celebrity:";
            // 
            // lblItem
            // 
            this.lblItem.AutoSize = true;
            this.lblItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItem.Location = new System.Drawing.Point(37, 113);
            this.lblItem.Name = "lblItem";
            this.lblItem.Size = new System.Drawing.Size(36, 16);
            this.lblItem.TabIndex = 8;
            this.lblItem.Text = "Item:";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.Location = new System.Drawing.Point(37, 166);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(66, 16);
            this.lblCategory.TabIndex = 9;
            this.lblCategory.Text = "Category:";
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(45, 481);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 14;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblDescrip
            // 
            this.lblDescrip.AutoSize = true;
            this.lblDescrip.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescrip.Location = new System.Drawing.Point(37, 201);
            this.lblDescrip.Name = "lblDescrip";
            this.lblDescrip.Size = new System.Drawing.Size(79, 16);
            this.lblDescrip.TabIndex = 11;
            this.lblDescrip.Text = "Description:";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(37, 337);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(90, 16);
            this.lblDate.TabIndex = 12;
            this.lblDate.Text = "Date Aquired:";
            // 
            // lblAutoCost
            // 
            this.lblAutoCost.AutoSize = true;
            this.lblAutoCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAutoCost.Location = new System.Drawing.Point(24, 368);
            this.lblAutoCost.Name = "lblAutoCost";
            this.lblAutoCost.Size = new System.Drawing.Size(103, 16);
            this.lblAutoCost.TabIndex = 13;
            this.lblAutoCost.Text = "Autograph Cost:";
            // 
            // lblItemCost
            // 
            this.lblItemCost.AutoSize = true;
            this.lblItemCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemCost.Location = new System.Drawing.Point(37, 406);
            this.lblItemCost.Name = "lblItemCost";
            this.lblItemCost.Size = new System.Drawing.Size(66, 16);
            this.lblItemCost.TabIndex = 14;
            this.lblItemCost.Text = "Item Cost:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(355, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(205, 176);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // dateTimePickerAutographAquired
            // 
            this.dateTimePickerAutographAquired.Location = new System.Drawing.Point(130, 338);
            this.dateTimePickerAutographAquired.Name = "dateTimePickerAutographAquired";
            this.dateTimePickerAutographAquired.Size = new System.Drawing.Size(180, 20);
            this.dateTimePickerAutographAquired.TabIndex = 5;
            // 
            // txtBoxAutoCost
            // 
            this.txtBoxAutoCost.Location = new System.Drawing.Point(130, 368);
            this.txtBoxAutoCost.Name = "txtBoxAutoCost";
            this.txtBoxAutoCost.Size = new System.Drawing.Size(100, 20);
            this.txtBoxAutoCost.TabIndex = 6;
            // 
            // txtBoxItemCost
            // 
            this.txtBoxItemCost.Location = new System.Drawing.Point(130, 400);
            this.txtBoxItemCost.Name = "txtBoxItemCost";
            this.txtBoxItemCost.Size = new System.Drawing.Size(100, 20);
            this.txtBoxItemCost.TabIndex = 7;
            // 
            // txtBoxDesc
            // 
            this.txtBoxDesc.Location = new System.Drawing.Point(130, 194);
            this.txtBoxDesc.Multiline = true;
            this.txtBoxDesc.Name = "txtBoxDesc";
            this.txtBoxDesc.Size = new System.Drawing.Size(240, 112);
            this.txtBoxDesc.TabIndex = 4;
            // 
            // btnShowDb
            // 
            this.btnShowDb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowDb.Location = new System.Drawing.Point(228, 481);
            this.btnShowDb.Name = "btnShowDb";
            this.btnShowDb.Size = new System.Drawing.Size(75, 23);
            this.btnShowDb.TabIndex = 13;
            this.btnShowDb.Text = "Show DB";
            this.btnShowDb.UseVisualStyleBackColor = true;
            this.btnShowDb.Click += new System.EventHandler(this.btnShowDb_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.Location = new System.Drawing.Point(390, 399);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 25);
            this.lblError.TabIndex = 21;
            // 
            // groupBoxObtainedBy
            // 
            this.groupBoxObtainedBy.Controls.Add(this.radioButtonGift);
            this.groupBoxObtainedBy.Controls.Add(this.radioButtonMail);
            this.groupBoxObtainedBy.Controls.Add(this.radioButtonPurchased);
            this.groupBoxObtainedBy.Controls.Add(this.radioButtonMySelf);
            this.groupBoxObtainedBy.Location = new System.Drawing.Point(342, 312);
            this.groupBoxObtainedBy.Name = "groupBoxObtainedBy";
            this.groupBoxObtainedBy.Size = new System.Drawing.Size(145, 126);
            this.groupBoxObtainedBy.TabIndex = 22;
            this.groupBoxObtainedBy.TabStop = false;
            this.groupBoxObtainedBy.Text = "Autograph Obtained by:";
            // 
            // radioButtonGift
            // 
            this.radioButtonGift.AutoSize = true;
            this.radioButtonGift.Location = new System.Drawing.Point(13, 97);
            this.radioButtonGift.Name = "radioButtonGift";
            this.radioButtonGift.Size = new System.Drawing.Size(41, 17);
            this.radioButtonGift.TabIndex = 11;
            this.radioButtonGift.TabStop = true;
            this.radioButtonGift.Text = "Gift";
            this.radioButtonGift.UseVisualStyleBackColor = true;
            // 
            // radioButtonMail
            // 
            this.radioButtonMail.AutoSize = true;
            this.radioButtonMail.Location = new System.Drawing.Point(13, 74);
            this.radioButtonMail.Name = "radioButtonMail";
            this.radioButtonMail.Size = new System.Drawing.Size(44, 17);
            this.radioButtonMail.TabIndex = 10;
            this.radioButtonMail.TabStop = true;
            this.radioButtonMail.Text = "Mail";
            this.radioButtonMail.UseVisualStyleBackColor = true;
            // 
            // radioButtonPurchased
            // 
            this.radioButtonPurchased.AutoSize = true;
            this.radioButtonPurchased.Location = new System.Drawing.Point(13, 51);
            this.radioButtonPurchased.Name = "radioButtonPurchased";
            this.radioButtonPurchased.Size = new System.Drawing.Size(76, 17);
            this.radioButtonPurchased.TabIndex = 9;
            this.radioButtonPurchased.TabStop = true;
            this.radioButtonPurchased.Text = "Purchased";
            this.radioButtonPurchased.UseVisualStyleBackColor = true;
            // 
            // radioButtonMySelf
            // 
            this.radioButtonMySelf.AutoSize = true;
            this.radioButtonMySelf.Location = new System.Drawing.Point(13, 28);
            this.radioButtonMySelf.Name = "radioButtonMySelf";
            this.radioButtonMySelf.Size = new System.Drawing.Size(55, 17);
            this.radioButtonMySelf.TabIndex = 8;
            this.radioButtonMySelf.TabStop = true;
            this.radioButtonMySelf.Text = "Myself";
            this.radioButtonMySelf.UseVisualStyleBackColor = true;
            // 
            // lblPicLink
            // 
            this.lblPicLink.AutoSize = true;
            this.lblPicLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPicLink.Location = new System.Drawing.Point(37, 444);
            this.lblPicLink.Name = "lblPicLink";
            this.lblPicLink.Size = new System.Drawing.Size(79, 16);
            this.lblPicLink.TabIndex = 23;
            this.lblPicLink.Text = "Picture Link:";
            // 
            // txtBoxPicLink
            // 
            this.txtBoxPicLink.Location = new System.Drawing.Point(130, 444);
            this.txtBoxPicLink.Name = "txtBoxPicLink";
            this.txtBoxPicLink.Size = new System.Drawing.Size(357, 20);
            this.txtBoxPicLink.TabIndex = 24;
            // 
            // btnCustShow
            // 
            this.btnCustShow.Location = new System.Drawing.Point(228, 526);
            this.btnCustShow.Name = "btnCustShow";
            this.btnCustShow.Size = new System.Drawing.Size(75, 23);
            this.btnCustShow.TabIndex = 25;
            this.btnCustShow.Text = "Custom Show";
            this.btnCustShow.UseVisualStyleBackColor = true;
            this.btnCustShow.Click += new System.EventHandler(this.btnCustShow_Click);
            // 
            // NickAutographsOpeningForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(581, 561);
            this.Controls.Add(this.btnCustShow);
            this.Controls.Add(this.txtBoxPicLink);
            this.Controls.Add(this.lblPicLink);
            this.Controls.Add(this.groupBoxObtainedBy);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnShowDb);
            this.Controls.Add(this.txtBoxDesc);
            this.Controls.Add(this.txtBoxItemCost);
            this.Controls.Add(this.txtBoxAutoCost);
            this.Controls.Add(this.dateTimePickerAutographAquired);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblItemCost);
            this.Controls.Add(this.lblAutoCost);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblDescrip);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.lblItem);
            this.Controls.Add(this.lblCelebrity);
            this.Controls.Add(this.cmbBoxCategory);
            this.Controls.Add(this.cmbBoxItem);
            this.Controls.Add(this.txtBoxCelebrityName);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.btnSave);
            this.Name = "NickAutographsOpeningForm";
            this.Text = "Nicks Autographs";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBoxObtainedBy.ResumeLayout(false);
            this.groupBoxObtainedBy.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.TextBox txtBoxCelebrityName;
        private System.Windows.Forms.ComboBox cmbBoxItem;
        private System.Windows.Forms.ComboBox cmbBoxCategory;
        private System.Windows.Forms.Label lblCelebrity;
        private System.Windows.Forms.Label lblItem;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblDescrip;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblAutoCost;
        private System.Windows.Forms.Label lblItemCost;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker dateTimePickerAutographAquired;
        private System.Windows.Forms.TextBox txtBoxAutoCost;
        private System.Windows.Forms.TextBox txtBoxItemCost;
        private System.Windows.Forms.TextBox txtBoxDesc;
        private System.Windows.Forms.Button btnShowDb;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.GroupBox groupBoxObtainedBy;
        private System.Windows.Forms.RadioButton radioButtonGift;
        private System.Windows.Forms.RadioButton radioButtonMail;
        private System.Windows.Forms.RadioButton radioButtonPurchased;
        private System.Windows.Forms.RadioButton radioButtonMySelf;
        private System.Windows.Forms.Label lblPicLink;
        private System.Windows.Forms.TextBox txtBoxPicLink;
        private System.Windows.Forms.Button btnCustShow;
    }
}

