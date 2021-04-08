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
    public partial class satıslarlistefrm : Form
    {
        public satıslarlistefrm()
        {
            InitializeComponent();
        }

        private void satıslarlistefrm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbsatısDataSet111.satıslar11' table. You can move, or remove it, as needed.
            this.satıslar11TableAdapter.Fill(this.dbsatısDataSet111.satıslar11);

        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void satıslarlistefrm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar==(char)Keys.Escape)
            {
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            raporlarfrm raporlar = new raporlarfrm();
            raporlar.ShowDialog();
        }
    }
}
