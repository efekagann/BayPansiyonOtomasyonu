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
    public partial class FrmGelirGider : Form
    {
        public FrmGelirGider()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-3R6P9AR;Initial Catalog=BayPansiyon;Integrated Security=True");


        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                int personel;
                personel = Convert.ToInt32(textBox1.Text);
                LblPersonel.Text = (personel * 4253).ToString();

            }
            catch (Exception)
            {
                MessageBox.Show("Değer Girmediniz");
            }
            int sonuc;
            sonuc = Convert.ToInt32(LblKasadakiTutar.Text)-(Convert.ToInt32(LblPersonel.Text)+ Convert.ToInt32(LblAlınanUrun1.Text)+ Convert.ToInt32(LblAlınanUrun2.Text)+ Convert.ToInt32(LblAlınanUrun3.Text)+ Convert.ToInt32(LblFatura.Text)+ Convert.ToInt32(LblFatura2.Text)+ Convert.ToInt32(LblFatura3.Text));
;           LblSonuc.Text = sonuc.ToString();
        }

        private void FrmGelirGider_Load(object sender, EventArgs e)
        {

            textBox1.Text = "1";
            
            //Kasadaki toplam tutar.
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select sum(ucret) as toplam from MusteriEkle", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                LblKasadakiTutar.Text = oku["toplam"].ToString();
            }
            baglanti.Close();

            //gıdalar
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("Select sum(Gida) as toplam1 from Stoklar", baglanti);
            SqlDataReader oku2 = komut2.ExecuteReader();

            while (oku2.Read())
            {
                LblAlınanUrun1.Text = oku2["toplam1"].ToString();
            }
            baglanti.Close();

            //içecekler
            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("Select sum(İcecek) as toplam2 from Stoklar", baglanti);
            SqlDataReader oku3 = komut3.ExecuteReader();

            while (oku3.Read())
            {
                LblAlınanUrun2.Text = oku3["toplam2"].ToString();
            }
            baglanti.Close();

            //temizlik malzemeleri
            baglanti.Open();
            SqlCommand komut4 = new SqlCommand("Select sum(TemizlikMalzemeleri) as toplam3 from Stoklar", baglanti);
            SqlDataReader oku4 = komut4.ExecuteReader();

            while (oku4.Read())
            {
                LblAlınanUrun3.Text = oku4["toplam3"].ToString();
            }
            baglanti.Close();

            //Faturalar Elektrik
            baglanti.Open();
            SqlCommand komut5 = new SqlCommand("Select sum(Elektrik) as toplam4 from Faturalar", baglanti);
            SqlDataReader oku5 = komut5.ExecuteReader();

            while (oku5.Read())
            {
                LblFatura.Text = oku5["toplam4"].ToString();
            }
            baglanti.Close();

            //Su
            baglanti.Open();
            SqlCommand komut6 = new SqlCommand("Select sum(Su) as toplam5 from Faturalar", baglanti);
            SqlDataReader oku6 = komut6.ExecuteReader();

            while (oku6.Read())
            {
                LblFatura2.Text = oku6["toplam5"].ToString();
            }
            baglanti.Close();


            //Doğalgaz
            baglanti.Open();
            SqlCommand komut7 = new SqlCommand("Select sum(Dogalgaz) as toplam6 from Faturalar", baglanti);
            SqlDataReader oku7 = komut7.ExecuteReader();

            while (oku7.Read())
            {
                LblFatura3.Text = oku7["toplam6"].ToString();
            }
            baglanti.Close();


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
            
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > 0))
            {
                e.Handled = true;
            }
        }
    }
}
