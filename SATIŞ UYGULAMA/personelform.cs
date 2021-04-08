using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SATIŞ_UYGULAMA
{
    public partial class personelform : Form
    {
        public personelform()
        {
            InitializeComponent();
        }
        public DbsatısDataSetTableAdapters.depocuTableAdapter depocu = new DbsatısDataSetTableAdapters.depocuTableAdapter();
        public DbsatısDataSetTableAdapters.satıselemanTableAdapter satıseleman = new DbsatısDataSetTableAdapters.satıselemanTableAdapter();
        public DbsatısDataSetTableAdapters.yoneticiTableAdapter yonetici = new DbsatısDataSetTableAdapters.yoneticiTableAdapter();
        public SqlConnection baglan = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Dbsatıs.mdf;Integrated Security=True;Connect Timeout=30");
        public SqlCommand komut = new SqlCommand("");
        public SqlDataAdapter adtr = new SqlDataAdapter();
        public DataSet ds = new DataSet();
        Form2 frm = new Form2();

        private void txttemizle()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
        }
        private void personelform_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbsatısDataSet.satıseleman' table. You can move, or remove it, as needed.
            this.satıselemanTableAdapter.Fill(this.dbsatısDataSet.satıseleman);
            dataGridView1.DataSource = satıseleman.GetData();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text== "Satış Danışmanı")
            {
                dataGridView1.DataSource = satıseleman.GetData();
            }
            else if (comboBox1.Text == "Yönetici")
            {
                dataGridView1.DataSource = yonetici.GetData();
            }
            else if (comboBox1.Text == "Depocu")
            {
                dataGridView1.DataSource = depocu.GetData();
            }
            txttemizle();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBox6.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            textBox7.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text!="" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "" && textBox6.Text != "" && textBox7.Text != "" )
            {
                if(comboBox1.Text=="Yönetici")
                {
                    yonetici.Ekle(Convert.ToInt32(textBox1.Text), textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text, textBox7.Text);
                    txttemizle();
                    dataGridView1.DataSource = yonetici.GetData();
                }
                if (comboBox1.Text == "Satış Danışmanı")
                {
                    try
                    {
                        satıseleman.Ekle(Convert.ToInt32(textBox1.Text), textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text, textBox7.Text);
                        txttemizle();
                        dataGridView1.DataSource = satıseleman.GetData();
                    }
                    catch 
                    {

                        MessageBox.Show("Bir Aksaklık oldu , lüftfen girilen bilgileri kontrol ediniz /ngirmiş olduğunuz ID daha önce kullanılmış olabilir","Bilgilendirme",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    }
                    
                }
                if (comboBox1.Text == "Depocu")
                {
                    depocu.Ekle(Convert.ToInt32(textBox1.Text), textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text, textBox7.Text);
                    txttemizle();
                    dataGridView1.DataSource = depocu.GetData();
                }
            }
            else
            {

                MessageBox.Show("Alanları boş bırakmayınız", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Yönetici" && textBox1.Text !="")
            {
                string isim;
                baglan.Open();
                komut.Connection = baglan;
                komut.CommandText = "Select adı from yonetici where id='"+Convert.ToInt32(textBox1.Text)+"'";
                isim = komut.ExecuteScalar().ToString();
                komut.Dispose();
                baglan.Close();
                DialogResult cevap = MessageBox.Show(isim+" "+"Adlı Kullanıcıyı Silmek İstediğinizden Emin misiniz ?","Sil",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if(cevap==DialogResult.Yes)
                {
                    yonetici.Sil(Convert.ToInt32(textBox1.Text));
                    txttemizle();
                    dataGridView1.DataSource = yonetici.GetData();
                }
            }

            if (comboBox1.Text == "Satış Danışmanı" && textBox1.Text != "")
            {
                string isim;
                baglan.Open();
                komut.Connection = baglan;
                komut.CommandText = "Select adı from satıseleman where id='" + Convert.ToInt32(textBox1.Text) + "'";
                isim = komut.ExecuteScalar().ToString();
                komut.Dispose();
                baglan.Close();
                DialogResult cevap = MessageBox.Show(isim + " " + "Adlı Kullanıcıyı Silmek İstediğinizden Emin misiniz ?", "Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (cevap == DialogResult.Yes)
                {
                    satıseleman.Sil(Convert.ToInt32(textBox1.Text));
                    txttemizle();
                    dataGridView1.DataSource = satıseleman.GetData();
                }
            }
            if (comboBox1.Text == "Depocu" && textBox1.Text != "")
            {
                string isim;
                baglan.Open();
                komut.Connection = baglan;
                komut.CommandText = "Select adı from depocu where id='" + Convert.ToInt32(textBox1.Text) + "'";
                isim = komut.ExecuteScalar().ToString();
                komut.Dispose();
                baglan.Close();
                DialogResult cevap = MessageBox.Show(isim + " " + "Adlı Kullanıcıyı Silmek İstediğinizden Emin misiniz ?", "Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (cevap == DialogResult.Yes)
                {
                    depocu.Sil(Convert.ToInt32(textBox1.Text));
                    txttemizle();
                    dataGridView1.DataSource = depocu.GetData();
                }
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            if(textBox8.Text!="")
            {
                if(comboBox1.Text == "Satış Danışmanı")
                {
                    if(radioButton1.Checked==true)
                    {
                        baglan.Open();
                        adtr = new SqlDataAdapter("Select * from satıseleman where adı LIKE '%" + textBox8.Text+"%'",baglan);
                        ds.Clear();
                        adtr.Fill(ds,"satıseleman");
                        dataGridView1.DataSource = ds.Tables["satıseleman"];
                        baglan.Close();
                        
                    }
                    else if (radioButton2.Checked == true)
                    {
                        baglan.Open();
                        adtr = new SqlDataAdapter("Select * from satıseleman where soyadı LIKE '%" + textBox8.Text + "%'", baglan);
                        ds.Clear();
                        adtr.Fill(ds, "satıseleman");
                        dataGridView1.DataSource = ds.Tables["satıseleman"];
                        baglan.Close();

                    }
                    else if (radioButton3.Checked == true)
                    {
                        baglan.Open();
                        adtr = new SqlDataAdapter("Select * from satıseleman where adres LIKE '%" + textBox8.Text + "%'", baglan);
                        ds.Clear();
                        adtr.Fill(ds, "satıseleman");
                        dataGridView1.DataSource = ds.Tables["satıseleman"];
                        baglan.Close();

                    }
                }
                /*----------------------------------------------*/
               else  if (comboBox1.Text == "Yönetici")
                {
                    if (radioButton1.Checked == true)
                    {
                        baglan.Open();
                        adtr = new SqlDataAdapter("Select * from yonetici where adı LIKE '%" + textBox8.Text + "%'", baglan);
                        ds.Clear();
                        adtr.Fill(ds, "satıseleman");
                        dataGridView1.DataSource = ds.Tables["satıseleman"];
                        baglan.Close();

                    }
                    else if (radioButton2.Checked == true)
                    {
                        baglan.Open();
                        adtr = new SqlDataAdapter("Select * from yonetici where soyadı LIKE '%" + textBox8.Text + "%'", baglan);
                        ds.Clear();
                        adtr.Fill(ds, "satıseleman");
                        dataGridView1.DataSource = ds.Tables["satıseleman"];
                        baglan.Close();

                    }
                    else if (radioButton3.Checked == true)
                    {
                        baglan.Open();
                        adtr = new SqlDataAdapter("Select * from yonetici where adres LIKE '%" + textBox8.Text + "%'", baglan);
                        ds.Clear();
                        adtr.Fill(ds, "satıseleman");
                        dataGridView1.DataSource = ds.Tables["satıseleman"];
                        baglan.Close();

                    }
                }
                /*----------------------------------------------*/
                else if (comboBox1.Text == "Depocu")
                {
                    if (radioButton1.Checked == true)
                    {
                        baglan.Open();
                        adtr = new SqlDataAdapter("Select * from depocu where adı LIKE '%" + textBox8.Text + "%'", baglan);
                        ds.Clear();
                        adtr.Fill(ds, "satıseleman");
                        dataGridView1.DataSource = ds.Tables["satıseleman"];
                        baglan.Close();

                    }
                    else if (radioButton2.Checked == true)
                    {
                        baglan.Open();
                        adtr = new SqlDataAdapter("Select * from depocu where soyadı LIKE '%" + textBox8.Text + "%'", baglan);
                        ds.Clear();
                        adtr.Fill(ds, "satıseleman");
                        dataGridView1.DataSource = ds.Tables["satıseleman"];
                        baglan.Close();

                    }
                    else if (radioButton3.Checked == true)
                    {
                        baglan.Open();
                        adtr = new SqlDataAdapter("Select * from depocu where adres LIKE '%" + textBox8.Text + "%'", baglan);
                        ds.Clear();
                        adtr.Fill(ds, "satıseleman");
                        dataGridView1.DataSource = ds.Tables["satıseleman"];
                        baglan.Close();

                    }
                }
            }
            else 
            {
                if(comboBox1.Text=="Yönetici")
                {
                    dataGridView1.DataSource = yonetici.GetData();
                }
                if (comboBox1.Text == "Depocu")
                {
                    dataGridView1.DataSource = depocu.GetData();
                }
                if (comboBox1.Text == "Satış Danışmanı")
                {
                    dataGridView1.DataSource = satıseleman.GetData();
                }
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label10_MouseHover(object sender, EventArgs e)
        {
            label10.ForeColor = Color.White;

        }

        private void label10_MouseLeave(object sender, EventArgs e)
        {
            label10.ForeColor = Color.Black;
        }

        private void personelform_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void personelform_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                this.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if(textBox1.Text!="")
                {
                    if(comboBox1.Text=="Yönetici")
                    {
                        yonetici.yoneticigüncelle(textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text, textBox7.Text, Convert.ToInt32(textBox1.Text));
                        dataGridView1.DataSource = yonetici.GetData();
                    }
                   else if (comboBox1.Text == "Depocu")
                    {
                        depocu.Depocugüncelle(textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text, textBox7.Text, Convert.ToInt32(textBox1.Text));
                        dataGridView1.DataSource = depocu.GetData();
                    }
                  else  if (comboBox1.Text == "Satış Danışmanı")
                    {
                        satıseleman.satıselemangüncelle(textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text, textBox7.Text, Convert.ToInt32(textBox1.Text));
                        dataGridView1.DataSource = satıseleman.GetData();
                    }
                }
                else
                {
                    MessageBox.Show("Güncellemek istedğiniz kişiyiz seçin veya ID'sini Yazınız","Bilgilendirme",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
            }
            catch 
            {

                MessageBox.Show("Bir Aksaklık Yaşadık Tekrar Deneyiniz.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
