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
using System.Data.Sql;
namespace BayPansiyonOtomasyonu
{
    public partial class FrmYeniMusteri : Form
    {
        public FrmYeniMusteri()
        {
            InitializeComponent();
        }

        SqlConnection baglanti=new SqlConnection(@"Data Source=DESKTOP-3R6P9AR;Initial Catalog=BayPansiyon;Integrated Security=True");




        private void FrmYeniMusteri_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            
            

           
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnB305_Click(object sender, EventArgs e)
        {

            TxtOdaNo.Text = "B305";

        }

        private void Btn101_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "A101";
           
        }

        private void Btn102_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "A102";

        }

        private void Btn103_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "A103";

        }

        private void BtnB101_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "B101";

        }

        private void BtnB102_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "B102";

        }

        private void BtnB103_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "B103";

        }

        private void BtnB104_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "B104";

        }

        private void BtnB105_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "B105";

        }

        private void Btn201_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "A201";

        }

        private void Btn202_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "A202";

        }

        private void Btn203_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "A203";

        }

        private void Btn204_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "A204";

        }

        private void Btn205_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "A205";

        }

        private void BtnB201_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "B201";

        }

        private void BtnB202_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "B202";

        }

        private void BtnB203_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "B203";

        }

        private void BtnB204_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "B204";

        }

        private void BtnB205_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "B205";

        }

        private void Btn301_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "A301";

        }

        private void Btn302_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "A302";

        }

        private void Btn303_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "A303";

        }

        private void Btn304_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "A304";

        }

        private void Btn305_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "A305";

        }

        private void BtnB301_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "B301";

        }

        private void BtnB302_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "B302";

        }

        private void BtnB303_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "B303";

        }

        private void BtnB304_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "B304";

        }

        private void BtnDolu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kırmızı renkli butonlar dolu odaları gösterir.");
        }

        private void BtnBos_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yeşil renkli butonlar boş odaları gösterir.");

        }

        private void DtpCikisTarihi_ValueChanged(object sender, EventArgs e)
        {
            int Ucret;
            DateTime kucukTarih = Convert.ToDateTime(DtpGirisTarihi.Text);
            DateTime buyukTarih = Convert.ToDateTime(DtpCikisTarihi.Text);
            TimeSpan Sonuc;
            Sonuc= buyukTarih-kucukTarih;
            LblKalınanGün.Text = Sonuc.TotalDays.ToString();
            Ucret=Convert.ToInt32(LblKalınanGün.Text)*50;
            TxtUcret.Text = Ucret.ToString();

        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into MusteriEkle(Adi,Soyadi,Telefon,Mail,TC,OdaNo,Ucret,GirisTarihi,CikisTarihi) values('" + TxtAdi.Text+"','"+TxtSoyadi.Text+"','"+MskTelefon.Text+"','"+TxtMail.Text+ "','" + TxtTcKimlikNo.Text + "','" + TxtOdaNo.Text +  "','"+TxtUcret.Text+ "','"+ DtpGirisTarihi.Value.ToString("yyyy-MM-dd hh:MM:ss") + "','" + DtpCikisTarihi.Value.ToString("yyyy-MM-dd hh:MM:ss") + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Öğrenci Kaydı Yapıldı.");

        }

        private void TxtOdaNo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
