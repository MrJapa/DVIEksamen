using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dvi.monitorSoapClient ds = new dvi.monitorSoapClient();
            dataGridView1.DataSource = ds.StockItemsMostSold().Select(x => new { Mest_Solgte = x }).ToList();
            dataGridView3.DataSource = ds.StockItemsUnderMin().Select(x => new { Under_Min = x }).ToList();
            dataGridView2.DataSource = ds.StockItemsOverMax().Select(x => new { Over_Max = x }).ToList();

            label1.Text = ds.StockTemp().ToString();
            label13.Text = ds.StockHumidity().ToString();
            label15.Text = ds.OutdoorTemp().ToString();
            label14.Text = ds.OutdoorHumidity().ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            label22.Text = now.ToString();
            label22.Refresh();
        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            DateTime dtl = DateTime.Now.AddHours(-1);
            label25.Text = dtl.ToString();
            label22.Refresh();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            DateTime dtl = DateTime.Now.AddHours(+7);
            label27.Text = dtl.ToString();
            label22.Refresh();
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            dvi.monitorSoapClient ds = new dvi.monitorSoapClient();
            label1.Text = ds.StockTemp().ToString();
            label1.Refresh();
            
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            dvi.monitorSoapClient ds = new dvi.monitorSoapClient();
            label13.Text = ds.StockHumidity().ToString();
            label13.Refresh();
        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            dvi.monitorSoapClient ds = new dvi.monitorSoapClient();
            label15.Text = ds.OutdoorTemp().ToString();
            label15.Refresh();
        }

        private void timer7_Tick(object sender, EventArgs e)
        {
            dvi.monitorSoapClient ds = new dvi.monitorSoapClient();
            label14.Text = ds.OutdoorHumidity().ToString();
            label14.Refresh();
        }

        private void timer8_Tick(object sender, EventArgs e)
        {
            dvi.monitorSoapClient ds = new dvi.monitorSoapClient();
            dataGridView1.DataSource = ds.StockItemsMostSold().Select(x => new { Mest_Solgte = x }).ToList();
            dataGridView1.Refresh();
        }

        private void timer9_Tick(object sender, EventArgs e)
        {
            dvi.monitorSoapClient ds = new dvi.monitorSoapClient();
            dataGridView2.DataSource = ds.StockItemsOverMax().Select(x => new { Mest_Solgte = x }).ToList();
            dataGridView2.Refresh();
        }

        private void timer10_Tick(object sender, EventArgs e)
        {
            dvi.monitorSoapClient ds = new dvi.monitorSoapClient();
            dataGridView3.DataSource = ds.StockItemsUnderMin().Select(x => new { Mest_Solgte = x }).ToList();
            dataGridView3.Refresh();
        }
    }
}
