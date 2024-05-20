using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Evaluation_System
{
    public partial class ogrEkle : Form
    {
        MySqlConnection baglanti = new MySqlConnection("Server = localhost;Database = gorselprogram; user=root;");
        public ogrEkle()
        {
            InitializeComponent();
        }

        private void ogrEkle_Load(object sender, EventArgs e)
        {

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            int satir;
            baglanti.Open();
            MySqlCommand komut = new MySqlCommand();
            komut.CommandText = "INSERT INTO ogrenciler (egitim_ogretim_donemi,ogrenci_id ,ogrenci_no,ogrenci_ad_soyad) " + " VALUES (@pegitim_ogretim_donemi, @pogrenci_id, @pogrenci_no, @pogrenci_ad_soyad)";
            komut.Parameters.AddWithValue("@pegitim_ogretim_donemi", txtDonem.Text);
            komut.Parameters.AddWithValue("@pogrenci_id", txtOgrID.Text);
            komut.Parameters.AddWithValue("@pogrenci_no", txtOgrNo.Text);
            komut.Parameters.AddWithValue("@pogrenci_ad_soyad", textAdSoyad.Text);
            komut.Connection = baglanti;
            satir = komut.ExecuteNonQuery();
            MessageBox.Show(satir + " satır eklendi");
            komut.Dispose(); 
            baglanti.Close();

        }
    }
}
