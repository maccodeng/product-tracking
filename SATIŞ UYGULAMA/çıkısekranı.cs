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
    public partial class çıkısekranı : Form
    {
        public çıkısekranı()
        {
            InitializeComponent();
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            //pictureBox1.Visible = true;
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            
            pictureBox2.Visible = false;
        }

        private void pictureBox5_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.Visible = true;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {       
            Application.Restart();
        }

        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
            pictureBox3.Visible = false;
        }

        private void pictureBox6_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.Visible = true;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            
            this.Close();

        }

        private void çıkısekranı_Load(object sender, EventArgs e)
        {
            //üzerine gelindiğinde çıkan açıklama
            ToolTip acıklama = new ToolTip();
            acıklama.SetToolTip(pictureBox4, "KAPAT");
            acıklama.SetToolTip(pictureBox5, "KULLANICI DEĞİŞTİR");
            acıklama.SetToolTip(pictureBox6, "VAZGEÇ");

            /*----------------------------*/
     

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void çıkısekranı_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar==(char)Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
