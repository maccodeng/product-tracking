namespace SATIŞ_UYGULAMA
{
    partial class personelform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(personelform));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.satıselemanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbsatısDataSet = new SATIŞ_UYGULAMA.DbsatısDataSet();
            this.satıselemanTableAdapter = new SATIŞ_UYGULAMA.DbsatısDataSetTableAdapters.satıselemanTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kadıDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ksifreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adıDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soyadıDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.satıselemanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbsatısDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.kadıDataGridViewTextBoxColumn,
            this.ksifreDataGridViewTextBoxColumn,
            this.adıDataGridViewTextBoxColumn,
            this.soyadıDataGridViewTextBoxColumn,
            this.telefonDataGridViewTextBoxColumn,
            this.adresDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.satıselemanBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 222);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(864, 251);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Depocu",
            "Satış Danışmanı",
            "Yönetici"});
            this.comboBox1.Location = new System.Drawing.Point(173, 164);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(133, 24);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(65, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Cornsilk;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(12, 112);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 31);
            this.button1.TabIndex = 3;
            this.button1.Text = "Ekle";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(89, 26);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(142, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(7, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kullanıcı Adı";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(89, 52);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(142, 20);
            this.textBox2.TabIndex = 4;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(53, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Şifre";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(89, 78);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(142, 20);
            this.textBox3.TabIndex = 4;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(284, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Adı";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(316, 26);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(154, 20);
            this.textBox4.TabIndex = 4;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(267, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Soyadı";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(316, 52);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(154, 20);
            this.textBox5.TabIndex = 4;
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(263, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "Telefon";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(316, 76);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(154, 20);
            this.textBox6.TabIndex = 4;
            this.textBox6.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(272, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 17);
            this.label7.TabIndex = 2;
            this.label7.Text = "Adres";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(316, 102);
            this.textBox7.Multiline = true;
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(154, 91);
            this.textBox7.TabIndex = 4;
            this.textBox7.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Location = new System.Drawing.Point(183, 147);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 15);
            this.label8.TabIndex = 2;
            this.label8.Text = "Gösterilecek Kişiler";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Cornsilk;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(12, 149);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 31);
            this.button2.TabIndex = 3;
            this.button2.Text = "Sil";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Cornsilk;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.Location = new System.Drawing.Point(12, 185);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(88, 31);
            this.button3.TabIndex = 3;
            this.button3.Text = "Güncelle";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(95, 29);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(173, 20);
            this.textBox8.TabIndex = 5;
            this.textBox8.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(181)))), ((int)(((byte)(191)))));
            this.panel1.Controls.Add(this.radioButton3);
            this.panel1.Controls.Add(this.radioButton2);
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Controls.Add(this.textBox8);
            this.panel1.Controls.Add(this.label9);
            this.panel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Location = new System.Drawing.Point(476, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(376, 167);
            this.panel1.TabIndex = 6;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioButton3.Location = new System.Drawing.Point(262, 53);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(111, 20);
            this.radioButton3.TabIndex = 6;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Adrese göre ara";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.Click += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioButton2.Location = new System.Drawing.Point(119, 53);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(127, 20);
            this.radioButton2.TabIndex = 6;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Soyadına göre ara";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            this.radioButton2.Click += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioButton1.Location = new System.Drawing.Point(10, 53);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(103, 20);
            this.radioButton1.TabIndex = 6;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Ad\'a Göre ara";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.Click += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(142, 8);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 18);
            this.label9.TabIndex = 2;
            this.label9.Text = "ARAMA";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(843, 2);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(21, 20);
            this.label10.TabIndex = 7;
            this.label10.Text = "X";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            this.label10.MouseLeave += new System.EventHandler(this.label10_MouseLeave);
            this.label10.MouseHover += new System.EventHandler(this.label10_MouseHover);
            // 
            // satıselemanBindingSource
            // 
            this.satıselemanBindingSource.DataMember = "satıseleman";
            this.satıselemanBindingSource.DataSource = this.dbsatısDataSet;
            // 
            // dbsatısDataSet
            // 
            this.dbsatısDataSet.DataSetName = "DbsatısDataSet";
            this.dbsatısDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // satıselemanTableAdapter
            // 
            this.satıselemanTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // kadıDataGridViewTextBoxColumn
            // 
            this.kadıDataGridViewTextBoxColumn.DataPropertyName = "kadı";
            this.kadıDataGridViewTextBoxColumn.HeaderText = "Kullanıcı Adı";
            this.kadıDataGridViewTextBoxColumn.Name = "kadıDataGridViewTextBoxColumn";
            // 
            // ksifreDataGridViewTextBoxColumn
            // 
            this.ksifreDataGridViewTextBoxColumn.DataPropertyName = "ksifre";
            this.ksifreDataGridViewTextBoxColumn.HeaderText = "Şifre";
            this.ksifreDataGridViewTextBoxColumn.Name = "ksifreDataGridViewTextBoxColumn";
            // 
            // adıDataGridViewTextBoxColumn
            // 
            this.adıDataGridViewTextBoxColumn.DataPropertyName = "adı";
            this.adıDataGridViewTextBoxColumn.HeaderText = "Adı";
            this.adıDataGridViewTextBoxColumn.Name = "adıDataGridViewTextBoxColumn";
            // 
            // soyadıDataGridViewTextBoxColumn
            // 
            this.soyadıDataGridViewTextBoxColumn.DataPropertyName = "soyadı";
            this.soyadıDataGridViewTextBoxColumn.HeaderText = "Soyadı";
            this.soyadıDataGridViewTextBoxColumn.Name = "soyadıDataGridViewTextBoxColumn";
            // 
            // telefonDataGridViewTextBoxColumn
            // 
            this.telefonDataGridViewTextBoxColumn.DataPropertyName = "telefon";
            this.telefonDataGridViewTextBoxColumn.HeaderText = "Telefon";
            this.telefonDataGridViewTextBoxColumn.Name = "telefonDataGridViewTextBoxColumn";
            // 
            // adresDataGridViewTextBoxColumn
            // 
            this.adresDataGridViewTextBoxColumn.DataPropertyName = "adres";
            this.adresDataGridViewTextBoxColumn.HeaderText = "Adres";
            this.adresDataGridViewTextBoxColumn.Name = "adresDataGridViewTextBoxColumn";
            // 
            // personelform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(864, 473);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "personelform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personeller";
            this.Load += new System.EventHandler(this.personelform_Load);
            this.Click += new System.EventHandler(this.personelform_Click);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.personelform_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.satıselemanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbsatısDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private DbsatısDataSet dbsatısDataSet;
        private System.Windows.Forms.BindingSource satıselemanBindingSource;
        private DbsatısDataSetTableAdapters.satıselemanTableAdapter satıselemanTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kadıDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ksifreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adıDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soyadıDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresDataGridViewTextBoxColumn;
    }
}