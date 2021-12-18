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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-3R6P9AR;Initial Catalog=BayPansiyon;Integrated Security=True");

        private void BtnGirisYap_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                string sql = "select * from AdminGiris where Kullaniciadi=@Kullaniciadi AND Sifre=@Sifresi";
                SqlParameter prm1 = new SqlParameter("Kullaniciadi", TxtKullaniciAdi.Text.Trim());
                SqlParameter prm2 = new SqlParameter("Sifresi", TxtSifre.Text.Trim());
                SqlCommand komut = new SqlCommand(sql, baglanti);
                komut.Parameters.Add(prm1);
                komut.Parameters.Add(prm2);

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(komut);
                da.Fill(dt);
                if (dt.Rows.Count>0)
                {
                    FrmAnaForm fr = new FrmAnaForm();
                    fr.Show();
                }

            }
            catch (Exception)
            {

                MessageBox.Show("Hatalı Giriş");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void TxtSifre_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtKullaniciAdi_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        //      if (TxtKullaniciAdi.Text=="admin" && TxtSifre.Text=="12345")
        //        {
        //            FrmAnaForm fr = new FrmAnaForm();
        //    fr.Show();
        //            this.Hide();
        //}
        //        else
        //        {
        //            MessageBox.Show("Kullanıcı Adı veya Şifre Hatalı");
        //        }
    }
}
