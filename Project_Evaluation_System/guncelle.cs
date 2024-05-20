using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Project_Evaluation_System
{
    public partial class guncelle : Form
    {
        MySqlConnection baglanti = new MySqlConnection("Server=localhost;Database=gorselprogram;User=root;");

        public guncelle(string projeID, string projeAdi, string ogrenciNo, string projeDanismani, string projeSuresiYariYil, string projeKacinciYariYil)
        {
            InitializeComponent();
            textBox1.Enabled = false;


            textBox1.Text = projeID;
            textBox2.Text = ogrenciNo;
            textBox3.Text = projeAdi;
            textBox4.Text = projeDanismani;
            textBox5.Text = projeSuresiYariYil;
            textBox6.Text = projeKacinciYariYil;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string proje_id = textBox1.Text;
            string ogrenci_no = textBox2.Text;
            string proje_adi = textBox3.Text;
            string proje_danismani = textBox4.Text;
            string Proje_Süresi_YarıYıl = textBox5.Text;
            string Proje_Kaçıncı_YarıYıl = textBox6.Text;
            string query = $"UPDATE GenelTablo SET ogrenci_no = '{ogrenci_no}', proje_adi = '{proje_adi}', Proje_Kaçıncı_YarıYıl = '{Proje_Kaçıncı_YarıYıl}', proje_danismani = '{proje_danismani}', Proje_Süresi_YarıYıl = '{Proje_Süresi_YarıYıl}' WHERE Proje_ID = '{proje_id}'";
            MySqlCommand komut = new MySqlCommand(query, baglanti);
            komut.ExecuteNonQuery();
            MessageBox.Show("Başarıyla Güncellendi", "Bildirim Kutusu");
            baglanti.Close();
        }
    }
}
