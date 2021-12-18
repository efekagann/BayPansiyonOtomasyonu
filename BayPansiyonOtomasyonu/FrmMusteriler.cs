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
    public partial class FrmMusteriler : Form
    {
        public FrmMusteriler()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-3R6P9AR;Initial Catalog=BayPansiyon;Integrated Security=True");
        private void verilerigoster()
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from MusteriEkle",baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Musteriid"].ToString();
                ekle.SubItems.Add(oku["Adi"].ToString());
                ekle.SubItems.Add(oku["Soyadi"].ToString());
                ekle.SubItems.Add(oku["Telefon"].ToString());
                ekle.SubItems.Add(oku["Mail"].ToString());
                ekle.SubItems.Add(oku["TC"].ToString());
                ekle.SubItems.Add(oku["OdaNo"].ToString());
                ekle.SubItems.Add(oku["Ucret"].ToString());
                ekle.SubItems.Add(oku["GirisTarihi"].ToString());
                ekle.SubItems.Add(oku["CikisTarihi"].ToString());

                listView1.Items.Add(ekle);

            }
            baglanti.Close();
        }


        //Data Source=DESKTOP-3R6P9AR;Initial Catalog=BayPansiyon;Integrated Security=True
        private void FrmMusteriler_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            verilerigoster();
        }
        int id=0;
        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            id=int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            TxtAdi.Text = listView1.SelectedItems[0].SubItems[1].Text;
            TxtSoyadi.Text = listView1.SelectedItems[0].SubItems[2].Text;
            MskTelefon.Text = listView1.SelectedItems[0].SubItems[3].Text;
            TxtMail.Text = listView1.SelectedItems[0].SubItems[4].Text;
            TxtTcKimlikNo.Text = listView1.SelectedItems[0].SubItems[5].Text;
            TxtOdaNo.Text = listView1.SelectedItems[0].SubItems[6].Text;
            TxtUcret.Text = listView1.SelectedItems[0].SubItems[7].Text;
            DtpGirisTarihi.Text = listView1.SelectedItems[0].SubItems[8].Text;
            DtpCikisTarihi.Text = listView1.SelectedItems[0].SubItems[9].Text;

        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from MusteriEkle where Musteriid=("+id+")",baglanti); 
            komut.ExecuteNonQuery();
            baglanti.Close();
            verilerigoster();
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            TxtAdi.Clear();
            TxtSoyadi.Clear();
            MskTelefon.Clear();
            TxtMail.Clear();
            TxtTcKimlikNo.Clear();
            TxtOdaNo.Clear();
            TxtUcret.Clear();
            DtpCikisTarihi.Text = "";
            DtpGirisTarihi.Text = ""; 
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update MusteriEkle set Adi='"+TxtAdi.Text+"',Soyadi='"+TxtSoyadi.Text+ "',Telefon='"+MskTelefon.Text+ "',Mail='"+TxtMail.Text+ "',TC='"+TxtTcKimlikNo.Text+ "',OdaNo='"+TxtOdaNo.Text+ "',Ucret='"+TxtUcret.Text+ "',GirisTarihi='"+ DtpGirisTarihi.Value.ToString("yyyy-MM-dd hh:MM:ss")+ "',CikisTarihi='"+ DtpCikisTarihi.Value.ToString("yyyy-MM-dd hh:MM:ss")+"'where Musteriid="+id+"",baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            verilerigoster();

        }

        private void BtnAra_Click(object sender, EventArgs e)
        {
            //musterileriGoruntule();
        }

        private void musterileriGoruntule()
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from MusteriEkle where Adi like '%" + textBox1.Text + "%'", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Musteriid"].ToString();
                ekle.SubItems.Add(oku["Adi"].ToString());
                ekle.SubItems.Add(oku["Soyadi"].ToString());
                ekle.SubItems.Add(oku["Telefon"].ToString());
                ekle.SubItems.Add(oku["Mail"].ToString());
                ekle.SubItems.Add(oku["TC"].ToString());
                ekle.SubItems.Add(oku["OdaNo"].ToString());
                ekle.SubItems.Add(oku["Ucret"].ToString());
                ekle.SubItems.Add(oku["GirisTarihi"].ToString());
                ekle.SubItems.Add(oku["CikisTarihi"].ToString());

                listView1.Items.Add(ekle);

            }
            baglanti.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            musterileriGoruntule();
        }
    }
}
