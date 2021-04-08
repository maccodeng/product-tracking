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
    public partial class sifrefrm : Form
    {
        public sifrefrm()
        {
            InitializeComponent();
        }

        public DbsatısDataSetTableAdapters.depocuTableAdapter depocu = new DbsatısDataSetTableAdapters.depocuTableAdapter();
        public DbsatısDataSetTableAdapters.satıselemanTableAdapter satıseleman = new DbsatısDataSetTableAdapters.satıselemanTableAdapter();
        public DbsatısDataSetTableAdapters.yoneticiTableAdapter yonetici = new DbsatısDataSetTableAdapters.yoneticiTableAdapter();
        public DbsatısDataSetTableAdapters.urunlerTableAdapter urunler = new DbsatısDataSetTableAdapters.urunlerTableAdapter();
        public DbsatısDataSetTableAdapters.satıslarTableAdapter satıslar = new DbsatısDataSetTableAdapters.satıslarTableAdapter();
        public SqlConnection baglan = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Dbsatıs.mdf;Integrated Security=True;Connect Timeout=30");
        public SqlCommand komut = new SqlCommand("");
        public SqlDataAdapter adtr = new SqlDataAdapter();
        public DataSet ds = new DataSet();
        /*Form2 frm2 = new Form2();*/
        Form2 frm2 = (Form2)Application.OpenForms["Form2"];//Açık olan formdan veri çekmem için böyle tanımladım.



        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
         string eskisifre = "";
         if(frm2.label3.Text=="Yönetici")
            {
                if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "")
                {

                    baglan.Open();
                    komut.Connection = baglan;
                    komut.CommandText = "Select * from yonetici where id = " + Convert.ToInt32(frm2.label1.Text) + "";
                    komut.ExecuteNonQuery();
                    SqlDataReader oku = komut.ExecuteReader();
                    while (oku.Read())
                    {
                        eskisifre = oku["ksifre"].ToString();

                    }
                    komut.Dispose();
                    baglan.Close();

                    if (textBox1.Text == eskisifre)
                    {
                        if (textBox2.Text == textBox3.Text)
                        {
                            yonetici.sifredegistir(textBox3.Text, Convert.ToInt32(frm2.label1.Text));
                            MessageBox.Show("işlem tamam", "BAŞARILI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            
                        }
                        else
                        {
                            label4.Visible = true;
                            label4.Text = "Yeni girilen şifreler eşleşmiyor !";
                        }

                    }
                    else
                    {
                        label4.Visible = true;
                        label4.Text = "Eski şifre eşleşmiyor !";
                    }
                }
                else
                {
                    label4.Visible = true;
                    label4.Text = "Boş Alan Bırakmayınız !";
                }

            }

        else if(frm2.label3.Text=="Depocu")
            {
                if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "")
                {

                    baglan.Open();
                    komut.Connection = baglan;
                    komut.CommandText = "Select * from depocu where id = " + Convert.ToInt32(frm2.label1.Text) + "";
                    komut.ExecuteNonQuery();
                    SqlDataReader oku = komut.ExecuteReader();
                    while (oku.Read())
                    {
                        eskisifre = oku["ksifre"].ToString();

                    }
                    komut.Dispose();
                    baglan.Close();

                    if (textBox1.Text == eskisifre)
                    {
                        if (textBox2.Text == textBox3.Text)
                        {
                            depocu.sifredegistir(textBox3.Text, Convert.ToInt32(frm2.label1.Text));
                            MessageBox.Show("işlem tamam", "BAŞARILI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            
                        }
                        else
                        {
                            label4.Visible = true;
                            label4.Text = "Yeni girilen şifreler eşleşmiyor !";
                        }

                    }
                    else
                    {
                        label4.Visible = true;
                        label4.Text = "Eski şifre eşleşmiyor !";
                    }
                }
                else
                {
                    label4.Visible = true;
                    label4.Text = "Boş Alan Bırakmayınız !";
                }
            }
             else if (frm2.label3.Text == "Satış Elemanı")
            {
                if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "")
                {

                    baglan.Open();
                    komut.Connection = baglan;
                    komut.CommandText = "Select * from satıseleman where id = " + Convert.ToInt32(frm2.label1.Text) + "";
                    komut.ExecuteNonQuery();
                    SqlDataReader oku = komut.ExecuteReader();
                    while (oku.Read())
                    {
                        eskisifre = oku["ksifre"].ToString();

                    }
                    komut.Dispose();
                    baglan.Close();

                    if (textBox1.Text == eskisifre)
                    {
                        if (textBox2.Text == textBox3.Text)
                        {
                            satıseleman.sifredegistir(textBox3.Text, Convert.ToInt32(frm2.label1.Text));
                            MessageBox.Show("işlem tamam", "BAŞARILI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                           
                        }
                        else
                        {
                            label4.Visible = true;
                            label4.Text = "Yeni girilen şifreler eşleşmiyor !";
                        }

                    }
                    else
                    {
                        label4.Visible = true;
                        label4.Text = "Eski şifre eşleşmiyor !";
                    }
                }
                else
                {
                    label4.Visible = true;
                    label4.Text = "Boş Alan Bırakmayınız !";
                }
            }

        }
        

        private void sifrefrm_Load(object sender, EventArgs e)
        {
            textBox1.PasswordChar = '*';
            textBox2.PasswordChar = '*';
            textBox3.PasswordChar = '*';
        }

        private void sifrefrm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
