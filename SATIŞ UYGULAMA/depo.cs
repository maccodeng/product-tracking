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
    public partial class depo : Form
    {
        public depo()
        {
            InitializeComponent();
        }
        public DbsatısDataSetTableAdapters.urunlerTableAdapter urunler = new DbsatısDataSetTableAdapters.urunlerTableAdapter();
        public SqlConnection baglan = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Dbsatıs.mdf;Integrated Security=True;Connect Timeout=30");
        public SqlCommand komut = new SqlCommand("");
        public SqlDataAdapter adtr = new SqlDataAdapter();
        public DataSet ds = new DataSet();
        private void depo_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbsatısDataSet.urunler' table. You can move, or remove it, as needed.
            this.urunlerTableAdapter.Fill(this.dbsatısDataSet.urunler);

        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel1.Location = new Point(620,-5);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
           
        }

        private void label2_MouseHover(object sender, EventArgs e)
        {
            label2.ForeColor = Color.White;
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            label2.ForeColor = Color.DarkRed;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.Visible = false;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.Visible = true;
            if (textBox2.Text != "")
            {
                if (radioButton1.Checked == true)
                {
                    baglan.Open();
                    adtr = new SqlDataAdapter("Select * from  urunler where marka like '%" + textBox2.Text + "%'", baglan);
                    ds.Clear();
                    adtr.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0];
                    baglan.Close();
                }
                else if (radioButton2.Checked == true)
                {
                    baglan.Open();
                    adtr = new SqlDataAdapter("Select * from  urunler where model like '%" + textBox2.Text + "%'", baglan);
                    ds.Clear();
                    adtr.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0];
                    baglan.Close();
                }
                else if (radioButton3.Checked == true)
                {
                    baglan.Open();
                    adtr = new SqlDataAdapter("Select * from  urunler where kategori like '%" + textBox2.Text + "%'", baglan);
                    ds.Clear();
                    adtr.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0];
                    baglan.Close();
                }
                else if (radioButton9.Checked == true)
                {
                    baglan.Open();
                    adtr = new SqlDataAdapter("Select * from  urunler where kayıtyapan like '%" + textBox2.Text + "%'", baglan);
                    ds.Clear();
                    adtr.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0];
                    baglan.Close();
                }
            }
            else
            {
                dataGridView1.DataSource = urunler.GetData();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
            {
                if (radioButton1.Checked == true)
                {
                    baglan.Open();
                    adtr = new SqlDataAdapter("Select * from  urunler where marka like '%"+textBox2.Text+"%'", baglan);
                    ds.Clear();
                    adtr.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0];
                    baglan.Close();
                }
                else if (radioButton2.Checked == true)
                {
                    baglan.Open();
                    adtr = new SqlDataAdapter("Select * from  urunler where model like '%" + textBox2.Text + "%'", baglan);
                    ds.Clear();
                    adtr.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0];
                    baglan.Close();
                }
                else if (radioButton3.Checked == true)
                {
                    baglan.Open();
                    adtr = new SqlDataAdapter("Select * from  urunler where kategori like '%" + textBox2.Text + "%'", baglan);
                    ds.Clear();
                    adtr.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0];
                    baglan.Close();
                }
                else if (radioButton9.Checked == true)
                {
                    baglan.Open();
                    adtr = new SqlDataAdapter("Select * from  urunler where kayıtyapan like '%" + textBox2.Text + "%'", baglan);
                    ds.Clear();
                    adtr.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0];
                    baglan.Close();
                }
            }
            else
            {
                dataGridView1.DataSource = urunler.GetData();
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if(textBox3.Text!="" && textBox4.Text !="")
            {
                if(radioButton4.Checked==true)
                {
                    baglan.Open();
                    adtr = new SqlDataAdapter("Select * from  urunler where alısfiyat between '" + Convert.ToInt32 (textBox3.Text) + "' and '"+Convert.ToInt32( textBox4.Text)+"'", baglan);
                    ds.Clear();
                    adtr.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0];
                    baglan.Close();
                }
                if (radioButton5.Checked == true)
                {
                    baglan.Open();
                    adtr = new SqlDataAdapter("Select * from  urunler where satısfiyat between '" + Convert.ToInt32(textBox3.Text) + "' and '" + Convert.ToInt32(textBox4.Text) + "'", baglan);
                    ds.Clear();
                    adtr.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0];
                    baglan.Close();
                }
                if (radioButton6.Checked == true)
                {
                    baglan.Open();
                    adtr = new SqlDataAdapter("Select * from  urunler where stokadet between '" + Convert.ToInt32(textBox3.Text) + "' and '" + Convert.ToInt32(textBox4.Text) + "'", baglan);
                    ds.Clear();
                    adtr.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0];
                    baglan.Close();
                }
                if (radioButton7.Checked == true)
                {
                    baglan.Open();
                    adtr = new SqlDataAdapter("Select * from  urunler where kdvoran between '" + Convert.ToInt32(textBox3.Text) + "' and '" + Convert.ToInt32(textBox4.Text) + "'", baglan);
                    ds.Clear();
                    adtr.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0];
                    baglan.Close();
                }
                if (radioButton8.Checked == true)
                {
                    baglan.Open();
                    adtr = new SqlDataAdapter("Select * from  urunler where karoran between '" + Convert.ToInt32(textBox3.Text) + "' and '" + Convert.ToInt32(textBox4.Text) + "'", baglan);
                    ds.Clear();
                    adtr.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0];
                    baglan.Close();
                }
            }
            else
            {
                dataGridView1.DataSource = urunler.GetData();
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.Visible = true;
            if (textBox2.Text != "")
            {
                if (radioButton1.Checked == true)
                {
                    baglan.Open();
                    adtr = new SqlDataAdapter("Select * from  urunler where marka like '%" + textBox2.Text + "%'", baglan);
                    ds.Clear();
                    adtr.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0];
                    baglan.Close();
                }
                else if (radioButton2.Checked == true)
                {
                    baglan.Open();
                    adtr = new SqlDataAdapter("Select * from  urunler where model like '%" + textBox2.Text + "%'", baglan);
                    ds.Clear();
                    adtr.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0];
                    baglan.Close();
                }
                else if (radioButton3.Checked == true)
                {
                    baglan.Open();
                    adtr = new SqlDataAdapter("Select * from  urunler where kategori like '%" + textBox2.Text + "%'", baglan);
                    ds.Clear();
                    adtr.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0];
                    baglan.Close();
                }
                else if (radioButton9.Checked == true)
                {
                    baglan.Open();
                    adtr = new SqlDataAdapter("Select * from  urunler where kayıtyapan like '%" + textBox2.Text + "%'", baglan);
                    ds.Clear();
                    adtr.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0];
                    baglan.Close();
                }
            }
            else
            {
                dataGridView1.DataSource = urunler.GetData();
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.Visible = true;
            if (textBox2.Text != "")
            {
                if (radioButton1.Checked == true)
                {
                    baglan.Open();
                    adtr = new SqlDataAdapter("Select * from  urunler where marka like '%" + textBox2.Text + "%'", baglan);
                    ds.Clear();
                    adtr.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0];
                    baglan.Close();
                }
                else if (radioButton2.Checked == true)
                {
                    baglan.Open();
                    adtr = new SqlDataAdapter("Select * from  urunler where model like '%" + textBox2.Text + "%'", baglan);
                    ds.Clear();
                    adtr.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0];
                    baglan.Close();
                }
                else if (radioButton3.Checked == true)
                {
                    baglan.Open();
                    adtr = new SqlDataAdapter("Select * from  urunler where kategori like '%" + textBox2.Text + "%'", baglan);
                    ds.Clear();
                    adtr.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0];
                    baglan.Close();
                }
                else if (radioButton9.Checked == true)
                {
                    baglan.Open();
                    adtr = new SqlDataAdapter("Select * from  urunler where kayıtyapan like '%" + textBox2.Text + "%'", baglan);
                    ds.Clear();
                    adtr.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0];
                    baglan.Close();
                }
            }
            else
            {
                dataGridView1.DataSource = urunler.GetData();
            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.Visible = false;
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.Visible = false;
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.Visible = false;
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.Visible = false;
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.Visible = true;
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            label3.Visible = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (textBox5.Text!="")
            {
                label4.Visible = false;
                errorProvider1.Clear();
            }
            else
            {
                label4.Visible = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                label3.Visible = false;
                errorProvider2.Clear();
            }
            else
            {
                label3.Visible = true;
            }
        }

        private void textBox5_Click(object sender, EventArgs e)
        {
            label4.Visible = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox5.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            uruneklefrm urunekle = new uruneklefrm();
            urunekle.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult cvp;
            
            if (textBox1.Text != "")
            {
                cvp = MessageBox.Show("Ürünü Silmek istedğinizden eminmsiniz ? ", "Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (cvp == DialogResult.Yes)
                {
                    urunler.Sil(Convert.ToInt32(textBox1.Text));
                    dataGridView1.DataSource = urunler.GetData();
                }
                
            }
            else
            {
                errorProvider2.SetError(textBox1, "Silmek istediğiniz ürün kodunu giriniz.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            uruneklefrm uruneklefrmm = new uruneklefrm();
            //uruneklefrm urunekle = (uruneklefrm)Application.OpenForms["uruneklefrm"];
            if(textBox5.Text!="")
            {
                uruneklefrmm.Show();
                uruneklefrmm.label12.Text = "ÜRÜN GÜNCELLE";
                uruneklefrmm.label12.Location = new Point(73,5);
                uruneklefrmm.button3.Visible = true;
                uruneklefrmm.textBox1.Text = textBox5.Text;
                
                uruneklefrmm.textBox1.Enabled = false;
                uruneklefrmm.textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                uruneklefrmm.textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                uruneklefrmm.comboBox1.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                uruneklefrmm.textBox4.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                uruneklefrmm.textBox5.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                uruneklefrmm.textBox6.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                uruneklefrmm.textBox7.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                uruneklefrmm.textBox8.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
                uruneklefrmm.textBox9.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            }
            else
            {
                errorProvider1.SetError(textBox5, "Güncellenecek Ürün Kodunu giriniz.");
            }
            
            
        }

        private void label5_MouseHover(object sender, EventArgs e)
        {
            label5.ForeColor = Color.White;
        }

        private void label5_MouseLeave(object sender, EventArgs e)
        {
            label5.ForeColor = Color.DarkRed;
        }

        private void depo_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.F2)
            {
                uruneklefrm urunekle = new uruneklefrm();
                urunekle.ShowDialog();
            }

            /* 177980 - 27CFDB*/
        }
    }
}
