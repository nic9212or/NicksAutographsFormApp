namespace NicksAutographsFormApp
{
    partial class DBForm
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
            this.components = new System.ComponentModel.Container();
            this.lblFilterBy = new System.Windows.Forms.Label();
            this.textBoxItem = new System.Windows.Forms.TextBox();
            this.textBoxCategory = new System.Windows.Forms.TextBox();
            this.lblCat = new System.Windows.Forms.Label();
            this.lblItem = new System.Windows.Forms.Label();
            this.dataGridViewFilterBy = new System.Windows.Forms.DataGridView();
            this.nicksAutographBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnShow = new System.Windows.Forms.Button();
            this.autographCollectionEntitiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.autographCollectionEntitiesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new NicksAutographsFormApp.DataSet1();
            this.dataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.celebrityNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateAquiredDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.autographCostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemCostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.obtainedByDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureLinkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateRecorededDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFilterBy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nicksAutographBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autographCollectionEntitiesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autographCollectionEntitiesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFilterBy
            // 
            this.lblFilterBy.AutoSize = true;
            this.lblFilterBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilterBy.Location = new System.Drawing.Point(344, 9);
            this.lblFilterBy.Name = "lblFilterBy";
            this.lblFilterBy.Size = new System.Drawing.Size(142, 37);
            this.lblFilterBy.TabIndex = 0;
            this.lblFilterBy.Text = "Filter By";
            // 
            // textBoxItem
            // 
            this.textBoxItem.Location = new System.Drawing.Point(364, 92);
            this.textBoxItem.Name = "textBoxItem";
            this.textBoxItem.Size = new System.Drawing.Size(100, 20);
            this.textBoxItem.TabIndex = 2;
            this.textBoxItem.TextChanged += new System.EventHandler(this.textBoxItem_TextChanged);
            // 
            // textBoxCategory
            // 
            this.textBoxCategory.Location = new System.Drawing.Point(204, 92);
            this.textBoxCategory.Name = "textBoxCategory";
            this.textBoxCategory.Size = new System.Drawing.Size(100, 20);
            this.textBoxCategory.TabIndex = 3;
            // 
            // lblCat
            // 
            this.lblCat.AutoSize = true;
            this.lblCat.Location = new System.Drawing.Point(148, 62);
            this.lblCat.Name = "lblCat";
            this.lblCat.Size = new System.Drawing.Size(52, 13);
            this.lblCat.TabIndex = 4;
            this.lblCat.Text = "Category:";
            // 
            // lblItem
            // 
            this.lblItem.AutoSize = true;
            this.lblItem.Location = new System.Drawing.Point(361, 62);
            this.lblItem.Name = "lblItem";
            this.lblItem.Size = new System.Drawing.Size(30, 13);
            this.lblItem.TabIndex = 5;
            this.lblItem.Text = "Item:";
            // 
            // dataGridViewFilterBy
            // 
            this.dataGridViewFilterBy.AutoGenerateColumns = false;
            this.dataGridViewFilterBy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFilterBy.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.celebrityNameDataGridViewTextBoxColumn,
            this.itemDataGridViewTextBoxColumn,
            this.categoryDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.dateAquiredDataGridViewTextBoxColumn,
            this.autographCostDataGridViewTextBoxColumn,
            this.itemCostDataGridViewTextBoxColumn,
            this.obtainedByDataGridViewTextBoxColumn,
            this.pictureLinkDataGridViewTextBoxColumn,
            this.dateRecorededDataGridViewTextBoxColumn});
            this.dataGridViewFilterBy.DataSource = this.nicksAutographBindingSource;
            this.dataGridViewFilterBy.Location = new System.Drawing.Point(2, 119);
            this.dataGridViewFilterBy.Name = "dataGridViewFilterBy";
            this.dataGridViewFilterBy.Size = new System.Drawing.Size(1044, 326);
            this.dataGridViewFilterBy.TabIndex = 6;
            // 
            // nicksAutographBindingSource
            // 
            this.nicksAutographBindingSource.DataSource = typeof(NicksAutographsFormApp.NicksAutograph);
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(364, 472);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(75, 23);
            this.btnShow.TabIndex = 7;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // autographCollectionEntitiesBindingSource
            // 
            this.autographCollectionEntitiesBindingSource.DataSource = typeof(NicksAutographsFormApp.AutographCollectionEntities);
            // 
            // autographCollectionEntitiesBindingSource1
            // 
            this.autographCollectionEntitiesBindingSource1.DataSource = typeof(NicksAutographsFormApp.AutographCollectionEntities);
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSet1BindingSource
            // 
            this.dataSet1BindingSource.DataSource = this.dataSet1;
            this.dataSet1BindingSource.Position = 0;
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.nicksAutographBindingSource, "AutographID", true));
            this.comboBoxCategory.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.nicksAutographBindingSource, "Category", true));
            this.comboBoxCategory.DataSource = this.nicksAutographBindingSource;
            this.comboBoxCategory.DisplayMember = "Category";
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Location = new System.Drawing.Point(62, 92);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCategory.TabIndex = 8;
            this.comboBoxCategory.ValueMember = "AutographID";
            this.comboBoxCategory.SelectedIndexChanged += new System.EventHandler(this.comboBoxCategory_SelectedIndexChanged);
            // 
            // celebrityNameDataGridViewTextBoxColumn
            // 
            this.celebrityNameDataGridViewTextBoxColumn.DataPropertyName = "CelebrityName";
            this.celebrityNameDataGridViewTextBoxColumn.HeaderText = "CelebrityName";
            this.celebrityNameDataGridViewTextBoxColumn.Name = "celebrityNameDataGridViewTextBoxColumn";
            // 
            // itemDataGridViewTextBoxColumn
            // 
            this.itemDataGridViewTextBoxColumn.DataPropertyName = "Item";
            this.itemDataGridViewTextBoxColumn.HeaderText = "Item";
            this.itemDataGridViewTextBoxColumn.Name = "itemDataGridViewTextBoxColumn";
            // 
            // categoryDataGridViewTextBoxColumn
            // 
            this.categoryDataGridViewTextBoxColumn.DataPropertyName = "Category";
            this.categoryDataGridViewTextBoxColumn.HeaderText = "Category";
            this.categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // dateAquiredDataGridViewTextBoxColumn
            // 
            this.dateAquiredDataGridViewTextBoxColumn.DataPropertyName = "DateAquired";
            this.dateAquiredDataGridViewTextBoxColumn.HeaderText = "DateAquired";
            this.dateAquiredDataGridViewTextBoxColumn.Name = "dateAquiredDataGridViewTextBoxColumn";
            // 
            // autographCostDataGridViewTextBoxColumn
            // 
            this.autographCostDataGridViewTextBoxColumn.DataPropertyName = "AutographCost";
            this.autographCostDataGridViewTextBoxColumn.HeaderText = "AutographCost";
            this.autographCostDataGridViewTextBoxColumn.Name = "autographCostDataGridViewTextBoxColumn";
            // 
            // itemCostDataGridViewTextBoxColumn
            // 
            this.itemCostDataGridViewTextBoxColumn.DataPropertyName = "ItemCost";
            this.itemCostDataGridViewTextBoxColumn.HeaderText = "ItemCost";
            this.itemCostDataGridViewTextBoxColumn.Name = "itemCostDataGridViewTextBoxColumn";
            // 
            // obtainedByDataGridViewTextBoxColumn
            // 
            this.obtainedByDataGridViewTextBoxColumn.DataPropertyName = "ObtainedBy";
            this.obtainedByDataGridViewTextBoxColumn.HeaderText = "ObtainedBy";
            this.obtainedByDataGridViewTextBoxColumn.Name = "obtainedByDataGridViewTextBoxColumn";
            // 
            // pictureLinkDataGridViewTextBoxColumn
            // 
            this.pictureLinkDataGridViewTextBoxColumn.DataPropertyName = "PictureLink";
            this.pictureLinkDataGridViewTextBoxColumn.HeaderText = "PictureLink";
            this.pictureLinkDataGridViewTextBoxColumn.Name = "pictureLinkDataGridViewTextBoxColumn";
            // 
            // dateRecorededDataGridViewTextBoxColumn
            // 
            this.dateRecorededDataGridViewTextBoxColumn.DataPropertyName = "DateRecoreded";
            this.dateRecorededDataGridViewTextBoxColumn.HeaderText = "DateRecoreded";
            this.dateRecorededDataGridViewTextBoxColumn.Name = "dateRecorededDataGridViewTextBoxColumn";
            // 
            // DBForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 538);
            this.Controls.Add(this.comboBoxCategory);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.dataGridViewFilterBy);
            this.Controls.Add(this.lblItem);
            this.Controls.Add(this.lblCat);
            this.Controls.Add(this.textBoxCategory);
            this.Controls.Add(this.textBoxItem);
            this.Controls.Add(this.lblFilterBy);
            this.Name = "DBForm";
            this.Text = "DBForm";
            this.Load += new System.EventHandler(this.DBForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFilterBy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nicksAutographBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autographCollectionEntitiesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autographCollectionEntitiesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFilterBy;
        private System.Windows.Forms.TextBox textBoxItem;
        private System.Windows.Forms.TextBox textBoxCategory;
        private System.Windows.Forms.Label lblCat;
        private System.Windows.Forms.Label lblItem;
        private System.Windows.Forms.DataGridView dataGridViewFilterBy;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.BindingSource dataSet1BindingSource;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource autographCollectionEntitiesBindingSource;
        private System.Windows.Forms.BindingSource autographCollectionEntitiesBindingSource1;
        private System.Windows.Forms.BindingSource nicksAutographBindingSource;
        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn celebrityNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateAquiredDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn autographCostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemCostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn obtainedByDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pictureLinkDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateRecorededDataGridViewTextBoxColumn;
    }
}