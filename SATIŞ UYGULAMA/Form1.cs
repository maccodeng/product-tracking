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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case 0x84:
                    base.WndProc(ref m);
                    if ((int)m.Result == 0x1)
                        m.Result = (IntPtr)0x2;
                    return;
            }

            base.WndProc(ref m);
        }

        public DbsatısDataSetTableAdapters.depocuTableAdapter depocu = new DbsatısDataSetTableAdapters.depocuTableAdapter();
        public DbsatısDataSetTableAdapters.satıselemanTableAdapter satıseleman = new DbsatısDataSetTableAdapters.satıselemanTableAdapter();
        public DbsatısDataSetTableAdapters.yoneticiTableAdapter yonetici = new DbsatısDataSetTableAdapters.yoneticiTableAdapter();

        public SqlConnection baglan = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Dbsatıs.mdf;Integrated Security=True;Connect Timeout=30");
        public SqlCommand komut = new SqlCommand("");
        public SqlDataAdapter adtr = new SqlDataAdapter();
        public DataSet ds = new DataSet();
        
        private void giris()
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                Form2 frm2 = new Form2();
                sifrefrm sifreform = new sifrefrm();
                int yntcgiris, dpcgiris = 0, stsgiris = 0;
                stsgiris = Convert.ToInt32(satıseleman.satıselemangiris(textBox1.Text, textBox2.Text));
                dpcgiris = Convert.ToInt32(depocu.depocugiris(textBox1.Text, textBox2.Text));
                yntcgiris = Convert.ToInt32(yonetici.yoneticigiris(textBox1.Text, textBox2.Text));

                if (yntcgiris > 0)
                {
                    baglan.Open();
                    komut.Connection = baglan;
                    komut.CommandText = "Select * from yonetici where kadı='" + textBox1.Text + "' and ksifre='" + textBox2.Text + "'";
                    komut.ExecuteNonQuery();
                    SqlDataReader oku = komut.ExecuteReader();
                    while (oku.Read())
                    {
                        frm2.label1.Text = oku["id"].ToString();

                        frm2.label2.Text = oku["adı"].ToString() + " " + oku["soyadı"].ToString();

                    }
                    frm2.label3.Text = "Yönetici";
                    this.Hide();
                    frm2.ShowDialog();
                    komut.Dispose();
                    baglan.Close();
                }
                else if (stsgiris > 0)
                {
                    baglan.Open();
                    komut.Connection = baglan;
                    komut.CommandText = "Select * from satıseleman where kadı='" + textBox1.Text + "' and ksifre='" + textBox2.Text + "'";
                    komut.ExecuteNonQuery();
                    SqlDataReader oku = komut.ExecuteReader();
                    while (oku.Read())
                    {
                        frm2.label1.Text = oku["id"].ToString();
                        frm2.label2.Text = oku["adı"].ToString() + " " + oku["soyadı"].ToString();

                    }
                    frm2.label3.Text = "Satış Elemanı";
                    frm2.personellerToolStripMenuItem.Enabled = false;

                    frm2.depoToolStripMenuItem.Visible = false;
                    frm2.depoToolStripMenuItem.Enabled = false;

                    frm2.dasToolStripMenuItem.Visible = false;
                    frm2.dasToolStripMenuItem.Enabled = false;

                    frm2.satışlarToolStripMenuItem.Visible = false;
                    frm2.satışlarToolStripMenuItem.Enabled = false;

                    frm2.raporlarToolStripMenuItem.Visible = false;
                    frm2.raporlarToolStripMenuItem.Enabled = false;
                    this.Hide();
                    frm2.ShowDialog();
                    komut.Dispose();
                    baglan.Close();
                }
                else if (dpcgiris > 0)
                {
                    baglan.Open();
                    komut.Connection = baglan;
                    komut.CommandText = "Select * from depocu where kadı='" + textBox1.Text + "' and ksifre='" + textBox2.Text + "'";
                    komut.ExecuteNonQuery();
                    SqlDataReader oku = komut.ExecuteReader();
                    while (oku.Read())
                    {
                        frm2.label1.Text = oku["id"].ToString();
                        frm2.label2.Text = oku["adı"].ToString() + " " + oku["soyadı"].ToString();

                    }
                    frm2.label3.Text = "Depocu";

                    frm2.personellerToolStripMenuItem.Enabled = false;

                    frm2.ürünSatToolStripMenuItem.Visible = false;
                    frm2.ürünSatToolStripMenuItem.Enabled = false;

                    frm2.dasToolStripMenuItem.Visible = false;
                    frm2.dasToolStripMenuItem.Enabled = false;

                    frm2.satışlarToolStripMenuItem.Visible = false;
                    frm2.satışlarToolStripMenuItem.Enabled = false;

                    frm2.raporlarToolStripMenuItem.Visible = false;
                    frm2.raporlarToolStripMenuItem.Enabled = false;
                    this.Hide();
                    frm2.ShowDialog();
                    komut.Dispose();
                    baglan.Close();
                }
                else
                {
                    label5.Visible = true;
                    label5.Text = "Kullanıcı Adı veya Şifre Hatalı";
                }
            }
            else
            {
                label5.Visible = true;
                label5.Text = "Lütfen Alanları boş geçmeyiniz !";
            }
        }

        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
            pictureBox3.Visible = false;
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '*';
        }

        private void pictureBox3_MouseDown(object sender, MouseEventArgs e)
        {
            textBox2.PasswordChar = '\0';
        }

        private void pictureBox3_MouseUp(object sender, MouseEventArgs e)
        {
            textBox2.PasswordChar = '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            giris();
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            label5.Visible = false;
        }

        private void label3_MouseHover(object sender, EventArgs e)
        {
            label3.ForeColor = Color.White;
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            label3.ForeColor = Color.Black;
        }

        private void label4_MouseHover(object sender, EventArgs e)
        {
            label4.ForeColor = Color.White;
        }

        private void label4_MouseLeave(object sender, EventArgs e)
        {
            label4.ForeColor = Color.Black;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized ;
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                giris();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
