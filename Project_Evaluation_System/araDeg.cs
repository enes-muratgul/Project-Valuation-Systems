using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Project_Evaluation_System
{

    public partial class araDeg : Form
    {
        MySqlConnection baglanti = new MySqlConnection("Server = localhost;Database = gorselprogram; user=root;");
        public araDeg(string ProjeID, string ProjeAdı, string Danisman, string Juri1, string Juri2, string Juri3, string Juri4, string Kac, string Sure)
        {
            InitializeComponent();
            txtProjeID.Text = ProjeID;
            txtProjeAdı.Text = ProjeAdı;
            txtProjeDanismani.Text = Danisman;
            txtJuri_1.Text = Juri1;
            txtJuri_2.Text = Juri2;
            txtJuri_3.Text = Juri3;
            txtJuri_4.Text = Juri4;
            txtProjeKacinci.Text = Kac;
            txtProjeSuresi.Text = Sure;
            int juriIndex = 1;
            lblJuri.Text = $"{juriIndex}. Jüri Üyesi";
            JuriSayac();
        }
        private void araDeg_Load(object sender, EventArgs e)
        {

        }

        private void btnSol_Click(object sender, EventArgs e)
        {
            int juriIndex = Int32.Parse(lblJuri.Text.Split('.')[0]);
            if (juriIndex > 1)
            {
                juriIndex--;
                lblJuri.Text = $"{juriIndex}. Jüri Üyesi";
                JuriSayac();
            }
        }

        private void btnSag_Click(object sender, EventArgs e)
        {
            int juriIndex = Int32.Parse(lblJuri.Text.Split('.')[0]);
            if (juriIndex < 4)
            {
                juriIndex++;
                lblJuri.Text = $"{juriIndex}. Jüri Üyesi";
                JuriSayac();
            }
        }

        private void btnGonder_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string proje_id = txtProjeID.Text;
            string ogrenci_no = txtOgrNo.Text;
            string proje_adi = txtProjeAdı.Text;
            string proje_danismani = txtProjeDanismani.Text;
            string ara_notu = lblOrt40.Text;
            string Proje_Kaçıncı_YarıYıl = txtProjeKacinci.Text;
            string Proje_Süresi_YarıYıl = txtProjeSuresi.Text;
            string query = "INSERT INTO GenelTablo (Proje_ID, ogrenci_no, proje_adi, proje_danismani, ara_notu,Proje_Kaçıncı_YarıYıl,Proje_Süresi_YarıYıl) " + $"VALUES ('{proje_id}', '{ogrenci_no}', '{proje_adi}', '{proje_danismani}', '{ara_notu}','{Proje_Kaçıncı_YarıYıl}','{Proje_Süresi_YarıYıl}')";
            MySqlCommand komut = new MySqlCommand(query, baglanti);
            komut.ExecuteNonQuery();
            MessageBox.Show("Başarıyla Eklendi", "Bildirim Kutusu");
            baglanti.Close();
        }

        private void JuriSayac()
        {
            int juriIndex = Int32.Parse(lblJuri.Text.Split('.')[0]);
            if (juriIndex == 1)
            {
                txtJuri1_1.Visible = true;  txtJuri1_2.Visible = true;  txtJuri1_3.Visible = true;  txtJuri1_4.Visible = true;
                txtJuri2_1.Visible = false; txtJuri2_2.Visible = false; txtJuri2_3.Visible = false; txtJuri2_4.Visible = false;
                txtJuri3_1.Visible = false; txtJuri3_2.Visible = false; txtJuri3_3.Visible = false; txtJuri3_4.Visible = false;
                txtJuri4_1.Visible = false; txtJuri4_2.Visible = false; txtJuri4_3.Visible = false; txtJuri4_4.Visible = false;
            }

            else if (juriIndex == 2)
            {
                txtJuri1_1.Visible = false; txtJuri1_2.Visible = false; txtJuri1_3.Visible = false; txtJuri1_4.Visible = false; 
                txtJuri2_1.Visible = true;  txtJuri2_2.Visible = true; txtJuri2_3.Visible  = true;  txtJuri2_4.Visible = true; 
                txtJuri3_2.Visible = false; txtJuri3_3.Visible = false; txtJuri3_4.Visible = false; txtJuri4_1.Visible = false;
                txtJuri4_2.Visible = false; txtJuri4_3.Visible = false; txtJuri4_4.Visible = false; txtJuri3_1.Visible = false;
            }

            else if (juriIndex == 3)
            {
                txtJuri1_1.Visible = false; txtJuri1_2.Visible = false; txtJuri1_3.Visible = false; txtJuri1_4.Visible = false;
                txtJuri2_1.Visible = false; txtJuri2_2.Visible = false; txtJuri2_3.Visible = false; txtJuri2_4.Visible = false;
                txtJuri3_1.Visible = true;  txtJuri3_2.Visible = true;  txtJuri3_3.Visible = true;  txtJuri3_4.Visible = true;
                txtJuri4_1.Visible = false; txtJuri4_2.Visible = false; txtJuri4_3.Visible = false; txtJuri4_4.Visible = false;
            }
            else if (juriIndex == 4)
            {
                txtJuri1_1.Visible = false; txtJuri1_2.Visible = false; txtJuri1_3.Visible = false; txtJuri1_4.Visible = false;
                txtJuri2_1.Visible = false; txtJuri2_2.Visible = false; txtJuri2_3.Visible = false; txtJuri2_4.Visible = false;
                txtJuri3_1.Visible = false; txtJuri3_2.Visible = false; txtJuri3_3.Visible = false; txtJuri3_4.Visible = false;
                txtJuri4_1.Visible = true;  txtJuri4_2.Visible = true;  txtJuri4_3.Visible = true;  txtJuri4_4.Visible = true;
            }
        }
      

        

        public void araDege(string OgrenciID, string OgrenciAdSoyad, string OgrenciNo)
        {
            txtOgrenciID.Text = OgrenciNo;
            txtOgrAdSoyad.Text = OgrenciAdSoyad;
            txtOgrNo.Text = OgrenciID;
        }

        private double OrtHesap1()
        {
            double juri1Note1, juri1Note2, juri1Note3;
            if (double.TryParse(txtJuri1_1.Text, out juri1Note1) && double.TryParse(txtJuri1_2.Text, out juri1Note2) && double.TryParse(txtJuri1_3.Text, out juri1Note3))
            {
                double average = (juri1Note1 + juri1Note2 + juri1Note3) / 3;
                txtJuri1_4.Text = average.ToString("F2");
                txtOrtHsp1.Text = average.ToString();
                return average;
            }
            else
            {
                txtJuri1_4.Clear();
                return 0;
            }

        }

        private double OrtHesap2()
        {
            double juri2Note1, juri2Note2, juri2Note3;
            if (double.TryParse(txtJuri2_1.Text, out juri2Note1) && double.TryParse(txtJuri2_2.Text, out juri2Note2) && double.TryParse(txtJuri2_3.Text, out juri2Note3))
            {
                double average = (juri2Note1 + juri2Note2 + juri2Note3) / 3;
                txtJuri2_4.Text = average.ToString("F2");
                return average;
            }
            else
            {
                txtJuri2_4.Clear();
                return 0;
            }
        }

        private double OrtHesap3()
        {
            double juri3Note1, juri3Note2, juri3Note3;
            if (double.TryParse(txtJuri3_1.Text, out juri3Note1) && double.TryParse(txtJuri3_2.Text, out juri3Note2) && double.TryParse(txtJuri3_3.Text, out juri3Note3)) 
            {
                double average = (juri3Note1 + juri3Note2 + juri3Note3) / 3;
                txtJuri3_4.Text = average.ToString("F2");
                return average;
            }
            else
            {
                txtJuri3_4.Clear();
                return 0;
            }
        }

        private double OrtHesap4()
        {
            double juri4Note1, juri4Note2, juri4Note3;
            if (double.TryParse(txtJuri4_1.Text, out juri4Note1) && double.TryParse(txtJuri4_2.Text, out juri4Note2) && double.TryParse(txtJuri4_3.Text, out juri4Note3))
            {
                double average = (juri4Note1 + juri4Note2 + juri4Note3) / 3;
                txtJuri4_4.Text = average.ToString("F2");
                return average;
            }
            else
            {
                txtJuri4_4.Clear();
                return 0;
            }
        }

        private void hesap()
        {
            double totalAverage = (OrtHesap1() + OrtHesap2() + OrtHesap3() + OrtHesap4()) / 4;
            txtOrtHsp1.Text = totalAverage.ToString("F2");
            txtOrtHsp2.Text = totalAverage.ToString("F2");
            txtOrtHsp3.Text = totalAverage.ToString("F2");
            txtOrtHsp4.Text = totalAverage.ToString("F2");
            double finalScore = totalAverage * 0.40;
            lblOrt40.Text = finalScore.ToString("F2");
        }

        private void txtJuri1_1_TextChanged(object sender, EventArgs e)
        {
            OrtHesap1();
            hesap();
        }

        private void txtJuri1_2_TextChanged(object sender, EventArgs e)
        {
            OrtHesap1();
            hesap();
        }

        private void txtJuri1_3_TextChanged(object sender, EventArgs e)
        {
            OrtHesap1();
            hesap();
        }

        private void txtJuri2_1_TextChanged(object sender, EventArgs e)
        {
            OrtHesap2();
            hesap();
        }

        private void txtJuri2_2_TextChanged(object sender, EventArgs e)
        {
            OrtHesap2();
            hesap();
        }

        private void txtJuri2_3_TextChanged(object sender, EventArgs e)
        {
            OrtHesap2();
            hesap();
        }

        private void txtJuri3_1_TextChanged(object sender, EventArgs e)
        {
            OrtHesap3();
            hesap();
        }

        private void txtJuri3_2_TextChanged(object sender, EventArgs e)
        {
            OrtHesap3();
            hesap();
        }

        private void txtJuri3_3_TextChanged(object sender, EventArgs e)
        {
            OrtHesap3();
            hesap();
        }

      

        private void txtJuri4_1_TextChanged(object sender, EventArgs e)
        {
            OrtHesap4();
            hesap();
        }

        private void txtJuri4_2_TextChanged(object sender, EventArgs e)
        {
            OrtHesap4();
            hesap();
        }

        private void txtJuri4_3_TextChanged(object sender, EventArgs e)
        {
            OrtHesap4();
            hesap();
        }

        private void txtJuri4_4_TextChanged(object sender, EventArgs e)
        {

        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void txtJuri3_4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}


       
    
    
    

