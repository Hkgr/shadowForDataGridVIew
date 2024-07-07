namespace WindowsFormsApp1
{
    partial class Form1
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
            this.table1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tESTINGDataSet = new WindowsFormsApp1.TESTINGDataSet();
            this.tempdbDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tempdbDataSet = new WindowsFormsApp1.tempdbDataSet();
            this.table_1TableAdapter = new WindowsFormsApp1.TESTINGDataSetTableAdapters.Table_1TableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tESTINGDataSet1 = new WindowsFormsApp1.TESTINGDataSet1();
            this.table1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.table_1TableAdapter1 = new WindowsFormsApp1.TESTINGDataSet1TableAdapters.Table_1TableAdapter();
            this.tESTINGDataSet2 = new WindowsFormsApp1.TESTINGDataSet();
            this.tESTINGDataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.table1BindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.nAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bUNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tESTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.testsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.table1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tESTINGDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tempdbDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tempdbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tESTINGDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table1BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tESTINGDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tESTINGDataSet2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table1BindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // table1BindingSource
            // 
            this.table1BindingSource.DataMember = "Table_1";
            this.table1BindingSource.DataSource = this.tESTINGDataSet;
            // 
            // tESTINGDataSet
            // 
            this.tESTINGDataSet.DataSetName = "TESTINGDataSet";
            this.tESTINGDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tempdbDataSetBindingSource
            // 
            this.tempdbDataSetBindingSource.DataSource = this.tempdbDataSet;
            this.tempdbDataSetBindingSource.Position = 0;
            // 
            // tempdbDataSet
            // 
            this.tempdbDataSet.DataSetName = "tempdbDataSet";
            this.tempdbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // table_1TableAdapter
            // 
            this.table_1TableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nAMEDataGridViewTextBoxColumn,
            this.bUNDataGridViewTextBoxColumn,
            this.tESTDataGridViewTextBoxColumn,
            this.testsDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.table1BindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(67, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(485, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // tESTINGDataSet1
            // 
            this.tESTINGDataSet1.DataSetName = "TESTINGDataSet1";
            this.tESTINGDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // table1BindingSource1
            // 
            this.table1BindingSource1.DataMember = "Table_1";
            this.table1BindingSource1.DataSource = this.tESTINGDataSet1;
            // 
            // table_1TableAdapter1
            // 
            this.table_1TableAdapter1.ClearBeforeFill = true;
            // 
            // tESTINGDataSet2
            // 
            this.tESTINGDataSet2.DataSetName = "TESTINGDataSet";
            this.tESTINGDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tESTINGDataSet2BindingSource
            // 
            this.tESTINGDataSet2BindingSource.DataSource = this.tESTINGDataSet2;
            this.tESTINGDataSet2BindingSource.Position = 0;
            // 
            // table1BindingSource2
            // 
            this.table1BindingSource2.DataMember = "Table_1";
            this.table1BindingSource2.DataSource = this.tESTINGDataSet2BindingSource;
            // 
            // nAMEDataGridViewTextBoxColumn
            // 
            this.nAMEDataGridViewTextBoxColumn.DataPropertyName = "NAME";
            this.nAMEDataGridViewTextBoxColumn.HeaderText = "NAME";
            this.nAMEDataGridViewTextBoxColumn.Name = "nAMEDataGridViewTextBoxColumn";
            // 
            // bUNDataGridViewTextBoxColumn
            // 
            this.bUNDataGridViewTextBoxColumn.DataPropertyName = "BUN";
            this.bUNDataGridViewTextBoxColumn.HeaderText = "BUN";
            this.bUNDataGridViewTextBoxColumn.Name = "bUNDataGridViewTextBoxColumn";
            // 
            // tESTDataGridViewTextBoxColumn
            // 
            this.tESTDataGridViewTextBoxColumn.DataPropertyName = "TEST";
            this.tESTDataGridViewTextBoxColumn.HeaderText = "TEST";
            this.tESTDataGridViewTextBoxColumn.Name = "tESTDataGridViewTextBoxColumn";
            // 
            // testsDataGridViewTextBoxColumn
            // 
            this.testsDataGridViewTextBoxColumn.DataPropertyName = "tests";
            this.testsDataGridViewTextBoxColumn.HeaderText = "tests";
            this.testsDataGridViewTextBoxColumn.Name = "testsDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.table1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tESTINGDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tempdbDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tempdbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tESTINGDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table1BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tESTINGDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tESTINGDataSet2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table1BindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource tempdbDataSetBindingSource;
        private tempdbDataSet tempdbDataSet;
        private TESTINGDataSet tESTINGDataSet;
        private System.Windows.Forms.BindingSource table1BindingSource;
        private TESTINGDataSetTableAdapters.Table_1TableAdapter table_1TableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private TESTINGDataSet1 tESTINGDataSet1;
        private System.Windows.Forms.BindingSource table1BindingSource1;
        private TESTINGDataSet1TableAdapters.Table_1TableAdapter table_1TableAdapter1;
        private System.Windows.Forms.BindingSource tESTINGDataSet2BindingSource;
        private TESTINGDataSet tESTINGDataSet2;
        private System.Windows.Forms.BindingSource table1BindingSource2;
        private System.Windows.Forms.DataGridViewTextBoxColumn nAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bUNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tESTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn testsDataGridViewTextBoxColumn;
    }
}

