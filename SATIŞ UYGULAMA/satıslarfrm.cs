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
    public partial class satıslarfrm : Form
    {
        public satıslarfrm()
        {
            InitializeComponent();
        }
        Form2 frm2 = (Form2)Application.OpenForms["Form2"];
        public DbsatısDataSetTableAdapters.urunlerTableAdapter urunler = new DbsatısDataSetTableAdapters.urunlerTableAdapter();
        public DbsatısDataSetTableAdapters.satıslarTableAdapter satıslar = new DbsatısDataSetTableAdapters.satıslarTableAdapter();
        public SqlConnection baglan = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Dbsatıs.mdf;Integrated Security=True;Connect Timeout=30");
        public SqlCommand komut = new SqlCommand("");
        public DataSet ds = new DataSet();
        public SqlDataAdapter adtr = new SqlDataAdapter();
        public DbsatısDataSet111TableAdapters.satıslar11TableAdapter satıslar11 = new DbsatısDataSet111TableAdapters.satıslar11TableAdapter();
        private void satıslarfrm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbsatısDataSet.urunler' table. You can move, or remove it, as needed.
            this.urunlerTableAdapter.Fill(this.dbsatısDataSet.urunler);
            //textBox9.Text = DateTime.Now.ToShortDateString();
            textBox9.Text = DateTime.Now.ToString();
            textBox8.Text = frm2.label2.Text;
            radioButton1.Checked = true;



        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
            textBox3.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
            textBox4.Text = dataGridView2.CurrentRow.Cells[3].Value.ToString();
            textBox5.Text = dataGridView2.CurrentRow.Cells[7].Value.ToString();
            textBox6.Text = dataGridView2.CurrentRow.Cells[8].Value.ToString();
        }

        private void label10_MouseHover(object sender, EventArgs e)
        {
            label10.ForeColor = Color.DarkRed;
        }

        private void label10_MouseLeave(object sender, EventArgs e)
        {
            label10.ForeColor = Color.FromKnownColor(KnownColor.ButtonHighlight);

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();

            double adet, fiyat, tfiyat;
            if(textBox5.Text!="" && textBox7.Text!="")
            {
                adet = double.Parse(textBox7.Text);
                fiyat = double.Parse(textBox5.Text);
                tfiyat = adet * fiyat;
                textBox10.Text = tfiyat.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int stokadeti, satılanadet, kalanstok,sayı;
            if (textBox7.Text != "")
            {
                stokadeti = int.Parse(textBox6.Text);
                satılanadet = int.Parse(textBox7.Text);
                if (stokadeti > satılanadet)
                {
                    sayı = Convert.ToInt32( satıslar.sayıgetir())+1;
                    kalanstok = stokadeti - satılanadet;
                    urunler.Adetgüncelle(kalanstok,Convert.ToInt32(textBox1.Text));
                    //satıslartb.Eklee(sayı,int.Parse(textBox1.Text),int.Parse(textBox7.Text),textBox8.Text,textBox9.Text,decimal.Parse(textBox10.Text));
                    satıslar11.Eklee(Convert.ToInt32(textBox1.Text),Convert.ToInt32(textBox7.Text),textBox8.Text,textBox9.Text,Convert.ToDecimal(textBox10.Text));



                    /*///////////////////////////////////////////*/
                    //try
                    //{
                    //    baglan.Open();
                    //    komut.Connection = baglan;
                    //    komut.CommandText = "İnsert into satıslar(id,urun,adet,satan,tarih,tücret) values('" + Convert.ToInt32(sayı) + "','" + textBox1.Text + "','" + Convert.ToInt32(textBox7.Text) + "','" + textBox8.Text + "','" + textBox9.Text + "','" + Convert.ToDecimal(textBox10.Text) + "')";
                    //    komut.ExecuteNonQuery();
                    //    komut.Dispose();
                    //    baglan.Close();
                    //}
                    //catch 
                    //{

                    //    MessageBox.Show("Bir hata oluştu");
                    //}

                    /*//////////////////////////////////////////*/
                    dataGridView2.DataSource = urunler.GetData();
                    message mesaj = new message();
                    mesaj.label1.Text = "Ürün Başarıyla Satıldı.";
                    mesaj.ShowDialog();
                    
                }
                else
                {
                    errorProvider1.SetError(textBox7, "Satılan ürün miktarı stokdan büyük lütfen kontrol ediniz");
                }
               
            }
            else
            {
                errorProvider1.SetError(textBox7, "Satıcak ürün adetini giriniz");
            }
        }

        private void textBox7_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void satıslarfrm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                this.Close();
            }
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            if (textBox11.Text != "" && radioButton1.Checked == true)
            {
                baglan.Open();
                adtr = new SqlDataAdapter("Select urunkodu,marka,model,kategori,satısfiyat,stokadet from  urunler where urunkodu like '%" + textBox11.Text + "%'", baglan);
                ds.Clear();
                adtr.Fill(ds);
                dataGridView2.DataSource = ds.Tables[0];
                baglan.Close();
            }
           else if (textBox11.Text != "" && radioButton2.Checked == true)
            {
                baglan.Open();
                adtr = new SqlDataAdapter("Select urunkodu,marka,model,kategori,satısfiyat,stokadet from  urunler where model like '%" + textBox11.Text + "%'", baglan);
                ds.Clear();
                adtr.Fill(ds);
                dataGridView2.DataSource = ds.Tables[0];
                baglan.Close();
            }
            else if (textBox11.Text != "" && radioButton3.Checked == true)
            {
                baglan.Open();
                adtr = new SqlDataAdapter("Select urunkodu,marka,model,kategori,satısfiyat,stokadet from  urunler where marka like '%" + textBox11.Text + "%'", baglan);
                ds.Clear();
                adtr.Fill(ds);
                dataGridView2.DataSource = ds.Tables[0];
                baglan.Close();
            }
            else
            {
                dataGridView2.DataSource = urunler.GetData();
            }


        }
    }
}
