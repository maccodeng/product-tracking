using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SATIŞ_UYGULAMA
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        depo depofrm = new depo();
        public DbsatısDataSetTableAdapters.depocuTableAdapter depocu = new DbsatısDataSetTableAdapters.depocuTableAdapter();
        public DbsatısDataSetTableAdapters.satıselemanTableAdapter satıseleman = new DbsatısDataSetTableAdapters.satıselemanTableAdapter();
        public DbsatısDataSetTableAdapters.yoneticiTableAdapter yonetici = new DbsatısDataSetTableAdapters.yoneticiTableAdapter();
        public DbsatısDataSetTableAdapters.satıslarTableAdapter satıslar = new DbsatısDataSetTableAdapters.satıslarTableAdapter();
        public static string id1;

        /**/
         int a = 0;
        int lbcount = 0;
        

        private void label4_MouseHover(object sender, EventArgs e)
        {
            label4.ForeColor = Color.Red;
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label4_MouseLeave(object sender, EventArgs e)
        {
            label4.ForeColor = Color.DarkRed;
        }

        private void label5_MouseHover(object sender, EventArgs e)
        {
            label5.ForeColor = Color.Red;
        }

        private void label5_MouseLeave(object sender, EventArgs e)
        {
            label5.ForeColor = Color.DarkRed;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            id1 = label1.Text;
            çıkısekranı cıkısfrm = new çıkısekranı();
            cıkısfrm.ShowDialog();

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            timer1.Start();

            pictureBox5.Image = ımageList1.Images[0];
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void depoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            depofrm.ShowDialog();
        }

        private void şifreDeğiştirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sifrefrm sifrefrm = new sifrefrm();

            sifrefrm.ShowDialog();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label6.Text = DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToLongTimeString();
        }

        private void personellerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            personelform personelfrm = new personelform();
            personelfrm.ShowDialog();
        }

        private void satışlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            satıslarlistefrm satıslarliste = new satıslarlistefrm();
            satıslarliste.Show();
        }

        private void ürünSatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            satıslarfrm satıslarfrm1 = new satıslarfrm();
            satıslarfrm1.Show();
        }

        private void raporlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            raporlarfrm raporlarfrm = new raporlarfrm();
            raporlarfrm.Show();
        }

        private void Form2_KeyPress(object sender, KeyPressEventArgs e)
        {
           
            if (e.KeyChar == (char)Keys.Escape)
            {
                çıkısekranı çıkısfrm = new çıkısekranı();
                çıkısfrm.ShowDialog();
            }
            

        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            pictureBox2.Visible = false;

            pictureBox1.Size = new Size(85,79);
            pictureBox1.Location = new Point(117, 123);
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.Visible = true;

            pictureBox1.Size = new Size(75,69);
            pictureBox1.Location = new Point(122,128);
        }

        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
            pictureBox3.Visible = false;
            pictureBox4.Size = new Size(85,79);
            pictureBox4.Location = new Point(674, 123);

        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.Visible = true;

            pictureBox4.Size = new Size(75,69);
            pictureBox4.Location = new Point(679, 128);
        }
       
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            lbcount = ımageList1.Images.Count-1;



            if (a < lbcount)
            {
                a++;
                pictureBox5.Image = ımageList1.Images[a];
            }
            else
            {
                a = 0;
                pictureBox5.Image = ımageList1.Images[a];
            }





        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            lbcount = ımageList1.Images.Count - 1;

            if (a == 0)
            {
                a = lbcount;
                pictureBox5.Image = ımageList1.Images[a];

            }
            else
            {
                a--;
                pictureBox5.Image = ımageList1.Images[a];
            }
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
