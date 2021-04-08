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
    public partial class uruneklefrm : Form
    {
        public uruneklefrm()
        {
            InitializeComponent();
        }
        public SqlConnection baglan = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Dbsatıs.mdf;Integrated Security=True;Connect Timeout=30");
        public SqlCommand komut = new SqlCommand("");
        public SqlDataAdapter adtr = new SqlDataAdapter();
        public DataSet ds = new DataSet();
        public DbsatısDataSetTableAdapters.urunlerTableAdapter urunler = new DbsatısDataSetTableAdapters.urunlerTableAdapter();
        Form2 frm2 = (Form2)Application.OpenForms["Form2"];
        depo depofrm = (depo)Application.OpenForms["depo"];

        private void temizle()
        {
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    TextBox tbox = (TextBox)item;
                    tbox.Clear();
                }
            }

            textBox9.Text = frm2.label2.Text;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i=0;
            if(textBox1.Text!="")
            {
                baglan.Open();
                komut.Connection = baglan;
                komut.CommandText = "Select count(*) from urunler where urunkodu = '" + Convert.ToInt32(textBox1.Text) + "' ";
                i = Convert.ToInt32(komut.ExecuteScalar());
                baglan.Close();
            }
            baglan.Close();
            if(textBox1.Text!=""&& textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "" && textBox6.Text != "" && textBox7.Text != "" && textBox8.Text != "" && textBox9.Text != "" && comboBox1.Text != "" )
            {
                if (i < 1)
                {
                    urunler.Ekle(Convert.ToInt32(textBox1.Text), textBox2.Text, textBox3.Text, comboBox1.Text, Convert.ToDecimal(textBox4.Text), Convert.ToDecimal(textBox5.Text), Convert.ToDecimal(textBox6.Text), Convert.ToDecimal(textBox7.Text), Convert.ToInt32(textBox8.Text), textBox9.Text);
                    label11.Visible = true;
                    temizle();
                    comboBox1.Text = "";
                    label11.Text = "Ürün başarıyle eklendi";
                    label11.ForeColor = Color.White;
                    depofrm.dataGridView1.DataSource = urunler.GetData();
                    
                   

                }
                else
                {
                    label11.Text = "Girmiş olduğunuz ürün kodu zaten kullanılıyor...";
                    label11.Visible = true;
                    label11.ForeColor = Color.White;
                    
                    return;
                    
                }
                
            }
            else
            {

                label11.Text = "Boş Alan Bırakmayınız !";
                label11.Visible = true;
                label11.ForeColor = Color.White;
                
            }
            


        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            decimal satısfiyat, kdvoran, karoran, alışfyat;
            if(textBox4.Text!="" && textBox5.Text != ""&& textBox6.Text != "")
            {
                alışfyat = Convert.ToDecimal(textBox4.Text);
                kdvoran = Convert.ToDecimal(textBox5.Text);
                karoran = Convert.ToDecimal(textBox6.Text);
                satısfiyat = alışfyat + (alışfyat * kdvoran / 100) + (alışfyat * karoran / 100);
                textBox7.Text = satısfiyat.ToString();
            }
        }

        private void uruneklefrm_Load(object sender, EventArgs e)
        {
            textBox9.Text = frm2.label2.Text;
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            label11.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "" && textBox6.Text != "" && textBox7.Text != "" && textBox8.Text != "" && textBox9.Text != "" && comboBox1.Text != "")
            {
                urunler.güncelle( textBox2.Text, textBox3.Text, comboBox1.Text, Convert.ToDecimal(textBox4.Text), Convert.ToDecimal(textBox5.Text), Convert.ToDecimal(textBox6.Text), Convert.ToDecimal(textBox7.Text), Convert.ToInt32(textBox8.Text), textBox9.Text, Convert.ToInt32(textBox1.Text));
                depofrm.dataGridView1.DataSource  = urunler.GetData();
                this.Close();
            }
            else
            {
                label11.Visible = true;
                label11.Text = "Boş alan bırakmayınız.";
                label11.ForeColor = Color.White;

            }
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
