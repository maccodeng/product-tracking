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
using Microsoft.Reporting.WinForms;
namespace SATIŞ_UYGULAMA
{
    public partial class raporlarfrm : Form
    {
       

        public raporlarfrm()
        {
            InitializeComponent();
        }
        public SqlConnection baglan = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Dbsatıs.mdf;Integrated Security=True;Connect Timeout=30");
        public SqlCommand komut = new SqlCommand("");
        public SqlDataAdapter adtr = new SqlDataAdapter();
        public DataTable dt = new DataTable();
        

        private void raporlarfrm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DbsatısDataSet.depocu' table. You can move, or remove it, as needed.
            this.depocuTableAdapter.Fill(this.DbsatısDataSet.depocu);
            // TODO: This line of code loads data into the 'DbsatısDataSet.satıseleman' table. You can move, or remove it, as needed.
            this.satıselemanTableAdapter.Fill(this.DbsatısDataSet.satıseleman);
            // TODO: This line of code loads data into the 'DbsatısDataSet.yonetici' table. You can move, or remove it, as needed.
            this.yoneticiTableAdapter.Fill(this.DbsatısDataSet.yonetici);

            this.satıslar11TableAdapter.Fill(this.DbsatısDataSet111.satıslar11);
            this.reportViewer1.RefreshReport();

            radioButton2.Checked = true;


        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(comboBox1.Text.Trim()!="")
            {
                this.satıslar11TableAdapter.FillBy(this.DbsatısDataSet111.satıslar11,comboBox1.Text);
                this.reportViewer1.RefreshReport();
            }
        }

       

        private void raporlarfrm_Click(object sender, EventArgs e)
        {
            this.satıslar11TableAdapter.Fill(this.DbsatısDataSet111.satıslar11);
            this.reportViewer1.RefreshReport();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                reportViewer1.Reset();
                this.reportViewer1.LocalReport.DataSources.Clear();
                this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", this.satıslar11BindingSource));
                this.reportViewer1.LocalReport.ReportEmbeddedResource = "SATIŞ_UYGULAMA.Report1.rdlc";
                this.reportViewer1.RefreshReport();

                comboBox2.Visible = false;
                comboBox1.Visible = true;
                label2.Visible = true;
                button1.Visible = true;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                reportViewer1.Reset();
                this.reportViewer1.LocalReport.DataSources.Clear();
                this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", this.urunlerBindingSource));
                this.reportViewer1.LocalReport.ReportEmbeddedResource = "SATIŞ_UYGULAMA.Report2.rdlc";
                this.reportViewer1.RefreshReport();

                comboBox2.Visible = false;
                comboBox1.Visible = false;
                label2.Visible = false;
                button1.Visible = false;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true)
            {
                comboBox2.Visible = true;

                comboBox1.Visible = false;
                label2.Visible = false;
                button1.Visible = false;

                if(comboBox2.Text=="Yönetici")
                {
                    reportViewer1.Reset();
                    this.reportViewer1.LocalReport.DataSources.Clear();
                    this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", this.yoneticiBindingSource));
                    this.reportViewer1.LocalReport.ReportEmbeddedResource = "SATIŞ_UYGULAMA.Report3.rdlc";
                    this.reportViewer1.RefreshReport();
                }
                if (comboBox2.Text == "Satış Danışmanı")
                {
                    reportViewer1.Reset();
                    this.reportViewer1.LocalReport.DataSources.Clear();
                    this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", this.satıselemanBindingSource));
                    this.reportViewer1.LocalReport.ReportEmbeddedResource = "SATIŞ_UYGULAMA.Report4.rdlc";
                    this.reportViewer1.RefreshReport();
                }
                if (comboBox2.Text == "Depo Görevlisi")
                {
                    reportViewer1.Reset();
                    this.reportViewer1.LocalReport.DataSources.Clear();
                    this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", this.depocuBindingSource));
                    this.reportViewer1.LocalReport.ReportEmbeddedResource = "SATIŞ_UYGULAMA.Report5.rdlc";
                    this.reportViewer1.RefreshReport();
                }
            }
        }

        private void urunlerBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
    }

