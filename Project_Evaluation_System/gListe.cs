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
    public partial class gListe : Form
    {
        MySqlConnection baglanti = new MySqlConnection("Server = localhost;Database = gorselprogram; user=root;");
        public gListe()
        {
            InitializeComponent();
        }

        private void gListe_Load(object sender, EventArgs e)
        {
            listele();
        }
        private void listele()
        {
            baglanti.Open();
            MySqlDataAdapter adaptor = new MySqlDataAdapter("SELECT * FROM geneltablo ORDER BY Proje_ID", baglanti);
            DataTable dt = new DataTable();
            dt.Clear();
            adaptor.Fill(dt);
            dataGridView1.DataSource = dt;
            adaptor.Dispose();
            baglanti.Close();
        }

        private void btnHataDuzelt_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen güncellenecek bir satır seçin.");
            }
            else
            {
                int selectedRowIndex = dataGridView1.SelectedRows[0].Index;

                string projeID = dataGridView1.Rows[selectedRowIndex].Cells["Proje_ID"].Value.ToString();
                string ogrenciNo = dataGridView1.Rows[selectedRowIndex].Cells["ogrenci_no"].Value.ToString();
                string projeAdi = dataGridView1.Rows[selectedRowIndex].Cells["proje_adi"].Value.ToString();
                string projeDanismani = dataGridView1.Rows[selectedRowIndex].Cells["proje_danismani"].Value.ToString();
                string projeSuresiYariYil = dataGridView1.Rows[selectedRowIndex].Cells["Proje_Süresi_YarıYıl"].Value.ToString();
                string projeKacinciYariYil = dataGridView1.Rows[selectedRowIndex].Cells["Proje_Kaçıncı_YarıYıl"].Value.ToString();

                guncelle guncelleForm = new guncelle(projeID, projeAdi, ogrenciNo, projeDanismani, projeSuresiYariYil, projeKacinciYariYil);
                guncelleForm.ShowDialog();
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }
    }
}
