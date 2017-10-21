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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.celebrityNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateAquiredDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.autographCostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemCostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nicksAutographsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.autographCollectionDataSet = new NicksAutographsFormApp.AutographCollectionDataSet();
            this.nicksAutographsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nicksAutographsTableAdapter = new NicksAutographsFormApp.AutographCollectionDataSetTableAdapters.NicksAutographsTableAdapter();
            this.Home = new System.Windows.Forms.Button();
            this.btnCustDisp = new System.Windows.Forms.Button();
            this.btnShowPics = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nicksAutographsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autographCollectionDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nicksAutographsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.celebrityNameDataGridViewTextBoxColumn,
            this.itemDataGridViewTextBoxColumn,
            this.categoryDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.dateAquiredDataGridViewTextBoxColumn,
            this.autographCostDataGridViewTextBoxColumn,
            this.itemCostDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.nicksAutographsBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(747, 372);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            // nicksAutographsBindingSource1
            // 
            this.nicksAutographsBindingSource1.DataMember = "NicksAutographs";
            this.nicksAutographsBindingSource1.DataSource = this.autographCollectionDataSet;
            // 
            // autographCollectionDataSet
            // 
            this.autographCollectionDataSet.DataSetName = "AutographCollectionDataSet";
            this.autographCollectionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nicksAutographsBindingSource
            // 
            this.nicksAutographsBindingSource.DataMember = "NicksAutographs";
            this.nicksAutographsBindingSource.DataSource = this.autographCollectionDataSet;
            // 
            // nicksAutographsTableAdapter
            // 
            this.nicksAutographsTableAdapter.ClearBeforeFill = true;
            // 
            // Home
            // 
            this.Home.Location = new System.Drawing.Point(94, 465);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(75, 23);
            this.Home.TabIndex = 1;
            this.Home.Text = "btnHome";
            this.Home.UseVisualStyleBackColor = true;
            this.Home.Click += new System.EventHandler(this.Home_Click);
            // 
            // btnCustDisp
            // 
            this.btnCustDisp.Location = new System.Drawing.Point(286, 465);
            this.btnCustDisp.Name = "btnCustDisp";
            this.btnCustDisp.Size = new System.Drawing.Size(156, 23);
            this.btnCustDisp.TabIndex = 2;
            this.btnCustDisp.Text = "Filter Columns";
            this.btnCustDisp.UseVisualStyleBackColor = true;
            this.btnCustDisp.Click += new System.EventHandler(this.btnCustDisp_Click);
            // 
            // btnShowPics
            // 
            this.btnShowPics.Location = new System.Drawing.Point(480, 465);
            this.btnShowPics.Name = "btnShowPics";
            this.btnShowPics.Size = new System.Drawing.Size(115, 23);
            this.btnShowPics.TabIndex = 3;
            this.btnShowPics.Text = "Show Pictures";
            this.btnShowPics.UseVisualStyleBackColor = true;
            this.btnShowPics.Click += new System.EventHandler(this.btnShowPics_Click);
            // 
            // DBForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 579);
            this.Controls.Add(this.btnShowPics);
            this.Controls.Add(this.btnCustDisp);
            this.Controls.Add(this.Home);
            this.Controls.Add(this.dataGridView1);
            this.Name = "DBForm";
            this.Text = "ShowDB";
            this.Load += new System.EventHandler(this.DBForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nicksAutographsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autographCollectionDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nicksAutographsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private AutographCollectionDataSet autographCollectionDataSet;
        private System.Windows.Forms.BindingSource nicksAutographsBindingSource;
        private AutographCollectionDataSetTableAdapters.NicksAutographsTableAdapter nicksAutographsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn celebrityNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateAquiredDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn autographCostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemCostDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource nicksAutographsBindingSource1;
        private System.Windows.Forms.Button Home;
        private System.Windows.Forms.Button btnCustDisp;
        private System.Windows.Forms.Button btnShowPics;
    }
}