namespace SATIŞ_UYGULAMA
{
    partial class satıslarlistefrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(satıslarlistefrm));
            this.satıslar11BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbsatısDataSet111 = new SATIŞ_UYGULAMA.DbsatısDataSet111();
            this.satıslar11TableAdapter = new SATIŞ_UYGULAMA.DbsatısDataSet111TableAdapters.satıslar11TableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adetDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.satanDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarihDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tücretDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.satıslar11BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbsatısDataSet111)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // satıslar11BindingSource
            // 
            this.satıslar11BindingSource.DataMember = "satıslar11";
            this.satıslar11BindingSource.DataSource = this.dbsatısDataSet111;
            // 
            // dbsatısDataSet111
            // 
            this.dbsatısDataSet111.DataSetName = "DbsatısDataSet111";
            this.dbsatısDataSet111.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // satıslar11TableAdapter
            // 
            this.satıslar11TableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(671, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.urunDataGridViewTextBoxColumn1,
            this.adetDataGridViewTextBoxColumn1,
            this.satanDataGridViewTextBoxColumn1,
            this.tarihDataGridViewTextBoxColumn1,
            this.tücretDataGridViewTextBoxColumn1});
            this.dataGridView2.DataSource = this.satıslar11BindingSource;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView2.Location = new System.Drawing.Point(0, 62);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(698, 318);
            this.dataGridView2.TabIndex = 2;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "Satış ID";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // urunDataGridViewTextBoxColumn1
            // 
            this.urunDataGridViewTextBoxColumn1.DataPropertyName = "urun";
            this.urunDataGridViewTextBoxColumn1.HeaderText = "Ürün Kodu";
            this.urunDataGridViewTextBoxColumn1.Name = "urunDataGridViewTextBoxColumn1";
            // 
            // adetDataGridViewTextBoxColumn1
            // 
            this.adetDataGridViewTextBoxColumn1.DataPropertyName = "adet";
            this.adetDataGridViewTextBoxColumn1.HeaderText = "Satılan Adet";
            this.adetDataGridViewTextBoxColumn1.Name = "adetDataGridViewTextBoxColumn1";
            // 
            // satanDataGridViewTextBoxColumn1
            // 
            this.satanDataGridViewTextBoxColumn1.DataPropertyName = "satan";
            this.satanDataGridViewTextBoxColumn1.HeaderText = "Satan";
            this.satanDataGridViewTextBoxColumn1.Name = "satanDataGridViewTextBoxColumn1";
            // 
            // tarihDataGridViewTextBoxColumn1
            // 
            this.tarihDataGridViewTextBoxColumn1.DataPropertyName = "tarih";
            this.tarihDataGridViewTextBoxColumn1.HeaderText = "Satış Tarihi";
            this.tarihDataGridViewTextBoxColumn1.Name = "tarihDataGridViewTextBoxColumn1";
            // 
            // tücretDataGridViewTextBoxColumn1
            // 
            this.tücretDataGridViewTextBoxColumn1.DataPropertyName = "tücret";
            this.tücretDataGridViewTextBoxColumn1.HeaderText = "Satış Ücreti";
            this.tücretDataGridViewTextBoxColumn1.Name = "tücretDataGridViewTextBoxColumn1";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Firebrick;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(312, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 31);
            this.button1.TabIndex = 3;
            this.button1.Text = "Rapor Al";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // satıslarlistefrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(698, 380);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "satıslarlistefrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Satış Listesi";
            this.Load += new System.EventHandler(this.satıslarlistefrm_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.satıslarlistefrm_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.satıslar11BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbsatısDataSet111)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DbsatısDataSet111 dbsatısDataSet111;
        private System.Windows.Forms.BindingSource satıslar11BindingSource;
        private DbsatısDataSet111TableAdapters.satıslar11TableAdapter satıslar11TableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn adetDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn satanDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarihDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tücretDataGridViewTextBoxColumn1;
        private System.Windows.Forms.Button button1;
    }
}