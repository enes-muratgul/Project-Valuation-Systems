using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Project_Evaluation_System
{
    public partial class GirisSayfa : Form
    {
        MySqlConnection baglanti = new MySqlConnection("Server = localhost;Database = gorselprogram; user=root;");

        public GirisSayfa()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string sorgu = "SELECT Email FROM kullanicilar";
            MySqlCommand komut = new MySqlCommand(sorgu, baglanti);
            baglanti.Open();
            MySqlDataReader satir = komut.ExecuteReader();
            
                while (satir.Read())
                {
                    string email = satir["Email"].ToString();
                    cmbMail.Items.Add(email);
                }
            baglanti.Close();
        }
        private void btnGiris_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = cmbMail.SelectedItem?.ToString();
            string sifre = txtSifre.Text;
            string sorgu = "SELECT * FROM kullanicilar WHERE Email = @email AND Sifre = @sifre";
            MySqlCommand komut = new MySqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@email", kullaniciAdi);
            komut.Parameters.AddWithValue("@sifre", sifre);
            baglanti.Open();
            MySqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("Giriş başarılı!");
                anaMenu anaMenu = new anaMenu();
                this.Hide();
                anaMenu.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre yanlış.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            baglanti.Close();

        }
    }
}
