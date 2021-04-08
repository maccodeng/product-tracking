namespace SATIŞ_UYGULAMA
{
    partial class satıslarfrm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(satıslarfrm));
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.urunkoduDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.markaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kategoriDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alısfiyatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kdvoranDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.karoranDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.satısfiyatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stokadetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kayıtyapanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunlerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbsatısDataSet = new SATIŞ_UYGULAMA.DbsatısDataSet();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.satıslarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.satıslarTableAdapter = new SATIŞ_UYGULAMA.DbsatısDataSetTableAdapters.satıslarTableAdapter();
            this.urunlerTableAdapter = new SATIŞ_UYGULAMA.DbsatısDataSetTableAdapters.urunlerTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunlerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbsatısDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.satıslarBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.InactiveCaptionText;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.urunkoduDataGridViewTextBoxColumn,
            this.markaDataGridViewTextBoxColumn,
            this.modelDataGridViewTextBoxColumn,
            this.kategoriDataGridViewTextBoxColumn,
            this.alısfiyatDataGridViewTextBoxColumn,
            this.kdvoranDataGridViewTextBoxColumn,
            this.karoranDataGridViewTextBoxColumn,
            this.satısfiyatDataGridViewTextBoxColumn,
            this.stokadetDataGridViewTextBoxColumn,
            this.kayıtyapanDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.urunlerBindingSource;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView2.Location = new System.Drawing.Point(0, 207);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(824, 212);
            this.dataGridView2.TabIndex = 1;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // urunkoduDataGridViewTextBoxColumn
            // 
            this.urunkoduDataGridViewTextBoxColumn.DataPropertyName = "urunkodu";
            this.urunkoduDataGridViewTextBoxColumn.HeaderText = "Ürün Kodu";
            this.urunkoduDataGridViewTextBoxColumn.Name = "urunkoduDataGridViewTextBoxColumn";
            // 
            // markaDataGridViewTextBoxColumn
            // 
            this.markaDataGridViewTextBoxColumn.DataPropertyName = "marka";
            this.markaDataGridViewTextBoxColumn.HeaderText = "Marka";
            this.markaDataGridViewTextBoxColumn.Name = "markaDataGridViewTextBoxColumn";
            // 
            // modelDataGridViewTextBoxColumn
            // 
            this.modelDataGridViewTextBoxColumn.DataPropertyName = "model";
            this.modelDataGridViewTextBoxColumn.HeaderText = "Model";
            this.modelDataGridViewTextBoxColumn.Name = "modelDataGridViewTextBoxColumn";
            // 
            // kategoriDataGridViewTextBoxColumn
            // 
            this.kategoriDataGridViewTextBoxColumn.DataPropertyName = "kategori";
            this.kategoriDataGridViewTextBoxColumn.HeaderText = "Kategori";
            this.kategoriDataGridViewTextBoxColumn.Name = "kategoriDataGridViewTextBoxColumn";
            // 
            // alısfiyatDataGridViewTextBoxColumn
            // 
            this.alısfiyatDataGridViewTextBoxColumn.DataPropertyName = "alısfiyat";
            this.alısfiyatDataGridViewTextBoxColumn.HeaderText = "alısfiyat";
            this.alısfiyatDataGridViewTextBoxColumn.Name = "alısfiyatDataGridViewTextBoxColumn";
            this.alısfiyatDataGridViewTextBoxColumn.Visible = false;
            // 
            // kdvoranDataGridViewTextBoxColumn
            // 
            this.kdvoranDataGridViewTextBoxColumn.DataPropertyName = "kdvoran";
            this.kdvoranDataGridViewTextBoxColumn.HeaderText = "kdvoran";
            this.kdvoranDataGridViewTextBoxColumn.Name = "kdvoranDataGridViewTextBoxColumn";
            this.kdvoranDataGridViewTextBoxColumn.Visible = false;
            // 
            // karoranDataGridViewTextBoxColumn
            // 
            this.karoranDataGridViewTextBoxColumn.DataPropertyName = "karoran";
            this.karoranDataGridViewTextBoxColumn.HeaderText = "karoran";
            this.karoranDataGridViewTextBoxColumn.Name = "karoranDataGridViewTextBoxColumn";
            this.karoranDataGridViewTextBoxColumn.Visible = false;
            // 
            // satısfiyatDataGridViewTextBoxColumn
            // 
            this.satısfiyatDataGridViewTextBoxColumn.DataPropertyName = "satısfiyat";
            this.satısfiyatDataGridViewTextBoxColumn.HeaderText = "Fiyatı";
            this.satısfiyatDataGridViewTextBoxColumn.Name = "satısfiyatDataGridViewTextBoxColumn";
            // 
            // stokadetDataGridViewTextBoxColumn
            // 
            this.stokadetDataGridViewTextBoxColumn.DataPropertyName = "stokadet";
            this.stokadetDataGridViewTextBoxColumn.HeaderText = "Stok Adeti";
            this.stokadetDataGridViewTextBoxColumn.Name = "stokadetDataGridViewTextBoxColumn";
            // 
            // kayıtyapanDataGridViewTextBoxColumn
            // 
            this.kayıtyapanDataGridViewTextBoxColumn.DataPropertyName = "kayıtyapan";
            this.kayıtyapanDataGridViewTextBoxColumn.HeaderText = "kayıtyapan";
            this.kayıtyapanDataGridViewTextBoxColumn.Name = "kayıtyapanDataGridViewTextBoxColumn";
            this.kayıtyapanDataGridViewTextBoxColumn.Visible = false;
            // 
            // urunlerBindingSource
            // 
            this.urunlerBindingSource.DataMember = "urunler";
            this.urunlerBindingSource.DataSource = this.dbsatısDataSet;
            // 
            // dbsatısDataSet
            // 
            this.dbsatısDataSet.DataSetName = "DbsatısDataSet";
            this.dbsatısDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(116, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(134, 23);
            this.textBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(22, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ürün Kodu";
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox2.Location = new System.Drawing.Point(116, 58);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(134, 23);
            this.textBox2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(50, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Marka";
            // 
            // textBox3
            // 
            this.textBox3.Enabled = false;
            this.textBox3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox3.Location = new System.Drawing.Point(116, 87);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(134, 23);
            this.textBox3.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(50, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Model";
            // 
            // textBox4
            // 
            this.textBox4.Enabled = false;
            this.textBox4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox4.Location = new System.Drawing.Point(116, 116);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(134, 23);
            this.textBox4.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(36, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Kategori";
            // 
            // textBox5
            // 
            this.textBox5.Enabled = false;
            this.textBox5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox5.Location = new System.Drawing.Point(116, 145);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(134, 23);
            this.textBox5.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(62, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Fiyatı";
            // 
            // textBox6
            // 
            this.textBox6.Enabled = false;
            this.textBox6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox6.Location = new System.Drawing.Point(116, 174);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(134, 23);
            this.textBox6.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(25, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "Stok Adeti";
            // 
            // textBox7
            // 
            this.textBox7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox7.Location = new System.Drawing.Point(377, 29);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(134, 23);
            this.textBox7.TabIndex = 2;
            this.textBox7.Click += new System.EventHandler(this.textBox7_Click);
            this.textBox7.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(276, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 20);
            this.label7.TabIndex = 3;
            this.label7.Text = "Satılan Adet";
            // 
            // textBox8
            // 
            this.textBox8.Enabled = false;
            this.textBox8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox8.Location = new System.Drawing.Point(377, 58);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(134, 23);
            this.textBox8.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(322, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 20);
            this.label8.TabIndex = 3;
            this.label8.Text = "Satan";
            // 
            // textBox9
            // 
            this.textBox9.Enabled = false;
            this.textBox9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox9.Location = new System.Drawing.Point(377, 87);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(134, 23);
            this.textBox9.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(331, 87);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 20);
            this.label9.TabIndex = 3;
            this.label9.Text = "Tarih";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DimGray;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(378, 145);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 39);
            this.button1.TabIndex = 4;
            this.button1.Text = "SAT";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(796, 2);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(26, 25);
            this.label10.TabIndex = 3;
            this.label10.Text = "X";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            this.label10.MouseLeave += new System.EventHandler(this.label10_MouseLeave);
            this.label10.MouseHover += new System.EventHandler(this.label10_MouseHover);
            // 
            // textBox10
            // 
            this.textBox10.Enabled = false;
            this.textBox10.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox10.Location = new System.Drawing.Point(377, 116);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(134, 23);
            this.textBox10.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(267, 116);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(105, 20);
            this.label11.TabIndex = 3;
            this.label11.Text = "Toplam Ücret";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // satıslarBindingSource
            // 
            this.satıslarBindingSource.DataMember = "satıslar";
            this.satıslarBindingSource.DataSource = this.dbsatısDataSet;
            // 
            // satıslarTableAdapter
            // 
            this.satıslarTableAdapter.ClearBeforeFill = true;
            // 
            // urunlerTableAdapter
            // 
            this.urunlerTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.radioButton3);
            this.panel1.Controls.Add(this.radioButton2);
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Controls.Add(this.textBox11);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Location = new System.Drawing.Point(528, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(272, 109);
            this.panel1.TabIndex = 5;
            // 
            // textBox11
            // 
            this.textBox11.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox11.Location = new System.Drawing.Point(50, 28);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(174, 21);
            this.textBox11.TabIndex = 0;
            this.textBox11.TextChanged += new System.EventHandler(this.textBox11_TextChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioButton1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.radioButton1.Location = new System.Drawing.Point(12, 60);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(83, 20);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Ürün Kodu";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioButton2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.radioButton2.Location = new System.Drawing.Point(195, 60);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(61, 20);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Model";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioButton3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.radioButton3.Location = new System.Drawing.Point(113, 60);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(61, 20);
            this.radioButton3.TabIndex = 1;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Marka";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label12.Location = new System.Drawing.Point(89, 5);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(96, 20);
            this.label12.TabIndex = 3;
            this.label12.Text = "Ürün Arama";
            // 
            // satıslarfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(824, 419);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "satıslarfrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "satıslarfrm";
            this.Load += new System.EventHandler(this.satıslarfrm_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.satıslarfrm_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunlerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbsatısDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.satıslarBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DbsatısDataSet dbsatısDataSet;
        private System.Windows.Forms.BindingSource satıslarBindingSource;
        private DbsatısDataSetTableAdapters.satıslarTableAdapter satıslarTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource urunlerBindingSource;
        private DbsatısDataSetTableAdapters.urunlerTableAdapter urunlerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunkoduDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn markaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kategoriDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alısfiyatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kdvoranDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn karoranDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn satısfiyatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stokadetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kayıtyapanDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label12;
    }
}