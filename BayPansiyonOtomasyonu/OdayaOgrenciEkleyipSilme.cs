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
    public partial class OdayaOgrenciEkleyipSilme : Form
    {
        public OdayaOgrenciEkleyipSilme()
        {
            InitializeComponent();
            string[] odalar = { "OdaA101", "OdaA102", "OdaA103","OdaB101","OdaB102","OdaB103","OdaB104","OdaB105","OdaA201","OdaA202","OdaA203","OdaA204","OdaA205","OdaB201","OdaB202","OdaB203","OdaB204","OdaB205","OdaA301","OdaA302","OdaA303","OdaA304","OdaA305","OdaB301","OdaB302","OdaB303","OdaB304","OdaB305" };

            comboBox1.DataSource = odalar;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList; 

        }
        

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-3R6P9AR;Initial Catalog=BayPansiyon;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            

            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open(); //baglatı açık mı değl mi 
            }
            SqlCommand cmd = new SqlCommand("select * from "+comboBox1.Text.ToString(),baglanti); //odadakileri çekiitor / show 200 rows 
            SqlDataReader reader = cmd.ExecuteReader();
            List<Ogrenci> odalar = new List<Ogrenci>();
            while (reader.Read())
            {
                Ogrenci ogrenci = new Ogrenci();
                ogrenci.ID =Convert.ToInt32(reader["ID"]);
                ogrenci.Adi= reader["Adi"].ToString();
                ogrenci.Soyadi= reader["Soyadi"].ToString();
                odalar.Add(ogrenci);
            }
            reader.Close();
            baglanti.Close();

            if(odalar.Count > 3)
            {
                MessageBox.Show("Oda dolu");
                baglanti.Close();
            }
            else
            {
                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                }
                SqlCommand komut = new SqlCommand("insert into " + comboBox1.Text.ToString() + "(Adi,Soyadi) values('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglanti);

                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Öğrenci Kaydı Yapıldı.");

            }
            odalarigoster();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }
            //string deneme = "delete from " + comboBox1.Text.ToString() + " where ID=" + _ID.ToString() + "";
            SqlCommand komut = new SqlCommand("delete from " + comboBox1.Text.ToString() + " where ID=" + _ID.ToString() + "", baglanti);

            //DELETE FROM comboBox1.Text.ToString() WHERE ID=1

            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Öğrenci Kaydı Silindi.");
            odalarigoster();

        }
        private int _ID;

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void OdayaOgrenciEkleyipSilme_Load(object sender, EventArgs e)
        {
            odalarigoster();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            odalarigoster();
        }

        private void odalarigoster()
        {
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }
            SqlDataAdapter tdGrvAdpter = new SqlDataAdapter("select * from " + comboBox1.Text.ToString(), baglanti);


            DataSet dtGrv = new DataSet();
            tdGrvAdpter.Fill(dtGrv);
            dataGridView1.DataSource = dtGrv.Tables[0];
            baglanti.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _ID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[2].Value);
        }
    }
}
