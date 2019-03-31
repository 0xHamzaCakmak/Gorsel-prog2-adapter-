namespace WindowsFormsApplication4
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.ticari = new WindowsFormsApplication4.Ticari();
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoryTableAdapter = new WindowsFormsApplication4.TicariTableAdapters.categoryTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.stokBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stokTableAdapter = new WindowsFormsApplication4.TicariTableAdapters.StokTableAdapter();
            this.stokidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stoknameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brfiyatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.catidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fKStokTocategoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ticari)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stokBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKStokTocategoryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.categoryBindingSource;
            this.comboBox1.DisplayMember = "cat_name";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(54, 37);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.ValueMember = "cat_id";
            // 
            // ticari
            // 
            this.ticari.DataSetName = "Ticari";
            this.ticari.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // categoryBindingSource
            // 
            this.categoryBindingSource.DataMember = "category";
            this.categoryBindingSource.DataSource = this.ticari;
            // 
            // categoryTableAdapter
            // 
            this.categoryTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stokidDataGridViewTextBoxColumn,
            this.stoknameDataGridViewTextBoxColumn,
            this.brfiyatDataGridViewTextBoxColumn,
            this.catidDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.fKStokTocategoryBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(28, 85);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(326, 150);
            this.dataGridView1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(279, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // stokBindingSource
            // 
            this.stokBindingSource.DataMember = "Stok";
            this.stokBindingSource.DataSource = this.ticari;
            // 
            // stokTableAdapter
            // 
            this.stokTableAdapter.ClearBeforeFill = true;
            // 
            // stokidDataGridViewTextBoxColumn
            // 
            this.stokidDataGridViewTextBoxColumn.DataPropertyName = "stok_id";
            this.stokidDataGridViewTextBoxColumn.HeaderText = "stok_id";
            this.stokidDataGridViewTextBoxColumn.Name = "stokidDataGridViewTextBoxColumn";
            this.stokidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stoknameDataGridViewTextBoxColumn
            // 
            this.stoknameDataGridViewTextBoxColumn.DataPropertyName = "stok_name";
            this.stoknameDataGridViewTextBoxColumn.HeaderText = "stok_name";
            this.stoknameDataGridViewTextBoxColumn.Name = "stoknameDataGridViewTextBoxColumn";
            // 
            // brfiyatDataGridViewTextBoxColumn
            // 
            this.brfiyatDataGridViewTextBoxColumn.DataPropertyName = "brfiyat";
            this.brfiyatDataGridViewTextBoxColumn.HeaderText = "brfiyat";
            this.brfiyatDataGridViewTextBoxColumn.Name = "brfiyatDataGridViewTextBoxColumn";
            // 
            // catidDataGridViewTextBoxColumn
            // 
            this.catidDataGridViewTextBoxColumn.DataPropertyName = "cat_id";
            this.catidDataGridViewTextBoxColumn.HeaderText = "cat_id";
            this.catidDataGridViewTextBoxColumn.Name = "catidDataGridViewTextBoxColumn";
            // 
            // fKStokTocategoryBindingSource
            // 
            this.fKStokTocategoryBindingSource.DataMember = "FK_Stok_To_category";
            this.fKStokTocategoryBindingSource.DataSource = this.categoryBindingSource;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 262);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ticari)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stokBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKStokTocategoryBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private Ticari ticari;
        private System.Windows.Forms.BindingSource categoryBindingSource;
        private TicariTableAdapters.categoryTableAdapter categoryTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource stokBindingSource;
        private TicariTableAdapters.StokTableAdapter stokTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn stokidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stoknameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brfiyatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn catidDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource fKStokTocategoryBindingSource;
    }
}

