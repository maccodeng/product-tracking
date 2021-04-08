namespace SATIŞ_UYGULAMA
{
    partial class raporlarfrm
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(raporlarfrm));
            this.satıslar11BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DbsatısDataSet111 = new SATIŞ_UYGULAMA.DbsatısDataSet111();
            this.urunlerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DbsatısDataSet = new SATIŞ_UYGULAMA.DbsatısDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.urunlerTableAdapter = new SATIŞ_UYGULAMA.DbsatısDataSetTableAdapters.urunlerTableAdapter();
            this.satıslar11TableAdapter = new SATIŞ_UYGULAMA.DbsatısDataSet111TableAdapters.satıslar11TableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.satıselemanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.satıselemanTableAdapter = new SATIŞ_UYGULAMA.DbsatısDataSetTableAdapters.satıselemanTableAdapter();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.yoneticiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yoneticiTableAdapter = new SATIŞ_UYGULAMA.DbsatısDataSetTableAdapters.yoneticiTableAdapter();
            this.depocuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.depocuTableAdapter = new SATIŞ_UYGULAMA.DbsatısDataSetTableAdapters.depocuTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.satıslar11BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DbsatısDataSet111)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunlerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DbsatısDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.satıselemanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yoneticiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.depocuBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // satıslar11BindingSource
            // 
            this.satıslar11BindingSource.DataMember = "satıslar11";
            this.satıslar11BindingSource.DataSource = this.DbsatısDataSet111;
            // 
            // DbsatısDataSet111
            // 
            this.DbsatısDataSet111.DataSetName = "DbsatısDataSet111";
            this.DbsatısDataSet111.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // urunlerBindingSource
            // 
            this.urunlerBindingSource.DataMember = "urunler";
            this.urunlerBindingSource.DataSource = this.DbsatısDataSet;
            this.urunlerBindingSource.CurrentChanged += new System.EventHandler(this.urunlerBindingSource_CurrentChanged);
            // 
            // DbsatısDataSet
            // 
            this.DbsatısDataSet.DataSetName = "DbsatısDataSet";
            this.DbsatısDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.reportViewer1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.reportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            reportDataSource1.Name = "dataset1";
            reportDataSource1.Value = this.satıslar11BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SATIŞ_UYGULAMA.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 24);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(840, 618);
            this.reportViewer1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(840, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(819, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // urunlerTableAdapter
            // 
            this.urunlerTableAdapter.ClearBeforeFill = true;
            // 
            // satıslar11TableAdapter
            // 
            this.satıslar11TableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(744, 659);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 29);
            this.button1.TabIndex = 4;
            this.button1.Text = "Getir";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.satıselemanBindingSource;
            this.comboBox1.DisplayMember = "adı";
            this.comboBox1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(617, 661);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.ValueMember = "id";
            // 
            // satıselemanBindingSource
            // 
            this.satıselemanBindingSource.DataMember = "satıseleman";
            this.satıselemanBindingSource.DataSource = this.DbsatısDataSet;
            // 
            // satıselemanTableAdapter
            // 
            this.satıselemanTableAdapter.ClearBeforeFill = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioButton1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.radioButton1.Location = new System.Drawing.Point(101, 662);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(72, 20);
            this.radioButton1.TabIndex = 7;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Ürünler";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioButton2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.radioButton2.Location = new System.Drawing.Point(12, 662);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(73, 20);
            this.radioButton2.TabIndex = 7;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Satışlar";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioButton3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.radioButton3.Location = new System.Drawing.Point(191, 662);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(80, 20);
            this.radioButton3.TabIndex = 7;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Personel";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBox2.ForeColor = System.Drawing.SystemColors.MenuText;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Yönetici",
            "Satış Danışmanı",
            "Depo Görevlisi"});
            this.comboBox2.Location = new System.Drawing.Point(289, 661);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(128, 24);
            this.comboBox2.TabIndex = 8;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(520, 666);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Satış Yapan Kişi";
            // 
            // yoneticiBindingSource
            // 
            this.yoneticiBindingSource.DataMember = "yonetici";
            this.yoneticiBindingSource.DataSource = this.DbsatısDataSet;
            // 
            // yoneticiTableAdapter
            // 
            this.yoneticiTableAdapter.ClearBeforeFill = true;
            // 
            // depocuBindingSource
            // 
            this.depocuBindingSource.DataMember = "depocu";
            this.depocuBindingSource.DataSource = this.DbsatısDataSet;
            // 
            // depocuTableAdapter
            // 
            this.depocuTableAdapter.ClearBeforeFill = true;
            // 
            // raporlarfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Crimson;
            this.ClientSize = new System.Drawing.Size(840, 700);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "raporlarfrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "raporlarfrm";
            this.Load += new System.EventHandler(this.raporlarfrm_Load);
            this.Click += new System.EventHandler(this.raporlarfrm_Click);
            ((System.ComponentModel.ISupportInitialize)(this.satıslar11BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DbsatısDataSet111)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunlerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DbsatısDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.satıselemanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yoneticiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.depocuBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource satıslar11BindingSource;
        private DbsatısDataSet111 DbsatısDataSet111;
        private DbsatısDataSet111TableAdapters.satıslar11TableAdapter satıslar11TableAdapter;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label label1;
        public Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource urunlerBindingSource;
        private DbsatısDataSet DbsatısDataSet;
        private DbsatısDataSetTableAdapters.urunlerTableAdapter urunlerTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource satıselemanBindingSource;
        private DbsatısDataSetTableAdapters.satıselemanTableAdapter satıselemanTableAdapter;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource yoneticiBindingSource;
        private DbsatısDataSetTableAdapters.yoneticiTableAdapter yoneticiTableAdapter;
        private System.Windows.Forms.BindingSource depocuBindingSource;
        private DbsatısDataSetTableAdapters.depocuTableAdapter depocuTableAdapter;
    }
}