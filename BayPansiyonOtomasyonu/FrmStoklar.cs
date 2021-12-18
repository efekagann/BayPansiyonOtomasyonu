using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace BayPansiyonOtomasyonu
{
    public partial class FrmStoklar : Form
    {
        public FrmStoklar()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-3R6P9AR;Initial Catalog=BayPansiyon;Integrated Security=True");

        private void veriler()
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from Stoklar", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Gida"].ToString();
                ekle.SubItems.Add(oku["İcecek"].ToString());
                ekle.SubItems.Add(oku["TemizlikMalzemeleri"].ToString());
                listView1.Items.Add(ekle);
            }
            baglanti.Close();
        }
        private void veriler2()
        {
            listView2.Items.Clear();
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("select * from Faturalar", baglanti);
            SqlDataReader oku2 = komut2.ExecuteReader();
            while (oku2.Read())
            {
                ListViewItem ekle2 = new ListViewItem();
                ekle2.Text = oku2["Elektrik"].ToString();
                ekle2.SubItems.Add(oku2["Su"].ToString());
                ekle2.SubItems.Add(oku2["Doğalgaz"].ToString());
                listView2.Items.Add(ekle2);
            }
            baglanti.Close();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Stoklar(Gida,İcecek,TemizlikMalzemeleri) values ('"+TxtGidaTutar.Text+"','"+TxtİcecekTutar.Text+"','"+TxtTemizlikTutar.Text+"')",baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            veriler();
            MessageBox.Show("Kaydedildi");
        }

        private void FrmStoklar_Load(object sender, EventArgs e)
        {
           veriler();
            veriler2();
        }

        private void BtnKaydet2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Faturalar(Elektrik,Su,Doğalgaz) values ('" + TxtElektrik.Text + "','" + TxtSu.Text + "','" + TxtDogalgaz.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            veriler();
            MessageBox.Show("Kaydedildi");
        }
    }
}
