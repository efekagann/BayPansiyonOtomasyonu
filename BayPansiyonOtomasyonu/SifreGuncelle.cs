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
    public partial class SifreGuncelle : Form
    {
        public SifreGuncelle()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-3R6P9AR;Initial Catalog=BayPansiyon;Integrated Security=True");


        private void BtnGirisYap2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update AdminGiris set Kullanici='" + TxtKullaniciAdi.Text + "',Sifre='" + TxtSifre.Text + "'", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Şifre Güncellendi");
        }
    }
}
