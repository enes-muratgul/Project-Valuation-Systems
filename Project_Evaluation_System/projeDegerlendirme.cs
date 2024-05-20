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
    public partial class projeDegerlendirme : Form
    {
        MySqlConnection baglanti = new MySqlConnection("Server = localhost;Database = gorselprogram; user=root;");
        public projeDegerlendirme()
        {
            InitializeComponent();
        }

        private void projeDegerlendirme_Load(object sender, EventArgs e)
        {
            listele();
            string asd = "SELECT ad_soyad FROM akademisyenler";
            MySqlCommand asdd = new MySqlCommand(asd, baglanti);
            baglanti.Open();
            MySqlDataReader dr = asdd.ExecuteReader();
            while (dr.Read())
            {
              string adSoyad = dr["ad_soyad"].ToString();
              cmbProjeDanismani.Items.Add(adSoyad);
              cmbJuri_1.Items.Add(adSoyad);
              cmbJuri_2.Items.Add(adSoyad);
              mbJuri_3.Items.Add(adSoyad);
              cmbJuri_4.Items.Add(adSoyad);
                    
            }
            baglanti.Close();
        }

        private void listele()
        {
            baglanti.Open();
            MySqlDataAdapter adaptor = new MySqlDataAdapter("SELECT * FROM ogrenciler ORDER BY ogrenci_id", baglanti);
            DataTable dt = new DataTable();
            dt.Clear();
            adaptor.Fill(dt);
            dataGridView1.DataSource = dt;
            adaptor.Dispose();
            baglanti.Close();
        }
        private void btnAraDeg_Click(object sender, EventArgs e)
        {
            araDeg araDegForm = new araDeg(txtProjeID.Text, txtProjeAdi.Text, cmbProjeDanismani.Text, cmbJuri_1.Text, cmbJuri_2.Text, mbJuri_3.Text, cmbJuri_4.Text, txtProjeKacinci.Text, txtProjeSuresi.Text);
            araDegForm.Show();
            int selectedRowIndex = dataGridView1.CurrentCell.RowIndex;
            if (selectedRowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[selectedRowIndex];
                string OgrenciNo = selectedRow.Cells["ogrenci_no"].Value.ToString();
                string OgrenciAdSoyad = selectedRow.Cells["ogrenci_ad_soyad"].Value.ToString();
                string OgrenciID = selectedRow.Cells["ogrenci_id"].Value.ToString(); 
                araDegForm.araDege(OgrenciNo, OgrenciAdSoyad, OgrenciID);
            }

        }

        private void btnFinalDeg_Click(object sender, EventArgs e)
        {

            finalDeg FinalDegForm = new finalDeg(txtProjeID.Text, txtProjeAdi.Text, cmbProjeDanismani.Text, cmbJuri_1.Text, cmbJuri_2.Text, mbJuri_3.Text, cmbJuri_4.Text);
            FinalDegForm.Show();
            int selectedRowIndex = dataGridView1.CurrentCell.RowIndex;
            if (selectedRowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[selectedRowIndex];
                string OgrenciNo = selectedRow.Cells["ogrenci_no"].Value.ToString();
                string OgrenciAdSoyad = selectedRow.Cells["ogrenci_ad_soyad"].Value.ToString();
                string OgrenciID = selectedRow.Cells["ogrenci_id"].Value.ToString(); 
                FinalDegForm.finalDege(OgrenciNo, OgrenciAdSoyad, OgrenciID);
            }
        }

        private void btnOgrenciEkle_Click(object sender, EventArgs e)
        {
            ogrEkle ogrEkle = new ogrEkle();
            ogrEkle.ShowDialog();
        }

        private void btnOgrenciCikar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Seçili satırı silmek istediğinizden emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    int selectedRowIndex = dataGridView1.SelectedRows[0].Index;
                    int ogrenci_id = Convert.ToInt32(dataGridView1.Rows[selectedRowIndex].Cells["ogrenci_id"].Value);
                    baglanti.Open();
                    MySqlCommand komut = new MySqlCommand();
                    komut.CommandText = "DELETE FROM ogrenciler WHERE ogrenci_id = @pogrenci_id";
                    komut.Parameters.AddWithValue("@pogrenci_id", ogrenci_id);
                    komut.Connection = baglanti;
                    int satir = komut.ExecuteNonQuery();
                    baglanti.Close();
                    if (satir > 0)
                        dataGridView1.Rows.RemoveAt(selectedRowIndex);
                    else
                        MessageBox.Show("Silme işlemi başarısız oldu.");

                    MessageBox.Show(satir + " satır silindi");
                }
            }
            else
            {
                MessageBox.Show("Lütfen önce bir satır seçin.");
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            
        }
      
    }
}
