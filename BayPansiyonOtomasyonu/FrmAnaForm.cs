using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BayPansiyonOtomasyonu
{
    public partial class FrmAnaForm : Form
    {
        public FrmAnaForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 fr = new Form1();
            fr.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmYeniMusteri fr = new FrmYeniMusteri();
            fr.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OdayaOgrenciEkleyipSilme fr = new OdayaOgrenciEkleyipSilme();
            fr.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmMusteriler fr = new FrmMusteriler();
            fr.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bay Pansiyon Kayıt Uygulaması / 2021 - EDİRNE/KEŞAN");
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongDateString();
            label2.Text = DateTime.Now.ToLongTimeString();
        }

        private void FrmAnaForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            FrmGelirGider fr = new FrmGelirGider();
            fr.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            FrmStoklar fr = new FrmStoklar();
            fr.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SifreGuncelle fr = new SifreGuncelle();
            fr.Show();
        }
    }
}
